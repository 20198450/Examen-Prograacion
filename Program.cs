﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola_Tabla_de_amortizacion
{
    class Program
    {
        static void Main(string[] args)
        {

            float pago, Interes_pagado, Capital_pagado, Monto_del_prestamo, tasa_interes_anual, tasa_interes_mensual;
            int fila, Plazo, i;

            Console.Write("INTRODUCE EL MONTO DE TU PRESTAMO: ");
            float.TryParse(Console.ReadLine(), out Monto_del_prestamo);
            Console.Write("INTRODUCE LA TASA DE INTERES ANUAL: ");
            float.TryParse(Console.ReadLine(), out tasa_interes_anual);
            Console.Write("INTRODUCE EL PLAZO EN MESE: ");
            int.TryParse(Console.ReadLine(), out Plazo);

            //Calculo del interes mensual
            tasa_interes_mensual = (tasa_interes_anual / 100) / 12;


            //Calculo de la cuota mensual
            pago = tasa_interes_mensual + 1;
            pago = (float)Math.Pow(pago, Plazo);
            pago = pago - 1;
            pago = tasa_interes_mensual / pago;
            pago = tasa_interes_mensual + pago;
            pago = Monto_del_prestamo * pago;




            Console.WriteLine();
            fila = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" NUMERO DE PAGO \t");
            Console.Write("PAGO \t\t");
            Console.Write("INTERES PAGADO \t\t");
            Console.Write("CAPITAL PAGADO \t\t");
            Console.Write("MONTO DEL PRESTAMO \t");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", Monto_del_prestamo);


            for (i = 1; i <= Plazo; i++)
            {


                Console.Write("\t{0}\t\t", fila);


                Console.Write("{0}\t", pago);


                Interes_pagado = tasa_interes_mensual * Monto_del_prestamo;
                Console.Write("{0}\t\t", Interes_pagado);


                Capital_pagado = pago - Interes_pagado;
                Console.Write("\t{0}\t", Capital_pagado);


                Monto_del_prestamo = Monto_del_prestamo - Capital_pagado;
                Console.Write("\t{0}\t", Monto_del_prestamo);

                fila = fila + 1;
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}