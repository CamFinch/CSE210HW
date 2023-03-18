using System;

public class Swimming : Activity{
    private int _laps;

    public Swimming(string date, int time, int laps)
        : base(date, time){
            _laps = laps;
        }
    public double GetDistanceSwim(){
        return _laps * 50 / 1000 * 0.62;
    }
    public double GetSpeedSwim(){
        return GetDistanceSwim() / GetTime() * 60;
    }

    public double GetPaceSwim(){
        return GetTime() / GetSpeedSwim();
    }
    public override string GetSummary()
    {
        return $"- Distance: {GetDistanceSwim} Miles, Speed: {GetSpeedSwim} mph, Pace: {GetPaceSwim} per mile";
    }


}