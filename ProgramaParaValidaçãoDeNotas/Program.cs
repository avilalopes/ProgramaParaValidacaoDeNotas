using System; 

namespace DESAFIO {
class minhaClasse {

    static void Main(string[] args) { 

            int X = 0;
            double soma = 0;
            bool resposta;
            
            while (X < 2)
            {
                resposta = true;
                Console.WriteLine("Informe as notas: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                if (nota < 0 || nota > 10) 
                {
                    Console.WriteLine("nota invalida");
                } 
                else if (X == 0) 
                {
                    soma = nota;
                    X++;
                }
                else if (X == 1)
                {
                    double media = (soma + nota)/2;
                    Console.Write("media = ");
                    Console.WriteLine(media.ToString("N2"));                    
                    while (resposta == true)
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        double res = double.Parse(Console.ReadLine());
                        if (res ==  1) 
                        {
                        resposta = false;
                        X = 0;
                        } 
                        else if (res == 2) 
                        {
                        resposta = false;
                        X++; 
                        }                          
                    }
                } 
            }
        }
    }    
}               