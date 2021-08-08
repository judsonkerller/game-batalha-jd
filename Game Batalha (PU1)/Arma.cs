using System;

class Arma {
 
    private string nome = "";
    private int ataque = 0;
    private int valor = 0;

    public Arma (string nome, int ataque) {
    this.SetNome(nome);
    this.SetAtaque(ataque);
   }

    public void SetNome(string nome) {
      this.nome = nome;
   }

    public string GetNome() {
      return this.nome;
   }

    public void SetAtaque(int ataque) {
      this.ataque = ataque;
   }

    public int GetAtaque() {
      return this.ataque;
   }

    public void SetValor(int valor) {
      this.valor = valor;
   }

    public int GetValor() {
      return this.valor;
   }
}