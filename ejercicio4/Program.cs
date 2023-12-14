using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
          //si la suma de los dos primeros es mayor al producto del segundo con el tercero.

          int n1, n2, n3;

            Console.WriteLine("Ingrese un nro:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro:");
            n3 = int.Parse(Console.ReadLine());

            if((n1 + n2) > (n2 * n3)){
                Console.WriteLine("La suma de los 2 primeros es mayor al producto ");
            }else{
            Console.WriteLine("La suma de los 2 primeros NO es mayor al producto ");
            }

            

          
        }
    }
}
