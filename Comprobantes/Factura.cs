using System;
using System.Collections.Generic;
using System.Text;

namespace Comprobantes
{
    class Factura : Comprobante
    {
        // private string razonSocial;
        private string ruc;
        private double igv;
        static public int contador = 0;

        public override string ToString()
        {
            return $"Codigo: {Codigo}\nRuc: {ruc}\nFecha: {Fecha}\n" +
               $"Direccion: {Direccion}";
        }

        public Factura()
        {
            contador++;
        }
        public Factura(string razonSocial, string direccion,
           string fecha, string ruc)
        {
            RazonSocial = razonSocial;
            Direccion = direccion;
            Fecha = fecha;
            this.ruc = ruc;
            Codigo = "00" + contador;
            contador++;

        }

        public double IGV
        {
            get { return IGV; }
            set { IGV = value; }
        }

        public string RUC
        {
            get { return RUC; }
            set { RUC = value; }
        }
    }
}
