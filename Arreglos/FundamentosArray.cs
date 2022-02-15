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
    }
}