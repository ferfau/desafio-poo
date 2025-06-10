using DesafioPOO.Models; 


namespace Desafio
{
    public class Program // Define a classe principal do programa.
    {
        // Método principal que é o ponto de entrada da aplicação.
        public static void Main(string[] args)
        {
            // --- Instanciando e usando um iPhone ---
            // Cria um novo objeto (instância) da classe Iphone, passando os dados no construtor.
            Iphone iphone = new Iphone("21999999999", "Iphone 15", "123456789012345", 256);

            // Chama o método InstalarAplicativo no objeto 'iphone'.
            iphone.InstalarAplicativo("Github");
            // Chama o método Ligar no objeto 'iphone'.
            iphone.Ligar();

            // --- Instanciando e usando um Nokia ---
            // Cria um novo objeto (instância) da classe Nokia, passando os dados no construtor.
            Nokia nokia = new Nokia("21777777777", "Nokia C01", "987654321098765", 32);

            // Chama o método InstalarAplicativo no objeto 'nokia'.
            nokia.InstalarAplicativo("Snake Game");
            // Chama o método Ligar no objeto 'nokia'.
            nokia.Ligar();
        }
    }
}