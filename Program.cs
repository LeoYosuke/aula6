using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6leo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int number;

             Console.WriteLine("digite um numero de 1 a 10!");

             number = Int32.Parse(Console.ReadLine());
             if ((number <= 10) && (number >= 1))
             {

                 Console.WriteLine("-FIM DO PROGRAMA");



             }
             else 
             {

                 Console.WriteLine("ops.. numero invalido (BURRO)");
                 Main(null);
                 return;


             }





             Console.ReadKey();*/

            string usuario = "yosuke";
            string senha = "leoleoleo123";
            string number, usuario2, senha2, usuario3, senha3;


            Console.WriteLine("Bem-vindo ao Yosuke-bank");
            Console.WriteLine("OPÇÕES");
            Console.WriteLine("1 - CADASTRAR\n2 - LOGIN");
            Console.WriteLine("");
            Console.WriteLine("DIGITE UMA OPÇÃO");
            number = (Console.ReadLine());

            if (number == "1")
            {
                Console.WriteLine("DIGITE O NOME DO NOVO USUARIO:");
                usuario2 = (Console.ReadLine());
                Console.WriteLine("DIGITE SUA NOVA SENHA:");
                senha2 = (Console.ReadLine());
                Console.WriteLine("USUARIO CADASTRADO COM SUCESSO!");
                Console.WriteLine("-- login de usuario:");
                Console.WriteLine("DIGITE SEU LOGIN:");
                usuario3 = (Console.ReadLine());
                if (usuario3 == usuario2) 
                {
                    Console.WriteLine("DIGITE SUA SENHA:");
                    senha3 = (Console.ReadLine());
                    if (senha3 == senha2) 
                    {
                        Console.WriteLine("LOGIN EFETUADO");
                        Console.ReadKey();
                        return;

                    
                    }
                    else 
                    {
                        Console.WriteLine("SENHA INVALIDA...");
                        return;
                    
                    }

                }
                else 
                {
                    Console.WriteLine("login invalida");
                    Console.ReadKey();
                    return;
                
                }
                
                



            }
            
            
                Console.WriteLine("DIGITE SEU LOGIN:");
                usuario = (Console.ReadLine());
                if (usuario == "yosuke") 
                {
                    Console.WriteLine("DIGITE SUA SENHA");
                    senha = (Console.ReadLine());
                    if(senha == "leoleoleo123") 
                    {
                        Console.WriteLine("LOGIN EFETUADO");

                    
                    }
                    else 
                    {
                        Console.WriteLine("SENHA INVALIDA...");

                    
                    }
                
                
                }
                else 
                {
                    Console.WriteLine("LOGIN INVALIDO!");

                
                
                }




            
                    
                     
            
            
            
            
                    
                    
                

            
            
            
            
           
            









            Console.ReadKey();
            

           

        }
    }
}
