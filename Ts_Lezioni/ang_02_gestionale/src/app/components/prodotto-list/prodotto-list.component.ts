import { Component } from '@angular/core';
import { Prodotto } from '../../models/prodotto';
import { ProdottoService } from '../../services/prodotto.service';

@Component({
  selector: 'app-prodotto-list',
  templateUrl: './prodotto-list.component.html',
  styleUrl: './prodotto-list.component.css',
})
export class ProdottoListComponent {
  listaProd: Prodotto[] = [];

  constructor(private service: ProdottoService) {}

  ngOnInit() {
    this.listaProd = this.service.recuperaProdotti();
  }
}
