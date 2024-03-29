let elencoStringa = localStorage.getItem("elenco");
let elenco = [];
if (!elencoStringa) {
  localStorage.setItem("elenco", JSON.stringify(elenco));
} else elenco = JSON.parse(elencoStringa);

function aggiungi() {
  let elencoDaIns =
    localStorage.getItem("elenco") != null
      ? JSON.parse(localStorage.getItem("elenco"))
      : [];
  let varNome = document.getElementById("input-nome").value;
  let varCognome = document.getElementById("input-cognome").value;
  let varMatricola = document.getElementById("input-matricola").value;
  let stud = {
    nome: varNome,
    cognome: varCognome,
    matricola: varMatricola,
  };
  elencoDaIns.push(stud);

  localStorage.setItem("elenco", JSON.stringify(elenco));
  stampa();
}
function stampa() {
  let elencoDaSta =
    localStorage.getItem("elenco") != null
      ? JSON.parse(localStorage.getItem("elenco"))
      : [];
  let contenuto = "";

  for (let [idx, item] of elencoDaSta.entries()) {
    contenuto += `<tr>
    <td> ${idx + 1}</td>
    <td>${item.nome} </td>
    <td> ${item.cognome}</td>
    <td> ${item.matricola}</td>
    <td> <button type="button" class="btn btn-danger" onclick="elimina(${idx})"> Elimina </button></td>
    </tr>`;
  }
  document.getElementById("corpo-tabella").innerHTML = contenuto;
}

function elimina(varIdx) {
  stampa();
}
stampa();
