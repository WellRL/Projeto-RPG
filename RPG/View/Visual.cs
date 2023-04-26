using RPG.Model;

namespace RPG.View
{
    class Visual
    {
        public static void MostrarPersonagem(Personagem personagem)
        {
            Console.WriteLine($"Nome: {personagem.Nome}");
            Console.WriteLine($"Raça: {personagem.Raca}");
            Console.WriteLine($"Classe: {personagem.Classe}");
            Console.WriteLine($"Atributos:");
            foreach (KeyValuePair<string, int> atributo in personagem.Atributos)
            {
                Console.WriteLine($"- {atributo.Key}: {atributo.Value}");
            }
            Console.WriteLine($"Vida: {personagem.Vida}");
            Console.WriteLine($"Ataque: {personagem.Ataque}");
            Console.WriteLine($"Defesa: {personagem.Defesa}");
            Console.WriteLine($"Resistência: {personagem.Resistencia}");
            Console.WriteLine($"Mana: {personagem.Mana}");
            Console.WriteLine($"Movimento: {personagem.Movimentacao}");
        }

        
    }
}