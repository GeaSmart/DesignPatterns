using System;
using System.Collections.Generic;

namespace PrePattern.Entities
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Area Area { get; set; }
        public Cargo Cargo { get; set; }
        public Direccion Direccion { get; set; }
        public List<Telefono> Telefonos { get; set; }

        #region Constructores
        public Empleado(int IdEmpleado, string Nombre, DateTime FechaIngreso, Area Area, Cargo Cargo, Direccion Direccion, List<Telefono> Telefonos)
        {
            this.IdEmpleado = IdEmpleado;
            this.Nombre = Nombre;
            this.FechaIngreso = FechaIngreso;
            this.Area = Area;
            this.Cargo = Cargo;
            this.Direccion = Direccion;
            this.Telefonos = Telefonos;
        }

        public Empleado(int IdEmpleado, string Nombre, DateTime FechaIngreso)
        {
            this.IdEmpleado = IdEmpleado;
            this.Nombre = Nombre;
            this.FechaIngreso = FechaIngreso;
        }
        public Empleado()
        {

        }
        #endregion

        public override string ToString()
        {
            return $@"Empleado =>
            Nombre:{Nombre}
            FechaIngreso:{FechaIngreso}
            Area => {Area}
            Cargo => {Cargo}
            Direccion => {Direccion}
            Telefonos => {string.Join(" 🐿️ ", Telefonos)}";
        }    
    }
}