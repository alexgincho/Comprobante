using System;
using System.Collections.Generic;
using System.Text;

namespace Comprobantes
{
    class Comprobante
    {
        List<Producto> listaProductos = new List<Producto>();
        private string codigo;
        private string razonSocial;
        private string direccion;
        private string fecha;
        double GetTotalProductos()
        {
            return 0;
        }
       /* double GetIgv()
        {
           // return subtotal = GetTotalProductos();
            //return total 
        }*/
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        internal List<Producto> ListaProductos
        {
            get => listaProductos;
            set => listaProductos = value;
        }
    }
}
