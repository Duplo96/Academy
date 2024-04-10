class Ruota {
  private diametro: Number;

  constructor(varDia) {
    this.diametro = varDia;
  }

  public stampaDettaglio() {
    return `Ruota: ${this.diametro}`;
  }
}

class Automobile {
  private ruote: Ruota[] = new Array();
  private marca: String;

  constructor() {}

  public setMarca(varMarca: String): void {
    this.marca = varMarca;
  }

  public getMarca(): String {
    return this.marca;
  }

  public addRuota(objRuota: Ruota) {
    this.ruote.push(objRuota);
  }

  public stampaDettaglio() {
    console.log(`Automobile: ${this.marca}`);

    this.ruote.forEach((element) => {
      console.log(element.stampaDettaglio());
    });
  }
}

let autoU = new Automobile();

autoU.setMarca("Audi");

autoU.addRuota(new Ruota(16));
autoU.addRuota(new Ruota(16));
autoU.addRuota(new Ruota(16));
autoU.addRuota(new Ruota(16));

autoU.stampaDettaglio();
