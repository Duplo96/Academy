import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'ang_01_test';

  constructor() {
    console.log('ciao giovanni come stai');
  }
}
