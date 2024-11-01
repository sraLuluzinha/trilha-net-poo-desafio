namespace DesafioPOO.Models
{
public class Iphone : Smartphone //implementado aqui !
    {
       
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Implementado aqui!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone...");
        
        }
    }
}