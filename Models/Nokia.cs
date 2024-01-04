namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            
            Console.WriteLine($"{nomeApp} instalado com sucesso.");
        }

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

       
    }
}