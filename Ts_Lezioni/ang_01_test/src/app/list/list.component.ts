import { Component } from '@angular/core';
import { Persona } from '../persona';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.css',
})
export class ListComponent {
  elenco: Persona[] = new Array();

  constructor() {}

  ngOnInit(): void {
    setTimeout(() => {
      this.elenco.push(new Persona('Giovanni', 'Pace', 37));
      this.elenco.push(new Persona('Valeria', 'Verdi', 17));
      this.elenco.push(new Persona('Marika', 'Mariko', 27));
    }, 2000);
  }
}
