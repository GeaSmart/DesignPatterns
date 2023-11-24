using System;
using System.Collections.Generic;

namespace PostPattern.Entities
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

        public class EmpleadoBuilder : IBuilder<Empleado>
        {
            private int IdEmpleado;
            private string Nombre;
            private DateTime FechaIngreso;
            private Area Area;
            private Cargo Cargo;
            private Direccion Direccion;
            private List<Telefono> Telefonos = new List<Telefono>();

            public EmpleadoBuilder()
            {

            }

            public EmpleadoBuilder SetId(int IdEmpleado)
            {
                this.IdEmpleado = IdEmpleado;
                return this;
            }

            public EmpleadoBuilder SetNombre(string Nombre)
            {
                this.Nombre = Nombre;
                return this;
            }

            public EmpleadoBuilder SetFechaIngreso(DateTime FechaIngreso)
            {
                this.FechaIngreso = FechaIngreso;
                return this;
            }
            //Setear area cuando ya existe
            public EmpleadoBuilder SetArea(int IdArea)
            {
                Area = new Area(IdArea);
                return this;
            }
            //Setear y crear una área
            public EmpleadoBuilder SetArea(string NombreArea)
            {
                Area = new Area(NombreArea);
                return this;
            }
            //Setear cargo cuando ya existe
            public EmpleadoBuilder SetCargo(int IdCargo)
            {
                Cargo = new Cargo(IdCargo);
                return this;
            }
            //Setear y crear un cargo
            public EmpleadoBuilder SetCargo(string NombreCargo)
            {
                Cargo = new Cargo(NombreCargo);
                return this;
            }
            //Setear dirección existente
            public EmpleadoBuilder SetDireccion(int IdDireccion)
            {
                Direccion = new Direccion(IdDireccion);
                return this;
            }
            //Setear y crear nueva dirección
            public EmpleadoBuilder SetDireccion(string Domicilio, string Ciudad, string Pais, string CodigoPostal)
            {
                Direccion = new Direccion(Domicilio, Ciudad, Pais, CodigoPostal);
                return this;
            }
            //Añadir un registro telefónico existente
            public EmpleadoBuilder AddTelefonos(int IdTelefono)
            {
                Telefonos.Add(new Telefono(IdTelefono));
                return this;
            }
            //Añadir y crear teléfonos
            public EmpleadoBuilder AddTelefonos(int CodigoInternacional, int NumeroTelefonico, string TipoTelefono)
            {
                Telefonos.Add(new Telefono(CodigoInternacional, NumeroTelefonico, TipoTelefono));
                return this;
            }
            public Empleado Build()
            {
                return new Empleado(IdEmpleado, Nombre, FechaIngreso, Area, Cargo, Direccion, Telefonos);
            }
        }
    }
}