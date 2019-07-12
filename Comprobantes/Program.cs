using System;
using System.Collections.Generic;

namespace Comprobantes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Factura> misFacturas = new List<Factura>();
            List<Boleta> misBoletas = new List<Boleta>();
            List<NotaCredito> misNotasDeCredito = new List<NotaCredito>();
            List<Producto> misProductos = new List<Producto>();
            string opcion;
            do
            {
                Console.WriteLine("Facturacion electronica");
                Console.WriteLine("1 Registrar Factura");
                Console.WriteLine("2 Registrar Boleta");
                Console.WriteLine("3 Registrar Nota de credito");
                Console.WriteLine("4 Reporte de ventas");

            } while (false);

           /* Factura factura = new Factura("Mi empresa", "Calle Puno",
                "19/04/2019", "20712324932");
             factura.Codigo = "001";
             factura.Fecha = "10/07/2019";
             factura.Direccion = "Mi casa";

             misFacturas.Add(factura);

             Factura factura2 = new Factura();
             misFacturas.Add(factura2);
             Console.WriteLine(Factura.contador);

             foreach (var item in misFacturas)
             {
                 Console.WriteLine(item);
             }
             */
            Factura f = new Factura("ggggg","av jesus","2332","12321321");
            misFacturas.Add(f);
            Producto p = new Producto("papitas",2,4.5);
            misProductos.Add(p);
           
            Console.WriteLine("Escpge tu opcion :");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    string opcions;
                    Console.Clear();
                    Console.WriteLine("1.Ingresar Datos Factura");
                    Console.WriteLine("2.Ingresar Productos de la Factura");
                    Console.WriteLine("3.Finalizar");
                    Console.WriteLine("Selecciona tu Opcion ::");
                    opcions = Console.ReadLine();
                
                    switch (opcions)
                    {
                        case "1":
                            Console.WriteLine("******Bienvenido Ingrese Datos de Factura******");
                            Console.WriteLine("Ingrese Razon Social ::");
                            string razonSocial = Console.ReadLine();
                            Console.WriteLine("Ingrese Fecha::");
                            string fecha = Console.ReadLine();
                            Console.WriteLine("Ingrese Ruc ::");
                            string ruc = Console.ReadLine();
                            Console.WriteLine("Ingrese Direccion::");
                            string Direccion = Console.ReadLine();

                            Factura fac = new Factura(razonSocial, Direccion, fecha, ruc);
                            misFacturas.Add(fac);
                            Console.WriteLine(fac);
                            break;
                        case "2":
                            Console.WriteLine("****Bienvenido Registre su Producto****");
                            Console.WriteLine("Ingrese el Nombre de su Producto :::");
                            string NomProduc = Console.ReadLine();
                            Console.WriteLine("Ingrese la Cantidad :::");
                            int CantProd = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese El precio del Producto :::");
                            double PrecioProd = double.Parse(Console.ReadLine());
                            Producto prod = new Producto(NomProduc,CantProd,PrecioProd);
                            misProductos.Add(prod);
                            Console.WriteLine(prod);
                            break;
                    }
                    break;
                case "2":
                    break;
                case "3":

                    Boleta boleta = new Boleta(misFacturas,misProductos);

                    misBoletas.Add(boleta);
                    boleta.imprimirBoleta();

                    break;
                case "4":
                    break;
            }
        }
    }
}
