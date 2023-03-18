using System;

public class Cycling : Activity{
    private int _speed;

    public Cycling(string date, int time, int speed)
        : base(date, time){
            _speed = speed;
        }

 
    public int GetPaceCycle(){
        return 60 / _speed;
    }

    public int GetDistanceCycle(){
        return _speed * GetTime();
    }

    public override string GetSummary()
    {
        return $"- Distance: {GetDistanceCycle} Miles, Speed: {_speed} mph, Pace: {GetPaceCycle} per mile";
    }
}