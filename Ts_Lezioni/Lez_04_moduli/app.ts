import { saluta } from "./funzioni_utilita";
import { Persona } from "./Persona";
console.log(saluta("Gio"));

let gio = new Persona("Giovanni Pace");

console.log(gio.stampaDettaglio());

let val = new Persona("Valeria", "Via pippo pippi", "Ciccia");
console.log(val.stampaDettaglio());
