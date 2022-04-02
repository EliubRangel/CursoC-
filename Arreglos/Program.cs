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
                Console.WriteLine("Opcion 9 Buscar valor en array");
                Console.WriteLine("Opcion 10 texto mayor de 10");
                Console.WriteLine("Opcion 11 Confirmacion de inicial con vocal");
                Console.WriteLine("Opcion 12 filtrado por iniciales");
                Console.WriteLine("Opcion 13 Multiplos del 3 y 5");
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
                else if (Opcion==9)
                {
                    int[]arr2=FundamentosArray.LlenarArray(4);
                    Console.WriteLine("Que numero desea buscar?");
                    int n= int.Parse(Console.ReadLine());
                    int buscar= FundamentosArray.EncontrarNumero(arr2, n);
                    if(buscar==-1)
                    {
                        Console.WriteLine("el numero se encuentra en la posicion:"+ n );
                    }
                    else
                    {
                        Console.WriteLine("No se emcuemtra el numero en el arreglo.");
                    }
                    
                }
                else if (Opcion==10)
                {
                    string[] textos= new string [5];
                    textos[0]= "hola";
                    textos[1]="me llamo samuel";
                    textos[2]="arreglo";
                    textos[3]="hoy es lunes";
                    textos[4]="me llamo eliub";
                    string[] textoFiltrado=  FundamentosArray.FiltrarTextoMayor10(textos);
                    FundamentosArray.ImprimirArrayTexto(textoFiltrado);
                    

                }
                else if (Opcion==11)
                {
                    string[] vocales= new string[5];
                    vocales[0]="eliub";
                    vocales[1]="hola";
                    vocales[2]="iniciar";
                    vocales[3]="samuel";
                    vocales[4]="boyito";
                    string[] FiltrarVocales= FundamentosArray.ConfirmarVocal(vocales);
                    FundamentosArray.ImprimirArrayTexto(FiltrarVocales);
                }
                else if (Opcion==12)
                {
                    string[] nombres= new string[5];
                    nombres[0]="eliub";
                    nombres[1]="samuel";
                    nombres[2]="alejandra";
                    nombres[3]="alexa";
                    nombres[4]="omar";
                    string[] filtrarletras= FundamentosArray.FiltrarLetras(nombres);
                    FundamentosArray.ImprimirArrayTexto(filtrarletras);
                }
                else if(Opcion==13)
                {
                    int[] numeros= new int[5];
                    numeros[0]= 12;
                    numeros[1]=7;
                    numeros[2]=15;
                    numeros[3]=25;
                    numeros[4]=8;
                    string [] multiplos=FundamentosArray.Multiplos(numeros);
                    FundamentosArray.ImprimirArrayTexto(multiplos);
                    
                }

            
            }
            while(Opcion !=0);

            
        }
    }
}
