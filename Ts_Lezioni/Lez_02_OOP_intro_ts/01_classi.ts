class Automobile {
  marca: String;
  modello: String;

  constructor(varMarca: String, varModello: String) {
    this.marca = varMarca;
    this.modello = varModello;
  }

  stampaDettaglio(): void {
    console.log(`Automobile ${this.marca} ${this.modello}`);
  }
}

let autoUno = new Automobile("BMW", "Da corsa");
autoUno.stampaDettaglio();
