using System;
using System.IO;

public class CheckList : Goal{
   
    private int _pointsWorth = 0;
   private bool _completion = false;
   private int _numTimes = 0;
   private int _bonusPoints = 0;
   

   public int GetPointsWorthCheck(){
        return _pointsWorth;
    }

    public void SetPointsWorthCheck(int pointsWorth){
        _pointsWorth = pointsWorth;
    }

    public bool GetCompletionCheck(){
        return _completion;
    }

    public void SetCompletionCheck(bool completion){
        _completion = completion;
    }
    
    public int GetBonusPoints(){
        return _bonusPoints;
    }

    public void SetBonusPoints(int bonusPoints){
        _bonusPoints = bonusPoints;
    }

    public int GetCompletionTimes(){
        return _numTimes;
    }

    public void SetCompletionTimes(int numTimes){
        _numTimes = numTimes;
    }
    
}