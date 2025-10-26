using System;

namespace CapaNegocio
{
    public class DetalleCompraModel
    {
        public int cod_detalle { get; set; }   
        public int cod_compra { get; set; }      
        public int cod_producto { get; set; }    

        public decimal precio_compra { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }

        public ProductoModel oProducto { get; set; }
    }
}
