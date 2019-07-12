using System;
using System.Collections.Generic;
using System.Text;

namespace Comprobantes
{
    class Producto
    {
        string nombreProducto;
        int cantidad;
        double CostoUnitario;

        public override string ToString()
        {
            return $"Nombre Producto: {nombreProducto}\nCantidad: {cantidad}\nCosto Unitario: {CostoUnitario}\n";
        }


        public Producto(string nombreProducto, int cantidad, double CostoUnitario)
        {
            this.NombreProducto = nombreProducto;
            this.Cantidad = cantidad;
            this.CostoUnitario1 = CostoUnitario;
        }

        public string NombreProducto
        {
            get => nombreProducto;
            set => nombreProducto = value;
        }
        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
        public double CostoUnitario1
        {
            get => CostoUnitario;
            set => CostoUnitario = value;
        }
    }
}
