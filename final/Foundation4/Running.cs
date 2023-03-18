using System;

public class Running : Activity
{
    private int _distance;

    public Running(string date, int time, int distance)
        : base(date, time){
            _distance = distance;
        }
    public double GetSpeedRunning(){
        return _distance / GetTime() * 60;
    }

    public double GetPaceRunning(){
        return GetTime() / _distance;
    }


    public override string GetSummary()
    {
        return $"- Distance: {_distance} Miles, Speed: {GetSpeedRunning} mph, Pace: {GetPaceRunning} per mile";
    }
}