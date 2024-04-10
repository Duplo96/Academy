abstract class Persona {
  private nominativo: String | undefined | null;

  constructor(varNome?: String | null) {
    this.nominativo = varNome;
  }
}

class Studente extends Persona {
  private matricola: String;

  constructor(varMatri: String, varNominativo?: String | null) {
    super(varNominativo);
    this.matricola = varMatri;
  }
}
class Docente extends Persona {}

class Segretario extends Persona {}

let studUno = new Studente("Giovanni");

let studDue = new Studente("Mario", "AB1234");

let studTre = new Studente("Valeria", null);
