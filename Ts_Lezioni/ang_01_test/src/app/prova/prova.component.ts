import { Component } from '@angular/core';

@Component({
  selector: 'app-prova',
  templateUrl: './prova.component.html',
  styleUrl: './prova.component.css',
})
export class ProvaComponent {
  constructor() {}

  ngOnInit(): void {
    console.log('Sono il ngOnInit di ProvaComponent');
  }
}
