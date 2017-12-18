import { Component, OnInit } from '@angular/core';
import { AppActions } from "../services/app.actions";
import { Store } from "@ngrx/store";
import * as fromRoot from '../services/reducers';
import { Router } from "@angular/router";
import { SubsctiptionsRegistry } from "../services/SubsctiptionsRegistry";
import { InteropRegistryService } from "@plexus-interop/broker";
import { DiscoveredMethod } from "@plexus-interop/client";

@Component({
  selector: 'app-consumed-service',
  templateUrl: './consumed-service.component.html',
  styleUrls: ['./consumed-service.component.css'],
  providers: [SubsctiptionsRegistry]
})
export class ConsumedServiceComponent implements OnInit {

  private registryService: InteropRegistryService;

  private discoveredMethods: DiscoveredMethod[];

  constructor(
    private actions: AppActions,
    private store: Store<fromRoot.State>,
    private router: Router,
    private subscriptions: SubsctiptionsRegistry) {
  }

  ngOnInit() {

    const consumedMethod$ = this.store
      .filter(state => !!state.plexus.consumedMethod)
      .map(state => state.plexus);

    this.subscriptions.add(
      consumedMethod$.subscribe(state => {
        this.discoveredMethods = state.consumedMethod.discoveredMethods.methods;
      }));

  }

}
