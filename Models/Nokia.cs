namespace DesafioPOO.Models
{
    //Herdando a classe "Smartphone"
    public class Nokia: Smartphone
    {
        //método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }

        public override void InstalarAplicativo(string nomeApp)
        {

            Console.WriteLine($"Instalando {nomeApp}...");
            Console.WriteLine($"{nomeApp} foi instalado com sucesso!");
        }
    }

}
