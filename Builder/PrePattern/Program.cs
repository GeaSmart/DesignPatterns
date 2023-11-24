// See https://aka.ms/new-console-template for more information
using PrePattern.Entities;

Console.WriteLine("Example without Builder pattern!");

//Creo el objeto empleado
Empleado empleado = new Empleado();
empleado.IdEmpleado = 123;
empleado.Nombre = "Gerson";
empleado.FechaIngreso = new DateTime(2020, 12, 20);

//Creo los objetos compuestos de empleado
Area area = new Area("IT");
Cargo cargo = new Cargo(".NET Engineer");
Direccion direccion = new Direccion("Calle Begonias 23","Lima","Peru","54321");
List<Telefono> telefonos = new List<Telefono>(){
    new Telefono(51, 789545521, "Móvil"),
    new Telefono(1, 985552000, "Whatsapp"),
    new Telefono(51, 8526320, "Fijo")
};
//Asigno los objetos compuestos al objeto principal empleado
empleado.Area = area;
empleado.Cargo = cargo;
empleado.Direccion = direccion;
empleado.Telefonos = telefonos;

Console.WriteLine(empleado);
