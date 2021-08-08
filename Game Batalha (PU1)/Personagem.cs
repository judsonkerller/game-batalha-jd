using System;

class Personagem {

  // Atributos do personagem

    private string nome = "";
    private int vida = 0;
    private int forca = 0;
    private int defesa = 0;
    private Arma espada = null;

    public void PegarItem(Arma item) {
      this.espada = item;
    }

    public Arma VerItem() {
      return this.espada;
    }

    public Personagem (string nome, int vida, int forca, int defesa) {
      this.SetNome(nome);
      this.SetVida(vida);
      this.SetForca(forca);
      this.SetDefesa(defesa);
    }

    public void SetNome(string nome) {
      this.nome = nome;
    }

    public string GetNome() {
      return this.nome;
    }
    
    public void SetVida(int vida) {
      if(vida > 150)
      vida = 150;
      this.vida = vida;
    }

    public int GetVida() {
      if (this.vida < 0) {
        return 0;
      } else {
        return this.vida;
      }
    }

    public void SetForca(int forca) {
      if(forca > 100)
      forca = 100;
      this.forca = forca;
    }

    public int GetForca() {
      return this.forca;
    }

    public void SetDefesa(int defesa) {
      this.defesa = defesa;
    }

    public int GetDefesa() {
      return this.defesa;
    }

  //Métodos do Personagem

    public void Atacar (Monstro alvo) {

      int dano = this.forca;
      alvo.SetVida(alvo.GetVida() - (this.forca + espada.GetAtaque()));
      Console.WriteLine("O personagem " + this.nome + " atacou o " + alvo.GetNome() + " e tirou " + (dano + espada.GetAtaque()) + ".");
      Console.WriteLine("O " + alvo.GetNome() + " ficou com " + alvo.GetVida() + ".");
    }

    public bool EstaVivo() {
      return this.vida > 0;
    }
}