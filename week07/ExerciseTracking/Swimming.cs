using System;

public class Swimming: Activity{
    
    protected double _NumLaps;
    protected double _speed;

    public Swimming(string date, int length, double NumLaps, double speed): base(date, length)
    {
        _NumLaps = NumLaps;
        _speed = speed;
    }
    public override double GetDistance(){
        return _NumLaps * 50 / 1000;
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