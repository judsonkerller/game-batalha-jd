using System;

class MainClass {
    public static void Main (string[] args) {
       int comandoMenu = 0;
    
    Console.WriteLine("Let's bora");

    Console.WriteLine("\n***Character***");
    
    Personagem personagemUm = new Personagem ("Judson", 130, 50, 35);
    Console.WriteLine("Nome:" + personagemUm.GetNome());
    Console.WriteLine("Vida:" + personagemUm.GetVida());
    Console.WriteLine("Forca:" + personagemUm.GetForca());
    Console.WriteLine("Defesa:" + personagemUm.GetDefesa());
    Console.WriteLine("***Equipamento***");

    Arma armaUm = new Arma("Escalibur", 60);
    Console.WriteLine("Nome:" + armaUm.GetNome());
    Console.WriteLine("Ataque:" + armaUm.GetAtaque());  
    personagemUm.PegarItem(armaUm);

    Console.WriteLine("\n***Monstro:***");

    Monstro monstroUm = new Monstro ("Durotan", "Ogro", 300, 110, 60);
    Console.WriteLine("Nome:" + monstroUm.GetNome());
    Console.WriteLine("Raça:" + monstroUm.GetRaca());
    Console.WriteLine("Vida:" + monstroUm.GetVida());
    Console.WriteLine("Forca:" + monstroUm.GetForca());

  do {
    Menu();
    comandoMenu = int.Parse(Console.ReadLine());
    switch (comandoMenu) {
      case 1:
      personagemUm.Atacar(monstroUm);
      monstroUm.EstaVivo();
      break;
      case 2:
      monstroUm.Atacar(personagemUm);
      personagemUm.EstaVivo();
      break;
    }
  }
    while (personagemUm.GetVida() > 0 && monstroUm.GetVida() > 0);
      Console.WriteLine("Vlws");
  }

  public static void Menu () {
    Console.WriteLine("\nBem Vindo a prova :D");
    Console.WriteLine("1 - Atacar o monstro");
    Console.WriteLine("2 - Atacar o personagem");
  }
}