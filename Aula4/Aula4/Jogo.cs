using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Jogo
    {
        Heroi heroi;
        Random rand = new Random();
        string nome, classe;
        public void Iniciar()
        {
            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Escolha a classe do seu herói:");
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - Necromancer");
            Console.WriteLine("3 - Druida");
            Console.WriteLine("4 - Paladino");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "guerreiro":
                    classe = "Guerreiro";
                    heroi = new Heroi(nome, classe);
                    heroi.vida += 20;
                    break;
                case "2":
                case "necromancer":
                    classe = "Necromancer";
                    heroi = new Heroi(nome, classe);
                    heroi.ataqueBase = rand.Next(1, 20); 
                    break;
                case "3":
                case "druida":
                    classe = "Druida";
                    heroi = new Heroi(nome, classe);
                    heroi.vida += 15;
                    heroi.ataqueBase = rand.Next(1, 16);
                    break;
                case "4":
                case "paladino":
                    classe = "Paladino";
                    heroi = new Heroi(nome, classe);
                    heroi.vida += 12;
                    heroi.ataqueBase = rand.Next(1, 18);
                    break;

            }

            Menu();
        }

        void Menu()
        {
            Console.Clear();
            MostraInfo();
            Console.WriteLine("Deseja lutar contra qual monstro?");
            Console.WriteLine("1 - Orc");
            Console.WriteLine("2 - Troll");
            Console.WriteLine("3 - Minotauro");
            Console.WriteLine("4 - HellHound");
            Console.WriteLine("5 - Belzebu");
            Console.WriteLine("Digite 0 para sair do jogo");

            switch (Console.ReadLine().ToLower())
            {
                case "1": 
                case "orc": 
                    Batalhar(new Monstro("Orc", heroi.nivel * 2, heroi.nivel));
                    break;
                case "2": 
                case "troll": 
                    Batalhar(new Monstro("Troll", heroi.nivel * 5, heroi.nivel*2));
                    break;
                case "3": 
                case "minotauro": 
                    Batalhar(new Monstro("Minotauro", heroi.nivel * 10, heroi.nivel*4));
                    break;
                case "4":
                case "hellhound":
                    Batalhar(new Monstro("HellHound", heroi.nivel * 12, heroi.nivel * 5));
                    break;
                case "5":
                case "belzebu":
                    Batalhar(new Monstro("Belzebu", heroi.nivel * 15, heroi.nivel * 6));
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            if (heroi.vida <= 0)
            {
                Console.WriteLine("E morreu...");
                return;
            }
            else
            {
                Menu();
            }
        }

        void Batalhar(Monstro monstro)
        {
            Console.Clear();
            MostraInfo();
            Console.WriteLine($"MONSTRO ENCONTRADO: {monstro.nome} - Ataque: {monstro.ataque} - Vida: {monstro.vida} - XP: {monstro.xp}");
            Console.WriteLine("Deseja atacar (1) ou fugir (2)?");

            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "atacar":
                    monstro.vida -= heroi.ataque;
                    Console.WriteLine($"\n\nVocê causou {heroi.ataque} de dano no {monstro.nome}!");
                    Random talvez = new Random();
                    if (talvez.Next(1,11) % 2 == 0) {
                        heroi.vida -= monstro.ataque;
                        Console.WriteLine($"\n\nVocê recebeu {monstro.ataque} de dano do ataque do {monstro.nome}!");
                    }
                    else
                    {
                        Console.WriteLine("\n\nO MONSTRO ERROU O ATAQUE!");
                    }
                
                    if (heroi.vida <= 0)
                    {
                        Console.WriteLine("\n\nE morreu...");
                        return;
                    }
                    if (monstro.vida <= 0)
                    {
                        Console.WriteLine($"\n\nVocê derrotou o {monstro.nome} e ganhou {monstro.xp} de xp!");
                        heroi.ganhaXP(monstro.xp);
                        return;
                    }
                    break;
                case "2":
                case "fugir":
                    Console.WriteLine("\n\nVocê fugiu da batalha! Arregou...");
                    return;
            }

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Batalhar(monstro);
        }

        void MostraInfo()
        {
            Console.WriteLine($"Olá {heroi.nome}");
            Console.WriteLine($"Seu nível é: {heroi.nivel}");
            Console.WriteLine($"Sua experiência é: {heroi.xp}");
            Console.WriteLine($"Seu ataque base é: {heroi.ataqueBase}");
            Console.WriteLine($"Seu ataque é: {heroi.ataque}");
            Console.WriteLine($"Sua vida é: {heroi.vida}");
            Console.WriteLine("***");
        }
        
    }

}
