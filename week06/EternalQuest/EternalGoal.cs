using System;


public class EternalGoal: Goal{


    public EternalGoal():base ("","", 10)
    {
        return
    }




    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
       public override bool IsComplete()
    {
        throw new NotImplementedException();
    }


    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}