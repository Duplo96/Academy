// const somma = (a: number, b: number): number => {
//   return a + b;
// };

// let numero: Number = 5;

// let num: number = 6;

//---------------------------------

/**
 * funzione saluta
 * @param varNome Nome della persona
 * @param varCognome Cognome della persona
 * @param varTitolo Titolo  della persona | Undefined
 */

// const saluta = (varNome: String, varCognome: String, varTitolo?: String) => {
//   if (varTitolo) console.log(` Ciao ${varTitolo} ${varNome} ${varCognome}`);
//   else console.log(` Ciao ${varNome} ${varCognome}`);
// };
// saluta("Pippo", "Pippi");

//---------------------------------

const saluta = (
  varNome: String,
  varCognome: String,
  varTitolo: String | null = "N.D."
) => {
  console.log(` Ciao ${varTitolo} ${varNome} ${varCognome}`);
};
saluta("Pippo", "Pippi", "Sig.ra");
