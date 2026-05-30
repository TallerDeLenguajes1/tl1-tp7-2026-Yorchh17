using empleado;

Empleado[] ListaEmpleado = new Empleado[3];

//empleado 1
Empleado emp1 = new Empleado();
emp1.Nombre = "LA";
emp1.Apellido = "CABRA";
emp1.Fechanacimiento = new DateTime(1990, 5, 20); 
emp1.EstadoCivil = 'C';
emp1.FechaIngreso = new DateTime(2015, 3, 10);
emp1.SueldoBasico = 500000;
emp1.Cargo = Cargos.Ingeniero;
ListaEmpleado[0]=emp1;


//empleado 2
Empleado emp2= new Empleado();
emp2.Nombre ="PATO";
emp2.Apellido = "SOTO";
emp2.Fechanacimiento = new DateTime(2004, 5, 20); 
emp2.EstadoCivil = 'S';
emp2.FechaIngreso = new DateTime(2015, 3, 10);
emp2.SueldoBasico = 500000;
emp2.Cargo = Cargos.Especialista;
ListaEmpleado[1]=emp2;


//empleado 3
Empleado emp3= new Empleado();
emp3.Nombre ="popa";
emp3.Apellido = "mamani";
emp3.Fechanacimiento = new DateTime(2004, 5, 20); 
emp3.EstadoCivil = 'V';
emp3.FechaIngreso = new DateTime(2015, 3, 10);
emp3.SueldoBasico = 100;
emp3.Cargo = Cargos.Investigador;
ListaEmpleado[2]=emp3;

