public class Assignment{
    private string _studentName, _topic;

    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudenName(){
        return _studentName;
    }

    public string GetTopic(){
        return _topic;
    }

    public string GetSummary(){
        return _studentName + "-" + _topic;
    }
}