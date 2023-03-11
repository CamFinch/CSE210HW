using System;
using System.IO;

public class Simple : Goal{
   private int _pointsWorth = 0;
   private bool _completion = false;

   public int GetPointsWorthSimple(){
        return _pointsWorth;
    }

    public void SetPointsWorthSimple(int pointsWorth){
        _pointsWorth = pointsWorth;
    }

    public bool GetCompletionSimple(){
        return _completion;
    }

    public void SetCompletionSimple(bool completion){
        _completion = completion;
    }

    
}