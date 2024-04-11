import { Component } from '@angular/core';
import { Persona } from './persona';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'ang_01_test';

  constructor() {
    let per = new Persona();
    per.nome = 'Giovanni';
    per.cognome = 'Pace';
    per.eta = 37;
  }

  ngOnInit(): void {
    console.log('Sono il ngOnInit di AppComponent');
  }
}
