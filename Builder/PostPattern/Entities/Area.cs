using System.Collections.Generic;

namespace PostPattern.Entities
{
    public class Area
    {
        public int IdArea { get; set; }
        public string NombreArea { get; set; }
        public List<Cargo> Cargos { get; set; }

        public Area(int IdArea)
        {
            this.IdArea = IdArea;
            this.NombreArea = NombreArea;
        }
        public Area(string NombreArea)
        {
            this.NombreArea = NombreArea;
        }
        public Area(int IdArea, string NombreArea, List<Cargo> Cargos)
        {
            this.IdArea = IdArea;
            this.NombreArea = NombreArea;
            this.Cargos = Cargos;
        }

        public override string ToString()
        {
            return $"Id:{IdArea}, Nombre:{NombreArea}";
        }
    }
}