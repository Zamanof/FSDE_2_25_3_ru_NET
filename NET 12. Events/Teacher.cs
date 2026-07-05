namespace NET_12._Events;

public class Teacher
{
    public event ExamDelegate ExamEvent;

    public void StartExam(string task)
    {
        ExamEvent(task);
    }
}