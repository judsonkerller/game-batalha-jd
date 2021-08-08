

using System;

class Monstro {

  // Atributos do monstro

    private string nome = "";
    private string raca = "";
    private int vida = 0;
    private int forca = 0;
    private int agilidade = 0;

  // Metodos da classe

    public Monstro (string nome, string raca, int vida, int forca, int agil) {
      this.SetNome(nome);
      this.SetRaca(raca);
      this.SetVida(vida);
      this.SetForca(forca);
      this.SetAgil(agil);
    }

    public void SetNome(string nome) {
      this.nome = nome;
    }

    public string GetNome() {
      return this.nome;
    }

    public void SetRaca(string raca) {
      this.raca = raca;
    }

    public string GetRaca() {
      return this.raca;
    }

    public void SetVida(int vida) {
      if(vida > 250)
      vida = 250;
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
      forca = 60;
      this.forca = forca;
    }

    public int GetForca() {
      return this.forca;
    }

    public void SetAgil(int agilidade) {
      this.agilidade = agilidade;
    }

    public int GetAgil() {
      return this.agilidade;
    }

  // Métodos do Monstro

    public void Atacar (Personagem alvo) {
      int dano = this.forca;
      alvo.SetVida(alvo.GetVida() - (this.forca - alvo.GetDefesa()));
      Console.WriteLine("O monstro " + this.nome + " atacou o " + alvo.GetNome() + " e tirou " + (dano - alvo.GetDefesa()) + ".");
      Console.WriteLine("O " + alvo.GetNome() + " ficou com " + alvo.GetVida() + ".");
    }

    public bool EstaVivo() {
      return this.vida > 0;
    }
}