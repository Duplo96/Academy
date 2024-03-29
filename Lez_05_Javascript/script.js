let inputNome = document.getElementById("input-Nome");
let inputCognome = document.getElementById("input-Cognome");
let inputEmail = document.getElementById("input-mail");

contenuto = "";
let counter = 1;
function salva() {
  let nome = inputNome.value;
  let cognome = inputCognome.value;
  let email = inputEmail.value;

  contenuto += `<tr>
  <td>${counter}</td>
  <td>${nome}</td>
  <td>${cognome}</td>
  <td>${email}</td>
    </tr>`;
  counter++;
  document.getElementById("corpo-tabella").innerHTML = contenuto;
  document.getElementById("input-Nome").value = "";
  document.getElementById("input-Cognome").value = "";
  document.getElementById("input-mail").value = "";
}
