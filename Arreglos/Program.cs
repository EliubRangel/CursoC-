using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para ejecutar el programa usar el comando 
            // dotnet run 
            // para limpiar consola clear
            Console.WriteLine("Binvenido a FundamentosArray");
            int Opcion;
            int[] arr= new int [5];
            do
            {
                Console.WriteLine("Que deseas hacer");
                Console.WriteLine("Opcion 0 salir");
                Console.WriteLine("Opcion 1 Llenar array");
                Console.WriteLine("Opcion 2 sumar con array");
                Console.WriteLine("Opcion 3 Promedio con array");
                Opcion= int.Parse(Console.ReadLine());
                if (Opcion==1)
                {
                    arr = FundamentosArray.LlenarArray(5);
                }
                else if (Opcion==2)
                {
                    int suma;
                     suma= FundamentosArray.SumarArray(arr);
                     Console.WriteLine("La suma de los valores del array es:"+ suma);
                }
                else if (Opcion==3)
                {   
                    double promedio= FundamentosArray.PromedioArray(arr);
                    Console.WriteLine("El promedio del array es:"+promedio);
                }
            
            }
            while(Opcion !=0);

            
        }
    }
}
