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
import { TransportConnectionProvider } from "./TransportConnectionProvider";
import { Injectable } from "@angular/core";
import { CrossDomainEventBus, WebBrokerConnectionBuilder, CrossDomainEventBusProvider } from "@plexus-interop/broker";
import { TransportConnection } from "@plexus-interop/transport-common";
import { InteropServiceFactory } from "../core/InteropServiceFactory";
import { UrlResolver } from "../core/UrlResolver";
import { WebSocketConnectionFactory } from "@plexus-interop/websocket-transport";
import { DomUtils } from "@plexus-interop/common";

@Injectable()
export class TransportConnectionFactory {

    private readonly serviceFactory: InteropServiceFactory = new InteropServiceFactory();
    private readonly urlResolver: UrlResolver = new UrlResolver();

    public createWebTransportProvider(baseUrl: string): TransportConnectionProvider {
        return async () => {
            let eventBus: CrossDomainEventBus;
            const proxyHostUrl = this.urlResolver.getProxyHostUrl(baseUrl);
            const iFrameId = "plexus-" + DomUtils.getOrigin(proxyHostUrl).replace(/\.\/\:/g, "-");
            const connection: TransportConnection = await new WebBrokerConnectionBuilder()
                .withAppRegistryProviderFactory(async () => this.serviceFactory.createAppRegistryProvider(baseUrl))
                .withInteropRegistryProviderFactory(async () => this.serviceFactory.createInteropRegistryProvider(baseUrl))
                .withEventBusProvider(async () => {
                    eventBus = await new CrossDomainEventBusProvider(
                        async () => proxyHostUrl, iFrameId)
                        .connect() as CrossDomainEventBus;
                    return eventBus;
                })
                .connect();
            return connection;
        };
    }

    public createWebSocketTransportProvider(wsUrl: string): TransportConnectionProvider {
        return () => new WebSocketConnectionFactory(new WebSocket(wsUrl)).connect();
    }

}