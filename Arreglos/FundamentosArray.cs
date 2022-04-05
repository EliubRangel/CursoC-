using System;
namespace Arreglos
{
    public class FundamentosArray
    {
        public static int[] LlenarArray (int Size)
        {
            Console.WriteLine("****Llenar Array****");
            Console.WriteLine("Teclea "+Size+" numeros separados por un espacio" );
            int [ ] arr= new int [Size];
            // se puso size-1, por que la cajonera se recorre por que empieza en 0.
            string[] sArr = Console.ReadLine().Split(" ");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i]=int.Parse(sArr[i]);
            }
            Console.WriteLine("------------------------");
            return arr;
        }
        public static int SumarArray(int[] arr)
        {
            int suma=0;
            for (int i=0; i< arr.Length; i++ )
            {
                suma=suma+ arr[i];
            }
            return suma;
        }
        public static double PromedioArray(int[]arr)
        {
            double promedio=0;
            int suma2=0;
            for (int i=0; i<arr.Length; i++)
            {
                suma2=suma2+ arr[i];
            }
             promedio=suma2/arr.Length;
            return promedio;
        }
        public static void ArrayInverso(int[] arr)
        {
            for(int i=arr.Length-1; i>=0;i--)
            {
                Console.Write(arr[i]+" ");
                
            }
            Console.WriteLine();
        }
        public static int[] ReturnArrayInverso(int[] arr)
        {
            int[] inverse= new int[arr.Length];
            for(int i=arr.Length-1, j=0; i>=0; i--, j++)
            {
              inverse[j]=arr[i];  
            }
            return inverse;
            
        }
        public static void ImprimirArray(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------");
        }
        public static void ImprimirArrayTexto(string[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" | ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------");
        }
        public static int[] ArrayDoble(int[] arr1,int[] arr2)
        {
           int[] sumaArrays=new int[arr1.Length];
           for(int i=0; i<arr1.Length; i++)
           {
            sumaArrays[i]=arr1[i]+arr2[i];
           } 
           return sumaArrays;
        }
        public static int[] Arraytriple(int[]arr1,int[]arr2,int[]arr3)
        {
            Console.WriteLine("****Array triple*****");
            int[] triple= new int[arr1.Length];
            int mayor= 0;
            for(int i=0; i<arr1.Length;i++)
            {
                if (arr1[i]>arr2[i])
                {
                    mayor=arr1[i];
                }
                else 
                {
                    mayor= arr2[i];
                }
                if(arr3[i]>mayor)
                {
                    mayor=arr3[i];
                }
                triple[i]=mayor;
            }
            return triple;
        }
        public static void TablasMultiplicar(int[]arr1,int[]arr2)
        {
            int Multiplicar=0;
            for(int i=0; i<arr1.Length; i++)
            {
             for(int j=0; j<arr2.Length; j++)
             {
                 Multiplicar=arr1[i]*arr2[j];
                 Console.WriteLine(arr1[i]+"x"+arr2[j]+"="+Multiplicar);
             } 
             
                 
            }
             
        }

        /// arr significa la lista de numeros donde se realizara la busqueda.
        /// numero significa el valor que se desea buscar en el arreglo.
        ///regresa el valor enetro del cajon donde se encuentra el numero que se busco y se no esta regresara un -1
        public static int EncontrarNumero(int[]arr, int numero)
        {
            int pocision=-1;
            for(int i=0; i<arr.Length; i++)
            {
               if(numero == arr[i])
               {
                   pocision= i;

               }
               
            }
            return pocision;
        }
        public static string[] FiltrarTextoMayor10(string[] arr)
        {
            string[] arr1= new string[arr.Length];
            int cnt= 0;
            
             for(int i =0 ; i < arr.Length; i++)
            {
                //"abcde".Length = 5 caracteres
                
                if(arr[i].Length>10)
                {
                  arr1[cnt]=arr[i];
                  cnt++;

                }
     
            }
            return arr1;
               
        }
        public static string[] ConfirmarVocal(string[]arr)
        {
            int cnt=0;
            string [] arr1= new string[arr.Length];
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i].StartsWith("a")||arr[i].StartsWith("e")||arr[i].StartsWith("i")||arr[i].StartsWith("o")||arr[i].StartsWith("u"))
                {
                    arr1[cnt]=arr[i];
                    cnt++;
                }
                
             }
             return arr1;

            
        }
        public static string[] FiltrarLetras(string[]arr)
        {
            int cnt=0;
            string nombre= "eliub";
            string[] arr1=new string[arr.Length];
            for(int i=0; i<arr.Length; i++)
            {
                string text = arr[i];
                if(text[0]== text[text.Length-1] )
                {
                    arr1[cnt]=arr[i];
                    cnt++;
                
                }

             }
             return arr1;

        }
        public static string[] Multiplos(int[]arr)
        {
            string[] FizzBuzz= new string [arr.Length];

            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]%3==0)
                {
                    FizzBuzz[i]=FizzBuzz[i]+"fizz";

                }
                if(arr[i]%5==0)
                {
                    FizzBuzz[i]=FizzBuzz[i]+"Buzz";
                }
                
            }
            return FizzBuzz;
        }
        public static int PesoArray(int[]arr)
        {
            
           
            int suma=0;
            for(int i=0; i<arr.Length; i++)
            {
            int peso=0;
            if(arr[i]%3==0||arr[i]%6==0||arr[i]%9==0)
            {
                peso++;
            }
            if(arr[i]%2==0||arr[i]%4==0||arr[i]%7==0)
            {
                peso=peso+3;
            }    
            suma=suma+peso;

            }
            return suma;
        }
        

    }
}