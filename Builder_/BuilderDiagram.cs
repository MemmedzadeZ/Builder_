


namespace ConsoleApp1;

public interface Builder

{

    public void reset()

    { }

    public void setSeats(int number) { }

    public void setEngine(string engine) { }

    public void setTripComputer() { }

    public void setGPS() { }


}


public class Director

{

    Builder? builder;

    public void makeSUV(string builder) { }

    public void makeSportsCar(Builder builder)

    {

        builder.reset();

        builder.setSeats(2);

        builder.setTripComputer();

        builder.setGPS();

    }


}


public class Car { }

public class Manual { }


public class CarBuilder : Builder

{

    private Car? car;

    public void reset()

    {

        this.car = new Car();

    }

    public void setSeats(int number) { }

    public void setEngine(string engine) { }

    public void setTripComputer() { }

    public void setGPS() { }

    public Car getResult()

    {

        return this.car!;

    }

}


public class CarManual : Builder

{

    private Manual? manual;

    public void reset()

    {

        this.manual = new Manual();

    }

    public void setSeats(int number) { }

    public void setEngine(string engine) { }

    public void setTripComputer() { }

    public void setGPS() { }


    public Manual getResult()

    {

        return this.manual!;

    }

}



