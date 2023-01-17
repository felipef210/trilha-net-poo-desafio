namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modeloCelular, string imeiCelular, int memoriaCelular) : base(numero, modeloCelular, imeiCelular, memoriaCelular)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone");
        }
    }
}