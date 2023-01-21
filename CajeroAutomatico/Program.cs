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
            String numeroTarjeta="",cuentaDestino, cuentaOrigen;
            int clave=0,contador=1, op=0, opcionRetiro;
            double saldoTotal=1000, montoTransferir, montoRetirar, otroMontoRetiro,montoOrigen;

            while (numeroTarjeta != "123456789" || clave!=1234)
            {
                Console.Clear();
                Console.WriteLine("Ingresar su numero de Tarjeta: ");
                numeroTarjeta = Console.ReadLine();

                Console.WriteLine("Ingresar su clave: ");
                clave = Convert.ToInt32(Console.ReadLine());

                if(numeroTarjeta!="1234567890" || clave != 123)
                {
                   
                    
                    
                    if (contador == 3)
                    {
                        Console.WriteLine("Lo sentimos excedió número de veces :( ");
                        Console.ReadLine();
                        goto final;
                    }
                    contador++;
                }
                else
                {
                    Console.WriteLine("Bienvenido a su cuenta bancaria\n");
                    do
                    {
                        operaciones:
                        Console.WriteLine("OPERACIONES A REALIZAR ");
                        Console.WriteLine("******************************************\n");
                        Console.WriteLine("1: Consultar Saldo ");
                        Console.WriteLine("2: Transferencia a otra Cuenta ");
                        Console.WriteLine("3: Retirar Dinero ");
                        Console.WriteLine("4: Recargar Saldo ");
                        Console.WriteLine("5: Salir\n ");
                        Console.WriteLine("\n******************************************\n");

                        Console.WriteLine("Qué operación desea realizar? ");
                        op = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");

                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("***Consulta de Saldo***");
                                Console.WriteLine("Su Saldo Total es: "+saldoTotal +" Soles\n");
                            break; goto operaciones;

                            case 2:
                                Console.WriteLine("***Transferencia a otra Cuenta***\n");
                                Console.WriteLine("Ingresar cuenta de destino: ");
                                cuentaDestino = Console.ReadLine();
                                Console.WriteLine("Ingresar el Monto a Transferir: ");
                                montoTransferir = double.Parse(Console.ReadLine());
                                
                                if (montoTransferir >= saldoTotal)
                                {
                                    Console.WriteLine("Saldo Total: " + saldoTotal);
                                    Console.WriteLine("Monto a transferir es: " + montoTransferir);
                                    Console.WriteLine("El saldo Total es menor que el monto a Destinar");
                                    Console.WriteLine("Ingresar monto menor al saldo Total\n ");
                                    goto operaciones;
                                }
                                else
                                {
                                    saldoTotal = saldoTotal - montoTransferir;
                                    Console.WriteLine("Saldo Total: " + saldoTotal);
                                    Console.WriteLine("Monto transferido es: "+montoTransferir);
                                    Console.WriteLine("¡Transferencia Exitosa!");                                 
                                }
                            break; goto operaciones;

                            case 3:
                                Console.WriteLine("***Retiro de Dinero***\n");
                                Console.WriteLine("===Opciones de Retiro===");
                                Console.WriteLine("1:s/.20");
                                Console.WriteLine("2:s/:50");
                                Console.WriteLine("3:s/.100");
                                Console.WriteLine("4:s/:200");
                                Console.WriteLine("5:s/ otro monto");
                                
                                Console.WriteLine("Ingresar la opción de Retiro:");
                                opcionRetiro =int.Parse(Console.ReadLine());                            
                                switch (opcionRetiro)
                                {
                                    case 1:
                                        if (20 >= saldoTotal)
                                        {
                                            Console.WriteLine("Saldo insuficiente");
                                            Console.WriteLine("Ingresar monto menor o igual al saldo Total\n ");
                                            goto operaciones;
                                        }
                                        else
                                        {
                                            saldoTotal = saldoTotal - 20;
                                            Console.WriteLine("Saldo Total: " + saldoTotal);
                                            Console.WriteLine("Monto retirado es: " + "s/.20");                                        
                                            Console.WriteLine("¡Ha retirado satisfactoriamente!");                                         
                                        }
                                        break; goto operaciones;                                       
                                    case 2:
                                        if (50 >= saldoTotal)
                                        {
                                            Console.WriteLine("Saldo insuficiente");
                                            Console.WriteLine("Ingresar monto menor o igual al saldo Total\n ");
                                            goto operaciones;
                                        }
                                        else
                                        {
                                            saldoTotal = saldoTotal - 50;
                                            Console.WriteLine("Saldo Total: " + saldoTotal);
                                            Console.WriteLine("Monto retirado es: " + "s/.50");
                                            Console.WriteLine("¡Ha retirado satisfactoriamente!");
                                        }
                                        break; goto operaciones;
                                    case 3:
                                        if (100 >= saldoTotal)
                                        {
                                            Console.WriteLine("Saldo insuficiente");
                                            Console.WriteLine("Ingresar monto menor o igual al saldo Total\n ");
                                            goto operaciones;
                                        }
                                        else
                                        {
                                            saldoTotal = saldoTotal - 100;
                                            Console.WriteLine("Saldo Total: " + saldoTotal);
                                            Console.WriteLine("Monto retirado es: " + "s/.100");
                                            Console.WriteLine("¡Ha retirado satisfactoriamente!");
                                        }
                                        break; goto operaciones;
                                    case 4:
                                        if (200 >= saldoTotal)
                                        {
                                            Console.WriteLine("Saldo insuficiente");
                                            Console.WriteLine("Ingresar monto menor o igual al saldo Total\n ");
                                            goto operaciones;
                                        }
                                        else
                                        {
                                            saldoTotal = saldoTotal - 200;
                                            Console.WriteLine("Saldo Total: " + saldoTotal);
                                            Console.WriteLine("Monto retirado es: " + "s/.200");
                                            Console.WriteLine("¡Ha retirado satisfactoriamente!");
                                        }
                                        break; goto operaciones;
                                    case 5:
                                        Console.WriteLine("Ingrese otro monto de retiro");
                                        otroMontoRetiro = double.Parse(Console.ReadLine());
                                        saldoTotal = saldoTotal - otroMontoRetiro;
                                        Console.WriteLine("Monto Retirado " + "s/. "+otroMontoRetiro);
                                        Console.WriteLine("¡Ha retirado satisfactoriamente!");
                                        break; goto operaciones;
                                   default: 
                                        Console.WriteLine("Opcion incorrecta");
                                        break; goto operaciones;
                                }
                            break;
                            case 4:
                                Console.WriteLine("***Recargar  Saldo***\n");
                                Console.WriteLine("==============");
                                Console.WriteLine("Ingresar la cuenta de Origen ");
                                cuentaOrigen = Console.ReadLine();
                                Console.WriteLine("Ingresar monto de Origen ");
                                montoOrigen = double.Parse(Console.ReadLine());

                                saldoTotal=saldoTotal + montoOrigen;
                                break;goto operaciones;

                            default:Console.WriteLine("Salir\n");
                            break;
                                goto operaciones;
                        }
                    }
                    while (op != 5);
                    goto final;
                    //Console.ReadKey();
                }

            }
            final:
            Console.WriteLine("\n******************************************");
            Console.WriteLine("Retire su tarjeta.");
            Console.Write("Gracias por su visita. Hasta pronto.....");
            Console.WriteLine("\n******************************************");
           
            Console.ReadKey();



            /*
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
        Console.Clear();
        Console.WriteLine("\n--------------------------------------");
        Console.WriteLine("\n\n** Su saldo es S/ {0} **", saldo);
        Console.WriteLine("Se le descontó por sus operaciones : S/{0}",des
       c);
        final:
            Console.WriteLine("\n******************************************"
           );
            Console.WriteLine("Retire su tarjeta.");
            Console.Write("Gracias por su visita. Hasta pronto.....");
            Console.ReadLine();
            */
        }
    }
}
