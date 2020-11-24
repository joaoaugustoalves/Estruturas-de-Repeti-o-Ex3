using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
           string nome;
            int idade;
            float salario;
            string estadoCivil;
            
            do{
                Console.WriteLine("Digite seu Nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite sua Idade:");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu Salario:");
                salario = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu Estado Civil: s - Solteiro; c - Casado; v - Viuvo; d - Divorciada");
                estadoCivil = (Console.ReadLine());

                if(nome == ""){Console.WriteLine("Defina um nome valido"); nome = "";}

                if(idade < 0 || idade >150){ Console.WriteLine("Defina uma idade valido"); idade = 1;}

                if(salario == 0){ Console.WriteLine("Defina um salario valido"); salario = 0;}

                if(estadoCivil == "s" || estadoCivil == "c" || estadoCivil == "v" || estadoCivil == "d"){}
                
                else{
                    Console.WriteLine("Defina um estado civil valido");
                    estadoCivil = "";
                }
            }while(nome == "" || idade == 1 || salario == 0 || estadoCivil == "" );

            Console.WriteLine("Confirme seus dados");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salario: " + salario);
            Console.WriteLine("Estado Civil: " + estadoCivil);

            Console.WriteLine("Validação concluida");
        }
    }
}
