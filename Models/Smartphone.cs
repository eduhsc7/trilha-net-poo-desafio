namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        public Smartphone(string numero, string modeloSmartphone, string imeiSmartphone, int memoriaSmartphone)
        {
            Numero = numero;
            modelo = modeloSmartphone;
            imei = imeiSmartphone;
            memoria = memoriaSmartphone;
        }

        private string modelo;

        private string imei;
        
        private int memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void MostrarCaracteristicas()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"IMEI: {imei}");
            Console.WriteLine($"Memória: {memoria}");
        }
         
       
        
    }
}