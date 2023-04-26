namespace RPG.Model
{
    class Personagem
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Classe { get; set; }
        public Dictionary<string, int> Atributos { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int Resistencia { get; set; }
        public int Mana { get; set; }
        public int Movimentacao { get; set; }

        public int CalcularPontosVida()
        {
            switch (this.Classe)
            {
                case "Gladiador":
                case "Guardião":
                case "Guerreiro":
                    return 10;
                case "Bárbaro":
                case "Caçador":
                case "Clérigo":
                    return 8;
                case "Bardo":
                case "Ladrão":
                case "Assassino":
                    return 6;
                case "Mago":
                case "Necromante":
                case "Druida":
                    return 4;
                default:
                    return 0;
            }
        }

        public int CalcularMovimento()
        {
            switch (this.Raca)
            {
                case "Humano":
                case "Elfo":
                case "Orc":
                case "Bestial":
                case "Kemono":
                case "Clérigo":
                case "Meio-Elfo":
                case "Meio-Orc":
                    return 9;
              
                case "Anão":
                    return 6;
               
                default:
                    return 0;
            }
        }

        public Personagem(string nome, string raca, string classe, Dictionary<string, int> atributos)
        {
            Nome = nome;
            Raca = raca;
            Classe = classe;
            Atributos = atributos;

            Vida = Atributos["constituicao"] + CalcularPontosVida();
            Ataque = Atributos["forca"] + Atributos["destreza"];
            Defesa = Atributos["constituicao"] + Atributos["agilidade"];
            Resistencia = Atributos["constituicao"] + Atributos["determinacao"] + Atributos["sabedoria"];
            Mana = 10;
            Movimentacao = CalcularMovimento();
        }
    }
}
