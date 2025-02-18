using System;


public class Bicycles: Activity{
    protected double _distance;
    protected double _speed;
    

    public Bicycles(string date, int length, double distance, double speed): base(date, length)
    {
        _distance = distance;
        _speed = speed;
    }


    
    public override double GetDistance(){
        return _distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
       return 60 / _speed;
    }

     public override string GetAditionalInfo()
    {
        return $"Distance {GetDistance()} Km, Speed {GetSpeed()} Kph, Pace: {GetPace()} min per Km";
    }
}