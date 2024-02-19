namespace DesafioPOO.Models
{
    public class Lenovo : Smartphone
    {
        public Lenovo(string numero, string imei) : base(numero, "Lenovo", imei, 32)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Lenovo...");
        }
    }
}