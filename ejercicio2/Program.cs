using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Un importante negocio de desinfectante líquido realiza descuentos 
            //dependiendo de la cantidad de litros vendidos según la siguiente escala:

            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            //Hacer un programa que solicite el ingreso del importe final de la venta 
            //y la cantidad de litros vendidos y calcule 
            //y emita el importe con el descuento  aplicado..

            float i, lv; //iFinal; 

            Console.WriteLine("Ingrese los litros: ");
            lv = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el importe: ");
            i = float.Parse(Console.ReadLine());

            if(lv > 500)
                i *= 0.75F;
            else if(lv > 300)
                i *= 0.85F;
            else if(lv > 100)
                i *= 0.90F;
                Console.WriteLine("El precio final es de: " + i);
        }
    }
}
