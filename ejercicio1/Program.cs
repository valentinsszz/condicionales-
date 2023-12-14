using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

                    //La resta si el primero es mayor que el segundo.
                    //La suma si son iguales.
                    //El producto si el primero es menor.

            int n1, n2, resultado;

            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Otro: ");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                resultado = n1 - n2;
                Console.WriteLine("El realizo la resta.");


            }else if(n1 == n2){
                    resultado = n1 + n2;
                Console.WriteLine("Se relizo la suma. ");
            } else{
                resultado = n1 * n2;
                Console.WriteLine("Se realizo la multiplicación. ");
            }
            
                Console.WriteLine("El resultado es " + resultado);

        }
    }
}
