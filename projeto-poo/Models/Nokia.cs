namespace DesafioPOO.Models 
{
    public class Nokia : Smartphone // Define a classe Nokia, que herda de Smartphone.
    {
        // Construtor do Nokia, que chama o construtor da classe base (Smartphone).
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescreve o método 'InstalarAplicativo' da classe base.
        public override void InstalarAplicativo(string nomeApp)
        {
            // Exibe uma mensagem informando qual aplicativo está sendo instalado.
            Console.WriteLine("Aplicativo instalado: {0}", nomeApp);
        }
    }
}