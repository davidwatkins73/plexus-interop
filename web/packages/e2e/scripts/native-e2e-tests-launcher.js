/**
 * Copyright 2017 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
const argv = require('minimist')(process.argv.slice(2));
const exec = require('child_process').exec;
const kill = require('tree-kill');
const log = console.log.bind(console);
const startNativeBroker = require('./native-broker-launcher').start;

let brokerProcess;

function main() {
    log('Passed arguments' + JSON.stringify(argv));
    startNativeBroker()
        .then(brokerInfo => {
            brokerProcess = brokerInfo.process;
            runElectronTest(brokerInfo.workingDir);
        });
}

function killBroker() {
    if (brokerProcess) {
        log("Killing broker process ...");
        kill(brokerProcess.pid);
        log("Kill signal sent");
    }
}

function runElectronTest(wsUrl) {
    log("Starting Electron Tests ...");
    exec(`electron-mocha --require scripts/coverage ${argv.file} --wsUrl ${wsUrl} ${argv.debug ? "--debug" : ""} --renderer --reporter spec --colors`, {
        cwd: process.cwd()
    }, (error, stdout, stderr) => {
        log("Electron tests stopped, killing Broker");
        if (error || stderr) {
            console.error('Std Error:', stderr);
            console.error('Error: ', error);
        }
        log('StdOut', stdout);
        killBroker();
    });
}

main();


