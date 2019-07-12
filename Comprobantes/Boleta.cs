using System;
using System.Collections.Generic;
using System.Text;

namespace Comprobantes
{
    class Boleta
    {
        List<Factura> facturas = new List<Factura>();
        List<Producto> productos = new List<Producto>();

        public Boleta(List<Factura> facturas, List<Producto> productos) { 
            
            this.facturas = facturas;
            this.productos = productos;
        }

         public void imprimirBoleta()
        {
           // Console.WriteLine(mostrarFacturas());
            mostrarFacturas();
           mostrarProductos();
        }

       public void mostrarFacturas() {
            foreach (var factura in facturas)
            {
                Console.WriteLine("Se estan imprimiendo los objeto factura");
                Console.WriteLine(factura);
            }
        }

       public void mostrarProductos()
        {
            foreach (var producto in productos)
            {
                Console.WriteLine("Se estan imprimiendo los objeto factura");
                Console.WriteLine(producto);
            }
        }



    }
}
