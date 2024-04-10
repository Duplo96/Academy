const calcolaDataOggi = () => {
  return new Date();
};

export const saluta = (varNome: String): String => {
  return `Ciao ${varNome} ${calcolaDataOggi()}`;
};
