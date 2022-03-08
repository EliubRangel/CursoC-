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
                Console.WriteLine("Opcion 4 Array inverso");
                Console.WriteLine("Opcion 5 Imprimir array inverso");
                Console.WriteLine("Opcion 6 Array doble");
                Console.WriteLine("Opcion 7 mayor de 3 arrays");
                Console.WriteLine("Opcion 8 Multiplicacion de arrays");
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
                else if(Opcion==4)
                {
                    FundamentosArray.ArrayInverso(arr);
                }
                else if (Opcion==5)
                {
                    arr= FundamentosArray.ReturnArrayInverso(arr);
                    FundamentosArray.ImprimirArray(arr);
                }

                else if(Opcion==6)
                {
                    int[]arr2= new int[arr.Length];
                    arr2=FundamentosArray.LlenarArray(arr.Length);
                 arr=FundamentosArray.ArrayDoble(arr,arr2);
                 FundamentosArray.ImprimirArray(arr);
                }
                else if(Opcion==7)
                {
                    int[] a1= FundamentosArray.LlenarArray(3);
                    int[] a2=FundamentosArray.LlenarArray(3);
                    int[] a3=FundamentosArray.LlenarArray(3);
                    int[] AMayor=FundamentosArray.Arraytriple(a1,a2,a3);
                    Console.WriteLine("Estos son los mayores de cada array");
                    FundamentosArray.ImprimirArray(AMayor);

                }
                else if (Opcion==8)
                {
                    int[] arr1=FundamentosArray.LlenarArray(4);
                    int[] arr2= FundamentosArray.LlenarArray(4);
                    FundamentosArray.TablasMultiplicar(arr1,arr2);
                }

            
            }
            while(Opcion !=0);

            
        }
    }
}
