
////using p1bpoo.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());

using p1bpoo.MisClases;
using p1bpoo.p1bpoo.MisClases;

Chofer piloto1 = new Chofer("David", 25, "A");
Chofer piloto2 = new Chofer("Nayely", 21, "M");
Chofer piloto3 = new Chofer("Carlos", 30, "C");
Chofer piloto4 = new Chofer("Luis", 28, "A");
Chofer piloto5 = new Chofer("Sule", 22, "B");
Chofer piloto6 = new Chofer("Han-Solo", 35, "A");

Vehiculo sedan = new Vehiculo(2025, "Azul", "Honda", 180);
Moto moto1 = new Moto(2020, "Rojo", "Yamaha", 150);
Moto moto2 = new Moto(2021, "Negro", "Kawasaki", 160);
Bus bus1 = new Bus(2020, "Verde", "Mercedes", 130, 30, 12, true, true, 2);
CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD", 100);
Trailer trailer = new Trailer(2022, "Blanco", "Volvo", 120, 20000, "Carga Pesada", 4, true, 18.5);

string respuesta;

// Asignar pilotos a los vehículos
respuesta = sedan.AsignarPiloto(piloto1);
Console.WriteLine(respuesta);

respuesta = moto1.AsignarPiloto(piloto2);
Console.WriteLine(respuesta);

respuesta = moto2.AsignarPiloto(piloto3);
Console.WriteLine(respuesta);

respuesta = bus1.AsignarPiloto(piloto4);
Console.WriteLine(respuesta);

respuesta = miBYD.AsignarPiloto(piloto5);
Console.WriteLine(respuesta);

respuesta = trailer.AsignarPiloto(piloto6);
Console.WriteLine(respuesta);

// Pruebas para cada vehículo
respuesta = sedan.Encender();
Console.WriteLine(respuesta);
sedan.Acelerar(10);
sedan.InformacionVehiculo();

Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("----------------------------------------------------------------------\n");
respuesta = moto1.Encender();
Console.WriteLine(respuesta);
moto1.Acelerar(50);
moto1.HacerCaballito();
moto1.Frenar(50);
moto1.Apagar();
moto1.InformacionVehiculo();

Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("----------------------------------------------------------------------\n");
respuesta = moto2.Encender();
Console.WriteLine(respuesta);
moto2.Acelerar(60);
moto2.HacerCaballito();
moto2.Frenar(60);
moto2.Apagar();
moto2.InformacionVehiculo();

Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("----------------------------------------------------------------------\n");
respuesta = bus1.Encender();
Console.WriteLine(respuesta);
bus1.Acelerar(20);
bus1.InformacionVehiculo();

Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("----------------------------------------------------------------------\n");
respuesta = miBYD.Encender();
Console.WriteLine(respuesta);
miBYD.Acelerar(30);
miBYD.InformacionVehiculo();
miBYD.cargarBateria();
Console.WriteLine("El nivel de batería es: {0}", miBYD.NivelBateria());

Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine("----------------------------------------------------------------------\n");
Console.WriteLine(respuesta);
trailer.Acelerar(40);
trailer.InformacionVehiculo();
trailer.Frenar(40);
trailer.Apagar();
trailer.InformacionVehiculo();

//piloto1.mostrarInformacion();
//piloto2.mostrarInformacion();


