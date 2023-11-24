namespace PrePattern.Entities
{
    public class Telefono
    {
        public int IdTelefono { get; set; }
        public int CodigoInternacional { get; set; }
        public int NumeroTelefonico { get; set; }
        public string TipoTelefono { get; set; }
        public Telefono(int IdTelefono)
        {
            this.IdTelefono = IdTelefono;
        }
        public Telefono(int CodigoInternacional, int NumeroTelefonico, string TipoTelefono)
        {
            this.CodigoInternacional = CodigoInternacional;
            this.NumeroTelefonico = NumeroTelefonico;
            this.TipoTelefono = TipoTelefono;
        }

        public override string ToString()
        {
            return $"Id:{IdTelefono}, Codigo:{CodigoInternacional}, Numero:{NumeroTelefonico}, Tipo:{TipoTelefono}";
        }
    }
}