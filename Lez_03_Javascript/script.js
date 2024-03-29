const saluta = () => {
  document.getElementById("bottoneSaluta");
  console.log("Ciao");
};
const dati = () => {
  let lista = {
    nome: "",
    numero: "",
    data: "",
  };
  lista.nome = document.getElementById("input-nome").value;
  lista.numero = document.getElementById("input-numero").value;
  lista.data = document.getElementById("input-nascita").value;
  console.log(lista);
};

// function somma(varUno, varDue) {
//   let risultato = varUno + varDue;
//   console.log(risultato);
//   return risultato;
// }
