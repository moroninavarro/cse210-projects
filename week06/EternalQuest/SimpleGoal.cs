using System;
using System.Security.Cryptography.X509Certificates;

public class SimpleGoal: Goal{


    private bool _isComplete;


    public SimpleGoal():base ("", "", 10)
    {
    
    }

    public override void RecordEvent()
    {
        GetDetailsString();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }


    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    //Example
    //    public override double GetArea()
    //  {
    //    return _side * _side;
    //}

}