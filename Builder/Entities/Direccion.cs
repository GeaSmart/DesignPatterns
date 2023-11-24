namespace Builder.Entities
{
    public class Direccion
    {
        public int IdDireccion { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public Direccion(int IdDireccion)
        {
            this.IdDireccion = IdDireccion;
        }
        public Direccion(string Domicilio, string Ciudad, string Pais, string CodigoPostal)
        {
            this.Domicilio = Domicilio;
            this.Ciudad = Ciudad;
            this.Pais = Pais;
            this.CodigoPostal = CodigoPostal;
        }

        public override string ToString()
        {
            return $"Id:{IdDireccion}, Domicilio:{Domicilio}, Ciudad:{Ciudad}, Pais:{Pais}, CP:{CodigoPostal}";
        }
    }
}