using System;
using System.IO;

public class Eternal : Goal{
    
    private int _pointsWorth = 0;

    public int GetPointsWorthEternal(){
        return _pointsWorth;
    }

    public void SetPointsWorthEternal(int pointsWorth){
        _pointsWorth = pointsWorth;
    }
    
}