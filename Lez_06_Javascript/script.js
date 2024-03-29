let elenco = ["BMW", "Maserati", "Fiat"];

elenco.push("Lamborghini");
elenco.splice(2, 1);

for (const [index, value] of elenco.entries()) {
  console.log(index, value);
}

let persona = {
  nome: "Giovanni",
  cognome: "Pace",
  telefono: "37",
};

console.log(persona);
