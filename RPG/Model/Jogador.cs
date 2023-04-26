using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RPG.Model;

namespace RPG.Model
{
    class Jogador
    {
        public string Nome { get; set; }
        public List<Personagem> Personagens { get; set; }

        public Jogador(string nome)
        {
            Nome = nome;
            Personagens = new List<Personagem>();
        }

        public void AdicionarPersonagem(Personagem personagem)
        {
            Personagens.Add(personagem);
        }

        public void AlterarPersonagem(string nome, Personagem novoPersonagem)
        {
            int index = Personagens.FindIndex(p => p.Nome == nome);
            if (index != -1)
            {
                Personagens[index] = novoPersonagem;
            }
        }

        public void ExcluirPersonagem(string nome)
        {
            Personagens.RemoveAll(p => p.Nome == nome);
        }
    }
}
