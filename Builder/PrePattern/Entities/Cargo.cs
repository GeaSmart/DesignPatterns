namespace PrePattern.Entities
{
    public class Cargo
    {
        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public Area Area { get; set; }

        public Cargo(int IdCargo)
        {
            this.IdCargo = IdCargo;
        }
        public Cargo(string NombreCargo)
        {
            this.NombreCargo = NombreCargo;
        }
        public Cargo(int IdCargo, string NombreCargo, Area Area)
        {
            this.IdCargo = IdCargo;
            this.NombreCargo = NombreCargo;
            this.Area = Area;
        }
        public override string ToString()
        {
            return $"Id:{IdCargo}, Nombre:{NombreCargo}";
        }
    }
}