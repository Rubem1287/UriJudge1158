using System;

namespace Uri1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, soma, cont;
            soma = 0;
            cont = 0;
            n = int.Parse(Console.ReadLine());


            for (int c = 0; c < n; c++)
            {


                string[] vetor = Console.ReadLine().Split(' ');
                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);

                for (int j = x; cont < y; j++)
                {


                    if (j % 2 != 0)
                    {
                        soma = soma + j;
                        cont = cont + 1;
                    }


                }





                Console.WriteLine(soma);

            }
        }
    }
}
