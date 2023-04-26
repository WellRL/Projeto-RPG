using Newtonsoft.Json;
using RPG.Model;
using RPG.View;
using System.Collections.Generic;

namespace RPG.Controller
{
    public class Program
    {
        public static void Main()
        {
            Jogador jogador = new Jogador("Jogador 1");

            // Carregar personagens do arquivo JSON
            string json = File.ReadAllText("Atributos.json");
            List<Personagem> personagens = JsonConvert.DeserializeObject<List<Personagem>>(json);

            foreach (Personagem personagem in personagens)
            {
                jogador.AdicionarPersonagem(personagem);
            }

            // Adicionar um novo personagem
            Personagem novoPersonagem = new Personagem("Personagem Novo", "Elfo", "Mago", new Dictionary<string, int>
        {
            {"agilidade", 3},
            {"carisma", 2},
            {"constituicao", 1},
            {"determinacao", 2},
            {"destreza", 3},
            {"forca", 1},
            {"sabedoria", 4},
            {"inteligencia", 4}
        });
            jogador.AdicionarPersonagem(novoPersonagem);

            // Mostrar informações dos personagens
            foreach (Personagem personagem in jogador.Personagens)
            {
                Visual.MostrarPersonagem(personagem);
                Console.WriteLine();
            }

            // Alterar um personagem
            Personagem personagemAlterado = jogador.Personagens[0];
            personagemAlterado.Classe = "Bárbaro";
            personagemAlterado.Atributos["forca"] = 3;
            jogador.AlterarPersonagem(personagemAlterado.Nome, personagemAlterado);

            // Mostrar informações do personagem alterado
            Console.WriteLine("Personagem alterado:");
            Visual.MostrarPersonagem(personagemAlterado);

            // Excluir um personagem
            jogador.ExcluirPersonagem("Personagem Novo");

            // Mostrar informações dos personagens novamente
            Console.WriteLine("Personagens depois de excluir:");
            foreach (Personagem personagem in jogador.Personagens)
            {
                Visual.MostrarPersonagem(personagem);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}