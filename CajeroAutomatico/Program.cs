using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tarj = "", pass = "", numc = "";
            int cont = 0, op = 0;
            double saldo = 10000, mon = 0, a, dep = 0, desc = 0;

            while (tarj != "1234567890" || pass != "1234")

            {
                Console.Clear();
                Console.WriteLine("********************************************* ");

                Console.WriteLine("** CAJERO AUTOMATICO **");

                Console.WriteLine("*********************************************");


                Console.Write("\nIngrese su número de tarjeta : ");
                tarj = Console.ReadLine();
                Console.Write("Ingrese la clave de su tarjeta : ");
                pass = Console.ReadLine();
                if (tarj != "1234567890" || pass != "1234")
                {
                    cont++;
                    if (cont == 3)
                    {
                        Console.WriteLine("Clave errada más de 3 veces. Tu tarjeta está retenida.");

                        Console.ReadLine();
                        goto final;
                    }
                }
            }
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("*********************************************");

                    Console.WriteLine("** CAJERO AUTOMATICO **");

                    Console.WriteLine("*********************************************");

                    Console.WriteLine("\nSeleccione la operación que desea realizar :");

                    Console.WriteLine("1.- Transeferencia de saldo.");
                    Console.WriteLine("2.- Consulta de saldo.");
                    Console.WriteLine("3.- Depósito de efectivo.");
                    Console.WriteLine("4.- Salir.");
                    Console.WriteLine("----------------------------------------------- - ");

                    Console.Write("Ingrese su opción : ");
                    op = int.Parse(Console.ReadLine());
                    if (op < 1 || op > 4)
                    {
                        Console.WriteLine("Has ingresado una opción inválida.");
                        Console.ReadLine();
                        cont++;
                        if (cont == 3)
                        {
                            Console.WriteLine("Has errado más de 3 veces en escojer una opción.");
                            goto final;
                        }
                    }
                } while (op < 1 || op > 4);

                switch (op)
                {
                    case 1://transeferencia
                        Console.Clear();
                        Console.WriteLine("*********************************************");

                        Console.WriteLine("** CAJERO AUTOMATICO **");

                        Console.WriteLine("*********************************************");

                        Console.WriteLine("TRANSFERENCIA DE SALDO A TERCEROS.");
                        Console.Write("\nIngrese el número de cuenta : ");
                        numc = Console.ReadLine();
                        Console.Write("Ingrese el mónto a transeferir : ");
                        mon = int.Parse(Console.ReadLine());
                        a = (saldo - mon);
                        if (a > 0)
                        {
                            Console.WriteLine("Se transfirió con éxito el mónto de S/.{0} a la cuenta número { 1}", mon, numc);
                            saldo = (saldo - mon);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("** ADVERTENCIA : La operación no se puede realizar porque el mónto ingresado excede su saldo actual. * *");

                        }
                        Console.WriteLine("\n\n** Su saldo actual es S/ {0} **", saldo);
                        Console.WriteLine("\nPresione 1 para realizar otra operación.");
                        Console.WriteLine("Presione 2 para retirar su tarjeta.");
                        Console.WriteLine("---------------------------------");
                        Console.Write("Ingrese su opción : ");
                        op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            break;
                        }
                        if (op == 2)
                        {
                            goto fin;
                        }
                        break;
                    case 2://consulta

                        Console.Clear();
                        Console.WriteLine("*********************************************");

                        Console.WriteLine("** CAJERO AUTOMATICO **");

                        Console.WriteLine("*********************************************");

                        Console.WriteLine("CONSULTA DE SALDOS.");
                        Console.WriteLine("\nSu saldo actual es : S/{0}", saldo);
                        Console.WriteLine("-----------------------------------------------------------------");

                        Console.WriteLine("** Se le ha descontado el 0.01% de su saldo actual por esta operación * *");

                        saldo = (saldo - (saldo * 0.01));
                        desc = (desc += (saldo * 0.01));
                        Console.WriteLine("\n\n** Su saldo actual es S/ {0} **",
                        saldo);
                        Console.WriteLine("\nPresione 1 para realizar otra operación.");

                        Console.WriteLine("Presione 2 para retirar su tarjeta.");
                        Console.WriteLine("---------------------------------");
                        Console.Write("Ingrese su opción : ");
                        op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            break;
                        }
                        if (op == 2)
                        {
                            goto fin;
                        }
                        break;
                    case 3://depósito
                        Console.Clear();
                        Console.WriteLine("*********************************************");

                        Console.WriteLine("** CAJERO AUTOMATICO **");

                        Console.WriteLine("*********************************************");

                        Console.WriteLine("DEPOSITO DE EFECTIVO.");
                        Console.WriteLine("\n** No deberá superar los S/ 5000 por operación.");

                        Console.Write("\nIngrese la cantidad a depositar : ");
                        dep = int.Parse(Console.ReadLine());
                        if (dep > 0 && dep <= 5000)
                        {
                            Console.WriteLine("Se realizó con éxito el depósito de S/ {0} a su  cuenta.", dep);

                            saldo = (saldo + dep);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("** ADVERTENCIA : La operación no se puede realizar porque el mónto ingresado excede el máximo permitido por operación. * *");
                        }
                        Console.WriteLine("\n\n** Su saldo actual es S/ {0} **", saldo);
                        Console.WriteLine("\nPresione 1 para realizar otra operación.");
                        Console.WriteLine("Presione 2 para retirar su tarjeta.");
                        Console.WriteLine("---------------------------------");
                        Console.Write("Ingrese su opción : ");
                        op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            break;
                        }
                        if (op == 2)
                        {
                            goto fin;
                        }
                        break;
                    case 4://salir
                        goto final;
                        break;
                }
            } while (op != 4);
        fin:
        /*Console.Clear();
        Console.WriteLine("\n--------------------------------------");
        Console.WriteLine("\n\n** Su saldo es S/ {0} **", saldo);
        Console.WriteLine("Se le descontó por sus operaciones : S/{0}",des
       c);*/
        final:
            Console.WriteLine("\n******************************************"
           );
            Console.WriteLine("Retire su tarjeta.");
            Console.Write("Gracias por su visita. Hasta pronto.....");
            Console.ReadLine();
        }
    }
}
