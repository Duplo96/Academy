class Componente {
  private descrizione: String;
  constructor(varDesc: String) {
    this.descrizione = varDesc;
  }
}

class Auto {
  private motore: Componente[];
  private marca: String;

  constructor() {}

  public setMarca(varMarca: String): void {
    this.marca = varMarca;
  }

  public getMarca(): String {
    return this.marca;
  }

  public stampaDettaglio() {
    console.log(`Automobile: ${this.marca}`);
  }

  public addComponente(objCom: Componente): void {
    if (!this.motore) this.motore = new Array();

    this.motore.push(objCom);
  }
}

let autoD = new Auto();

autoD.setMarca("Audi");

autoD.stampaDettaglio();
