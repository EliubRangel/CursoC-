using System;
namespace Arreglos
{
    public class FundamentosArray
    {
        public static int[] LlenarArray (int Size)
        {
            int [ ] arr= new int [Size];
            // se puso size-1, por que la cajonera se recorre por que empieza en 0.
            for (int i=0;i<=Size-1;i++)
            {
                arr[i]=int.Parse (Console.ReadLine());
            }
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
    }
}