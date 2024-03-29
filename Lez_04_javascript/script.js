let temperatura = document.getElementById("input-temp");
let tempMinima = 37;

function dati() {
  document.getElementById("corpo-personalizzato").innerHTML = `<p>${
    temperatura.value > tempMinima ? "Non puoi entrare" : "Puoi entrare"
  }</p>`;
}
