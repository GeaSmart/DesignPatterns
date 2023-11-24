// See https://aka.ms/new-console-template for more information
using System;
using PostPattern.Entities;

Console.WriteLine("Builder Pattern Applied!");

//Creo un objeto empleado y me olvido de crear más objetos, simplemente seteo la información
Empleado empleado = new Empleado.EmpleadoBuilder()
    .SetId(123)
    .SetNombre("Gerson")
    .SetFechaIngreso(new DateTime(2020,12,20))
    .SetArea("IT")
    .SetCargo(".NET Engineer")
    .SetDireccion("Calle Begonias 23","Lima","Peru","54321")
    .AddTelefonos(51,789545521,"Móvil")
    .AddTelefonos(1,985552000,"Whatsapp")
    .AddTelefonos(51,8526320,"Fijo")
    .Build();

Console.WriteLine(empleado);
