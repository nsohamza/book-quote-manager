/*import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppModule } from './app/app.module';
//import { appConfig } from './app/app.config';

platformBrowserDynamic().bootstrapModule(AppModule)
.catch(err => console.error(err));

/// the bootstrapfile which is main.ts
// the point of this file is to what will be loaded up
// at the start of the application. 

*/
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';

platformBrowserDynamic().bootstrapModule(AppModule, {
  ngZoneEventCoalescing: true
})
  .catch(err => console.error(err));
