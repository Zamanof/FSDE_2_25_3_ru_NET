public class Teacher
{
    public  string FirstName { get; set; }
    public EventHandler<ExamEventArgs> OnExam { get; set; }

    public void StartExam(ExamEventArgs args)
    {
        OnExam(this, args);
    }
}