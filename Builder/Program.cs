// See https://aka.ms/new-console-template for more information
using Builder.Entities;

Console.WriteLine("Hello, World!");

Empleado empleado = new Empleado.EmpleadoBuilder()
    .SetId(123)
    .SetNombre("Gerson")
    .SetFechaIngreso(new DateTime(2020,12,20))
    .SetArea("Sistemas")
    .SetCargo("Asistente")
    .SetDireccion("Calle Begonias 23","Lima","Peru","54321")
    .AddTelefonos(51,789545521,"Móvil")
    .AddTelefonos(1,985552000,"Whatsapp")
    .AddTelefonos(51,8526320,"Fijo")
    .Build();

Console.WriteLine(empleado);
