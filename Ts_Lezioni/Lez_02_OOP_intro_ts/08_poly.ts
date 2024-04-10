interface Animale {
  versoEmesso(): void;
}

class Gatto implements Animale {
  versoEmesso(): void {
    console.log("Miao");
  }
}

class Cane implements Animale {
  versoEmesso(): void {
    console.log("Bau");
  }
}

class Coccodrillo implements Animale {
  versoEmesso(): void {
    console.log("Boh");
  }
}

let prova: Animale; //Gatto | Cane | Coccodrillo

prova = new Gatto();

prova = new Coccodrillo();

const emettiVerso = (objAni: Animale) => {
  objAni.versoEmesso();
};
emettiVerso(new Gatto());
emettiVerso(new Cane());
emettiVerso(new Coccodrillo());
