using Trabajo;


Vehiculo vec = new Vehiculo("McLaren", "2");
Vehiculo asd = new Vehiculo("Ferraria", "2");
Vehiculo qda = new Vehiculo("Redbull", "2");
Circuito cir = new Circuito(6, "Nascar");

cir.AñadirVehiculo(vec);
var dict = cir.RealizarPrueba();



