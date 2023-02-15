public class WritingAssignment : Assignment{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritinInfo(){
        string studentName = GetStudenName();
        return $"{_title} By: {studentName}";
    }
}