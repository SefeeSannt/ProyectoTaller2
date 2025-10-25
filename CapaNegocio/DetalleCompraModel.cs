using System;

namespace CapaNegocio
{
    public class DetalleCompraModel
    {
        // Identificadores (útiles para mapeo y operaciones)
        public int cod_detalle { get; set; }     // opcional si la BD lo genera
        public int cod_compra { get; set; }      // para asociar al guardar/recuperar
        public int cod_producto { get; set; }    

        // Valores comerciales
        public decimal precio_compra { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }

        // Referencia opcional al producto (no requerida para persistencia)
        public ProductoModel oProducto { get; set; }
    }
}
