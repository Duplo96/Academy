import { Component } from '@angular/core';

@Component({
  selector: 'app-prodotto-create',
  templateUrl: './prodotto-create.component.html',
  styleUrl: './prodotto-create.component.css',
})
export class ProdottoCreateComponent {
  codice: string | undefined;

  salvaProdotto() {}
}
