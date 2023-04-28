namespace Modelos
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int CodigoServicio { get; set; }
	    public decimal Precio { get; set; }
        public decimal Total { get; set; }
    }
}
