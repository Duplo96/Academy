export class Prodotto {
  codice: string | undefined;
  descrizione: string | undefined;
  nome: string | undefined;
  prezzo: number | undefined;

  constructor(
    codice?: string,
    nome?: string,
    descrizione?: string,
    prezzo: number = 0
  ) {
    this.codice = codice;
    this.descrizione = descrizione;
    this.nome = nome;
    this.prezzo = prezzo;
  }
}
