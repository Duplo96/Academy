// let saluta = "Hello world";

// let intero = 1234;

// let booleano = true;

// let prova = null;

// let prova2;

// if (!prova) console.log("caso positivo");
// else console.log("caso negativo");

//------------------------------------------------

// const persona = {
//   nome: "Giovanni",
//   cognome: "Pace",
// };
// console.log(persona);

// let personaDue = new Object();
// personaDue.nome = "Giovanni";

// console.log(personaDue);

//------------------------------------------------

// const saluta = (varnome) => {
//   console.log(`Ciao ${varnome}`);
// };

// saluta("Giovanni");
// saluta("Pippo");
// saluta("Pluto");
// saluta({ nome: "Giovanni" });

//------------------------------------------------

// let persona = {
//   nome: 3,
// };

// let oggi = new Date();

// console.log(oggi);
// let insieme = new Set([1, 2, 3, 4, 1, "lamborghini"]);
// console.log(insieme);

//------------------------------------------------

// let equivalenteHashTable = new Map();

// equivalenteHashTable.set("chiave uno", "Giovanni");
// equivalenteHashTable.set("chiave due", 34);
// equivalenteHashTable.set("chiave tre", { nome: "Giovanni" });
// equivalenteHashTable.set({ nome: "Mariko" }, { giardino: false });
// console.log(equivalenteHashTable);

// console.log(equivalenteHashTable.get({ nome: "Mariko" }));

// equivalenteHashTable.delete();

// console.log(equivalenteHashTable.size);

// let automobili = ["Lamborghini", "FIAT", "Skoda"];

// console.log(automobili.length);

//------------------------------------------------

// let mappa = new Map([
//   ["chiave 1", "valore 1"],
//   ["chiave 2", "valore 2"],
//   ["chiave 3", "valore 3"],
// ]);

// for (let chiave of mappa.keys()) {
//   console.log(chiave);
// }

// mappa.forEach((valore, chiave) => {
//   console.log(chiave, valore);
// });

//------------------------------------------------

// let elenco = [1, 2, 3, 4, 5];

// let quadrati = elenco.map((elemento) => {
//   return elemento * elemento;
// });

// quadrati = elenco.map((elemento) => elemento * elemento);

// console.log(elenco);
// console.log(quadrati);

//------------------------------------------------

// const persone = [
//   { nome: "Mario", cognome: "Rossi" },
//   { nome: "Luigi", cognome: "Bianchi" },
//   { nome: "Anna", cognome: "Verdi" },
// ];

// const elenco = persone.map((p) => `${p.nome} ${p.cognome}`);

// console.log(persone);
// console.log(elenco);

//------------------------------------------------

const persone = [
  { nome: "Mario", cognome: "Rossi" },
  { nome: "Luigi", cognome: "Bianchi", eta: 23 },
  { nome: "Anna", cognome: "Verdi" },
];

const indVal = persone.map(
  (valore, indice) => `Indice:${indice + 1}, valore:${valore.nome}`
);

console.log(indVal);
