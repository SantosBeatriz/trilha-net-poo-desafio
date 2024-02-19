namespace DesafioPOO.Models
{
    public class Samsung : Smartphone
    {
        public Samsung(string numero, string imei) : base(numero, "Samsung", imei, 64)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Samsung...");
        }
    }
}