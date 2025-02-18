using System;
public abstract class Activity{
    protected string _date;
    protected int _length;
    

    public Activity(string date, int length){
       _date = date;
       _length = length;
       
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    
    public virtual string GetSummary(){
        
         return $"{_date} ({_length} min)-{GetAditionalInfo()}";
     }
    
 
    public virtual string GetAditionalInfo(){
        return string.Empty;
    }

    
}