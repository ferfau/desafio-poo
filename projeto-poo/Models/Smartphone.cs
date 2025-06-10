namespace DesafioPOO.Models 
{
    public abstract class Smartphone // Define a classe abstrata Smartphone.
                                     // Classes abstratas não podem ser instanciadas diretamente,
                                     // mas servem como base para outras classes (como Iphone e Nokia).
    {
        public string Numero { get; set; } // Propriedade pública para o número do telefone.

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; } // Propriedade privada para o modelo do smartphone.
        private string IMEI { get; set; }   // Propriedade privada para o IMEI do smartphone.

        private int Memoria { get; set; }   // Propriedade privada para a memória do smartphone.


        // Construtor da classe Smartphone.
        // Ele inicializa as propriedades do smartphone com os valores passados.
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;   // Atribui o número.
            Modelo = modelo;   // Atribui o modelo.
            IMEI = imei;       // Atribui o IMEI.
            Memoria = memoria; // Atribui a memória.
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar() // Método para simular uma ligação.
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao() // Método para simular o recebimento de uma ligação.
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp); // Método abstrato para instalar aplicativo.
                                                                 // Classes que herdam de Smartphone DEVEM implementar este método.
    }
}