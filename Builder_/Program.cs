



using ConsoleApp1;

CarBuilder carBuilder = new();
CarManual carManual = new();

Director director = new();



director.makeSportsCar(carBuilder);
director.makeSportsCar(carManual);


Car car = carBuilder.getResult();


director.makeSportsCar(carManual);
Manual manual = carManual.getResult();

