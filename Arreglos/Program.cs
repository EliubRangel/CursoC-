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
            int[] arr = new int[5];
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
                Console.WriteLine("Opcion 14 Suma del peso");
                Console.WriteLine("Opcion 15 Gastos semanales");
                Console.WriteLine("Opcion 16 Promedio de alumnos");
                Console.WriteLine("Opcion 17 puntos scrabble");
                Console.WriteLine("Opcion 18 clasificacion jugador");
                Console.WriteLine("Opcion 19 Crear e imprimir matriz");
                Console.WriteLine("Opcion 20 Convertir diagonal principal en 0");
                Console.WriteLine("Opcion 21 Convertir en 0 los elementos por encima de la diagonal principal");
                Console.WriteLine("Opcion 22 Convertir 0 diagonal inferior");
                Console.WriteLine("Opcion 23 Diagonal inversa");
                Console.WriteLine("Opcion 24 Esquinas convertidas en 0");
                Console.WriteLine("Opcion 25 Convertir 1 los alrededores");
                Console.WriteLine("Opcion 26 Hacer cruz de 1");
                Opcion = int.Parse(Console.ReadLine());
                if (Opcion == 1)
                {
                    arr = FundamentosArray.LlenarArray(5);
                }
                else if (Opcion == 2)
                {
                    int suma;
                    suma = FundamentosArray.SumarArray(arr);
                    Console.WriteLine("La suma de los valores del array es:" + suma);
                }
                else if (Opcion == 3)
                {
                    double promedio = FundamentosArray.PromedioArray(arr);
                    Console.WriteLine("El promedio del array es:" + promedio);
                }
                else if (Opcion == 4)
                {
                    FundamentosArray.ArrayInverso(arr);
                }
                else if (Opcion == 5)
                {
                    arr = FundamentosArray.ReturnArrayInverso(arr);
                    FundamentosArray.ImprimirArray(arr);
                }

                else if (Opcion == 6)
                {
                    int[] arr2 = new int[arr.Length];
                    arr2 = FundamentosArray.LlenarArray(arr.Length);
                    arr = FundamentosArray.ArrayDoble(arr, arr2);
                    FundamentosArray.ImprimirArray(arr);
                }
                else if (Opcion == 7)
                {
                    int[] a1 = FundamentosArray.LlenarArray(3);
                    int[] a2 = FundamentosArray.LlenarArray(3);
                    int[] a3 = FundamentosArray.LlenarArray(3);
                    int[] AMayor = FundamentosArray.Arraytriple(a1, a2, a3);
                    Console.WriteLine("Estos son los mayores de cada array");
                    FundamentosArray.ImprimirArray(AMayor);

                }
                else if (Opcion == 8)
                {
                    int[] arr1 = FundamentosArray.LlenarArray(4);
                    int[] arr2 = FundamentosArray.LlenarArray(4);
                    FundamentosArray.TablasMultiplicar(arr1, arr2);
                }
                else if (Opcion == 9)
                {
                    int[] arr2 = FundamentosArray.LlenarArray(4);
                    Console.WriteLine("Que numero desea buscar?");
                    int n = int.Parse(Console.ReadLine());
                    int buscar = FundamentosArray.EncontrarNumero(arr2, n);
                    if (buscar == -1)
                    {
                        Console.WriteLine("el numero se encuentra en la posicion:" + n);
                    }
                    else
                    {
                        Console.WriteLine("No se emcuemtra el numero en el arreglo.");
                    }

                }
                else if (Opcion == 10)
                {
                    string[] textos = new string[5];
                    textos[0] = "hola";
                    textos[1] = "me llamo samuel";
                    textos[2] = "arreglo";
                    textos[3] = "hoy es lunes";
                    textos[4] = "me llamo eliub";
                    string[] textoFiltrado = FundamentosArray.FiltrarTextoMayor10(textos);
                    FundamentosArray.ImprimirArrayTexto(textoFiltrado);


                }
                else if (Opcion == 11)
                {
                    string[] vocales = new string[5];
                    vocales[0] = "eliub";
                    vocales[1] = "hola";
                    vocales[2] = "iniciar";
                    vocales[3] = "samuel";
                    vocales[4] = "boyito";
                    string[] FiltrarVocales = FundamentosArray.ConfirmarVocal(vocales);
                    FundamentosArray.ImprimirArrayTexto(FiltrarVocales);
                }
                else if (Opcion == 12)
                {
                    string[] nombres = new string[5];
                    nombres[0] = "eliub";
                    nombres[1] = "samuel";
                    nombres[2] = "alejandra";
                    nombres[3] = "alexa";
                    nombres[4] = "omar";
                    string[] filtrarletras = FundamentosArray.FiltrarLetras(nombres);
                    FundamentosArray.ImprimirArrayTexto(filtrarletras);
                }
                else if (Opcion == 13)
                {
                    int[] numeros = new int[5];
                    numeros[0] = 12;
                    numeros[1] = 7;
                    numeros[2] = 15;
                    numeros[3] = 25;
                    numeros[4] = 8;
                    string[] multiplos = FundamentosArray.Multiplos(numeros);
                    FundamentosArray.ImprimirArrayTexto(multiplos);

                }
                else if (Opcion == 14)
                {
                    int[] numeros = new int[3];
                    numeros[0] = 3;
                    numeros[1] = 6;
                    numeros[2] = 9;
                    // numeros[3]=25;
                    // numeros[4]=8;
                    int PesoArray = FundamentosArray.PesoArray(numeros);
                    Console.WriteLine("La suma del peso del array es:" + PesoArray);
                }
                else if (Opcion == 15)
                {
                    double[] Gastos = new double[7];
                    Gastos[0] = 15;
                    Gastos[1] = 76;
                    Gastos[2] = 98;
                    Gastos[3] = 17.8;
                    Gastos[4] = 38;
                    Gastos[5] = 17;
                    Gastos[6] = 56;
                    string GastosSemanales = FundamentosArray.GastosSemanales(Gastos);
                    Console.WriteLine("El dia con mayor gasto es:" + GastosSemanales);

                }
                else if (Opcion == 16)
                {
                    int[] promedio = new int[6];
                    promedio[0] = 10;
                    promedio[1] = 10;
                    promedio[2] = 9;
                    promedio[3] = 5;
                    promedio[4] = 7;
                    promedio[5] = 8;
                    double PromedioAlumnos = FundamentosArray.PromedioAlumnos(promedio);
                    Console.WriteLine("El promedio es:" + PromedioAlumnos);

                }
                else if (Opcion == 17)
                {
                    string[] scrabble = new string[5];
                    scrabble[0] = "xoloitcuintle";
                    scrabble[1] = "herreria";
                    scrabble[2] = "ramirez";
                    scrabble[3] = "televisor";
                    scrabble[4] = "bocina";
                    int PuntajeScrabble = FundamentosArray.PuntajeScrabble(scrabble);
                    Console.WriteLine("el puntaje total es: " + PuntajeScrabble);

                }
                else if (Opcion == 18)
                {
                    int[] goles1 = new int[4];
                    goles1[0] = 5;
                    goles1[1] = 2;
                    goles1[2] = 1;
                    goles1[3] = 1;

                    int[] tarjetasRojas1 = new int[4];
                    tarjetasRojas1[0] = 2;
                    tarjetasRojas1[1] = 0;
                    tarjetasRojas1[2] = 1;
                    tarjetasRojas1[3] = 0;

                    string NivelJugador = FundamentosArray.NivelJugador(goles1, tarjetasRojas1);
                    Console.WriteLine("La clasificacion del jugador es: " + NivelJugador);

                }
                else if (Opcion == 19)
                {

                    Matrices objMatriz = new Matrices();

                    int[,] m = objMatriz.InicializarMatrizNumerica(3, 4);


                    objMatriz.ImprimirMatriz(m);

                    m = objMatriz.MultiplicarMatriz(m);
                    Console.WriteLine("----------------");
                    objMatriz.ImprimirMatriz(m);


                }
                else if (Opcion == 20)
                {
                    Matrices objMatriz = new Matrices();
                    int[,] m = new int[3, 3];
                    objMatriz.ConvertirCero(m);
                    objMatriz.ImprimirMatriz(m);
                }
                else if(Opcion==21)
                {
                    Matrices obj=new Matrices();
                    int[,]m=new int[5,5];
                    obj.Convertir0(m);
                    obj.ImprimirMatriz(m);
                }
                else if(Opcion==22)
                {
                    Matrices obj= new Matrices();
                    int[,]m=new int[6,6];
                    obj.InferiorDiagonal(m);
                    obj.ImprimirMatriz(m);
                }
                else if(Opcion==23)
                {
                    Matrices obj= new Matrices();
                    int[,]m=new int[5,5];
                    obj.DiagonalInversa(m);
                    obj.ImprimirMatriz(m);
                }
                else if(Opcion==24)
                {
                    Matrices onj= new Matrices();
                    int[,]m=new int[5,5];
                    onj.Esquinas(m);
                    onj.ImprimirMatriz(m);
                }
                else if(Opcion==25)
                {
                    Matrices obj= new Matrices();
                    int[,]m=new int[7,7];
                    obj.Alrrededores0(m);
                    obj.ImprimirMatriz(m);
                }
                else if(Opcion==26)
                {
                    Matrices obj=new Matrices();
                    int[,]m=new int[7,7];
                    obj.Cruz(m);
                    obj.ImprimirMatriz(m);
                }

            }
            while (Opcion != 0);


        }
    }
}
