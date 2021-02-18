using System;

namespace Examen_Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string carnet;
            int n, tipcue; //Tipcue=tipo de cuenta
            double ccre = 99999.99;
            do
            {
                Console.WriteLine("Digite Su PIN");
                carnet = Console.ReadLine();
                if (carnet == "1234")
                {
                    double cueco = 1000, cueaho = 500, saltot = cueco + cueaho;
                    Console.WriteLine("Bienvenido Sr. Manuel Medina ");
                    Console.WriteLine("Digite la operacion a realizar");
                    Console.WriteLine("1 retiro, 2 consulta");
                    int res = int.Parse(Console.ReadLine());
                    n = res;
                    if (n == 2)
                    {
                        Console.WriteLine("su saldo total es {0} ", saltot);
                        Console.WriteLine("su saldo de cuenta corriente es: {0} ", cueco);
                        Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cueaho);
                        Console.WriteLine("su saldo de tarjeta de credito es: {0} ", ccre);
                    }
                    if (n == 1)
                    {
                        Console.WriteLine("1 Cuenta corriente 2 Cuenta de ahorros 3 Cuenta de credito");
                        tipcue = int.Parse(Console.ReadLine());
                        if (tipcue == 1)
                        {
                            while (res == 1)
                            {
                                Console.WriteLine("Digite el monto a retirar");
                                double ret = double.Parse(Console.ReadLine());
                                if (ret <= saltot)
                                {
                                    saltot = saltot - ret;
                                    cueco = cueco - ret;
                                    Console.WriteLine("su saldo es: {0} ", saltot);
                                }
                                else
                                {
                                    Console.WriteLine("su saldo total disponible es inferior a {0}", ret);
                                    Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", saltot);
                                }
                                Console.WriteLine("Desea realizar otro retiro");
                                Console.WriteLine("1 = si 2 = no ");
                                res = int.Parse(Console.ReadLine());
                            }
                        }
                        if (tipcue == 2)
                        {
                            while (res == 1)
                            {
                                Console.WriteLine("Digite el monto a retirar");
                                double ret = double.Parse(Console.ReadLine());
                                if (ret <= saltot)
                                {
                                    saltot = saltot - ret;
                                    cueaho = cueaho - ret;
                                    Console.WriteLine("su saldo de cuenta corriente es: {0} ", cueco);
                                    Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cueaho);
                                    Console.WriteLine("su saldo de tarjeta de credito es: {0} ", ccre);
                                }
                                else
                                {
                                    Console.WriteLine("su saldo total disponible es {0}", saltot);
                                    Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", ret);
                                }
                                Console.WriteLine("Desea realizar otro retiro");
                                Console.WriteLine("1 = si 2 = no ");
                                res = int.Parse(Console.ReadLine());
                            }
                        }
                        if (tipcue == 3)
                        {
                            Console.WriteLine("lo sentimos esta cuenta es solo para pagos no para retiros");
                        }
                    }
                }
                else
                {
                    if (carnet == "2328")
                    {
                        double cueco = 10.99, cueaho = 800, saltot = cueco + cueaho;
                        Console.WriteLine("Bienvenida Sra. Juana Perez ");
                        Console.WriteLine("Digite la operacion a realizar");
                        Console.WriteLine("1 retiro, 2 consulta");
                        int res = int.Parse(Console.ReadLine());
                        n = res;
                        if (n == 2)
                        {
                            Console.WriteLine("su saldo total disponible es {0} ", saltot);
                            Console.WriteLine("su saldo de cuenta corriente es: {0} ", cueco);
                            Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cueaho);
                            Console.WriteLine("su saldo de tarjeta de credito es: {0} ", ccre);
                        }
                        if (n == 1)
                        {
                            Console.WriteLine("1 cuenta corriente 2 cuenta de ahorros");
                            tipcue = int.Parse(Console.ReadLine());
                            if (tipcue == 1)
                            {
                                while (res == 1)
                                {
                                    Console.WriteLine("Digite el monto a retirar");
                                    double ret = double.Parse(Console.ReadLine());
                                    if (ret <= saltot)
                                    {
                                        saltot = saltot - ret;
                                        cueco = cueco - ret;
                                        Console.WriteLine("su saldo total disponible es: {0} ", saltot);
                                    }
                                    else
                                    {
                                        Console.WriteLine("su saldo total disponible es inferior a {0}", ret);
                                        Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", saltot);
                                    }
                                    Console.WriteLine("Desea realizar otro retiro");
                                    Console.WriteLine("1 = si 2 = no ");
                                    res = int.Parse(Console.ReadLine());
                                }
                            }
                            if (tipcue == 2)
                            {
                                while (res == 1)
                                {
                                    Console.WriteLine("Digite el monto a retirar");
                                    double ret = double.Parse(Console.ReadLine());
                                    if (ret <= saltot)
                                    {
                                        saltot = saltot - ret;
                                        cueaho = cueaho - ret;
                                        Console.WriteLine("su saldo total disponible es: {0} ", saltot);
                                    }
                                    else
                                    {
                                        Console.WriteLine("su saldo disponible es {0}", saltot);
                                        Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", ret);
                                    }
                                    Console.WriteLine("Desea realizar otro retiro");
                                    Console.WriteLine("1 = si 2 = no ");
                                    res = int.Parse(Console.ReadLine());
                                }
                            }
                            if (tipcue == 3)
                            {
                                Console.WriteLine("lo sentimos esta cuenta es solo para pagos no para retiros");
                            }
                        }
                    }
                    else
                    {
                        if (carnet == "0307")
                        {
                            double cueco = 984.99, cueaho = 100, saltot = cueco + cueaho;
                            Console.WriteLine("Bien venido sr. Jheyson Martinez");
                            Console.WriteLine("Digite la operacion a realizar");
                            Console.WriteLine("1 retiro, 2 consulta");
                            int res = int.Parse(Console.ReadLine());
                            n = res;
                            if (n == 2)
                            {
                                Console.WriteLine("su saldo total disponibe es: {0} ", saltot);
                                Console.WriteLine("su saldo de cuenta corriente es: {0} ", cueco);
                                Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cueaho);
                                Console.WriteLine("su saldo de tarjeta de credito es: {0} ", ccre);
                            }
                            if (n == 1)
                            {
                                Console.WriteLine("1 cuenta corriente 2 cuenta de ahorros");
                                tipcue = int.Parse(Console.ReadLine());
                                if (tipcue == 1)
                                {
                                    while (res == 1)
                                    {
                                        Console.WriteLine("Digite el monto a retirar");
                                        double ret = double.Parse(Console.ReadLine());
                                        if (ret <= saltot)
                                        {
                                            saltot = saltot - ret;
                                            cueco = cueco - ret;
                                            Console.WriteLine("su saldo total disponible es: {0} ", saltot);
                                        }
                                        else
                                        {
                                            Console.WriteLine("su saldo disponible es inferior a {0}", ret);
                                            Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", saltot);
                                        }
                                        Console.WriteLine("Desea realizar otro retiro");
                                        Console.WriteLine("1 = si 2 = no ");
                                        res = int.Parse(Console.ReadLine());
                                    }
                                }
                                if (tipcue == 2)
                                {
                                    while (res == 1)
                                    {
                                        Console.WriteLine("Digite el monto a retirar");
                                        double ret = double.Parse(Console.ReadLine());
                                        if (ret <= saltot)
                                        {
                                            saltot = saltot - ret;
                                            cueaho = cueaho - ret;
                                            Console.WriteLine("su saldo total disponible es: {0} ", saltot);
                                        }
                                        else
                                        {
                                            Console.WriteLine("su saldo total disponible es {0}", saltot);
                                            Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", ret);
                                        }
                                        Console.WriteLine("Desea realizar otro retiro");
                                        Console.WriteLine("1 = si 2 = no ");
                                        res = int.Parse(Console.ReadLine());
                                    }
                                }
                                if (tipcue == 3)
                                {
                                    Console.WriteLine("lo sentimos esta cuenta es solo para pagos no para retiros");
                                }
                            }
                        }
                        else
                        {
                            if (carnet == "2530")
                            {
                                double cueco = 15.99, cueaho = 3000, saltot = cueco + cueaho;
                                Console.WriteLine("Bienvenido Sr. Pedro Grullon ");
                                Console.WriteLine("Digite la operacion a realizar");
                                Console.WriteLine("1 retiro, 2 consulta");
                                int res = int.Parse(Console.ReadLine());
                                n = res;
                                if (n == 2)
                                {
                                    Console.WriteLine("su saldo disponible es: {0} ", saltot);
                                    Console.WriteLine("su saldo de cuenta corriente es: {0} ", cueco);
                                    Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cueaho);
                                    Console.WriteLine("su saldo de tarjeta de credito es: {0} ", ccre);
                                }
                                if (n == 1)
                                {
                                    Console.WriteLine("1 cuenta corriente 2 cuenta de ahorros");
                                    tipcue = int.Parse(Console.ReadLine());
                                    if (tipcue == 1)
                                    {
                                        while (res == 1)
                                        {
                                            Console.WriteLine("Digite el monto a retirar");
                                            double ret = double.Parse(Console.ReadLine());
                                            if (ret <= saltot)
                                            {
                                                saltot = saltot - ret;
                                                cueco = cueco - ret;
                                                Console.WriteLine("su saldo total disponible es: {0} ", saltot);
                                            }
                                            else
                                            {
                                                Console.WriteLine("su saldo es disponible es inferior a {0}", ret);
                                                Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", saltot);
                                            }
                                            Console.WriteLine("Desea realizar otro retiro");
                                            Console.WriteLine("1 = si 2 = no ");
                                            res = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    if (tipcue == 2)
                                    {
                                        while (res == 1)
                                        {
                                            Console.WriteLine("Digite el monto a retirar");
                                            double ret = double.Parse(Console.ReadLine());
                                            if (ret <= saltot)
                                            {
                                                saltot = saltot - ret;
                                                cueaho = cueaho - ret;
                                                Console.WriteLine("su saldo total disponible es: {0} ", saltot);
                                            }
                                            else
                                            {
                                                Console.WriteLine("su saldo disponible es {0}", saltot);
                                                Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", ret);
                                            }
                                            Console.WriteLine("Desea realizar otro retiro");
                                            Console.WriteLine("1 = si 2 = no ");
                                            res = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    if (tipcue == 3)
                                    {
                                        Console.WriteLine("lo sentimos esta cuenta es solo para pagos no para retiros");
                                    }
                                }
                            }
                            else
                            {
                                if (carnet == "4705")
                                {
                                    double cueco = 984.99, cueaho = 100, saltot = cueco + cueaho;
                                    Console.WriteLine("Bienvenido Sr. Pedro Jaquez");
                                    Console.WriteLine("Digite la operacion a realizar");
                                    Console.WriteLine("1 retiro, 2 consulta");
                                    int res = int.Parse(Console.ReadLine());
                                    n = res;
                                    if (n == 2)
                                    {
                                        Console.WriteLine("su saldo disponible es: {0} ", saltot);
                                        Console.WriteLine("su saldo de cuenta corriente es: {0} ", cueco);
                                        Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cueaho);
                                        Console.WriteLine("su saldo de tarjeta de credito es: {0} ", ccre);
                                    }
                                    if (n == 1)
                                    {
                                        Console.WriteLine("1 cuenta corriente 2 cuenta de ahorros");
                                        tipcue = int.Parse(Console.ReadLine());
                                        if (tipcue == 1)
                                        {
                                            while (res == 1)
                                            {
                                                Console.WriteLine("Digite el monto a retirar");
                                                double ret = double.Parse(Console.ReadLine());
                                                if (ret <= saltot)
                                                {
                                                    saltot = saltot - ret;
                                                    cueco = cueco - ret;
                                                    Console.WriteLine("su saldo total disponible es: {0} ", saltot);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("su saldo dosponible es inferior a {0}", ret);
                                                    Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", saltot);
                                                }
                                                Console.WriteLine("Desea realizar otro retiro");
                                                Console.WriteLine("1 = si 2 = no ");
                                                res = int.Parse(Console.ReadLine());
                                            }
                                        }
                                        if (tipcue == 2)
                                        {
                                            while (res == 1)
                                            {
                                                Console.WriteLine("Digite el monto a retirar");
                                                double ret = double.Parse(Console.ReadLine());
                                                if (ret <= saltot)
                                                {
                                                    saltot = saltot - ret;
                                                    cueaho = cueaho - ret;
                                                    Console.WriteLine("su saldo total disponible es: {0} ", saltot);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("su saldo disponible es {0}", saltot);
                                                    Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", ret);
                                                }
                                                Console.WriteLine("Desea realizar otro retiro");
                                                Console.WriteLine("1 = si 2 = no ");
                                                res = int.Parse(Console.ReadLine());
                                            }
                                        }
                                        if (tipcue == 3)
                                        {
                                            Console.WriteLine("lo sentimos esta cuenta es solo para pagos no para retiros");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Lo sentimos pin erroneo ");
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Desea realizar otra transaccion s/n");
                carnet = Console.ReadLine();
            }
            while (carnet == "s");
            Console.WriteLine("Gracias por preferirnos");
            Console.ReadLine();
        }
    }
}
 