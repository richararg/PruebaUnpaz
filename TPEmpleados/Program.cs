// See https://aka.ms/new-console-template for more information
using TPEmpleados;

Console.WriteLine("Hello, World!");

Auto gol = new Auto("AAA111", "Volskwagen", "Gol");
Auto corsa = new Auto("BBB222", "Chevrolet", "Corsa");
Auto cronos = new Auto("CCC333", "Fiat", "Cronos");
Puesto supervisor = new Puesto("Supervisor", 1.20);
Puesto empleado = new Puesto("Empleado", 1.10);
Empleado jose = new Empleado("Jose", "Perez", "alem 3800", 645648, 21, 1, "6548-6546", 200000, empleado);
Empleado pedro = new Empleado ("Pedro", "lopez", "mexico 500", 65468, 25, 3, "64888-444", 150000, empleado);
Empleado maria = new Empleado("Maria", "gonzalez", "maipu 6879", 6489874, 30, 4, "654698-56", 300000, supervisor, jose, "Finanzas", corsa);
Empleado carlo = new Empleado("Carlos", "sosa", "peron 65468", 7812233, 23, 1, "879-87989", 150000, empleado, maria);
Empleado ricardo = new Empleado("ricardo", "zarza", "thomas 27896", 6479876, 44, 2, "6448-56", 450000, supervisor, pedro, "Ventas", cronos);



Console.WriteLine("Supervisor: " + maria.presentarse());
Console.WriteLine("Empleado: " + carlo.presentarse());

// cambio de supervisor
carlo.cambiosupervisor(ricardo);
// verificar cambio
Console.WriteLine("Empleado: " + carlo.presentarse());

// mostrar salario empleado
Console.WriteLine(carlo.presentarse() + "Salario sin aumento: " + carlo.getsalario());
//aumento
carlo.incrementarsalario();
Console.WriteLine(carlo.presentarse() + "Salario con aumento: " + carlo.getsalario());


// mostrar salario supervisor
Console.WriteLine(maria.presentarse() + "Salario sin aumento: " + maria.getsalario());
//aumento
maria.incrementarsalario();
Console.WriteLine(carlo.presentarse() + "Salario con aumento: " + maria.getsalario());

// cambiar auto
ricardo.cambioauto(gol);
ricardo.cambiasecretario(carlo);

