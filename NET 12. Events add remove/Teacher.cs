public class Teacher
{
    SortedList<int, ExamDelegate> _sortedDelegates = new();
    Random _random = new();

    public event ExamDelegate ExamEvent
    {
        add
        {
            for (int key = 0;;)
            {
                key = _random.Next();
                if (!_sortedDelegates.ContainsKey(key))
                {
                    _sortedDelegates.Add(key, value);
                    break;
                }
            }
        }
        remove
        {
            _sortedDelegates.Remove(_sortedDelegates.IndexOfValue(value));
        }
    }

    public void StartExam(string task)
    {
        foreach (var key in _sortedDelegates.Keys)
        {
            if(_sortedDelegates[key] is not null)
                _sortedDelegates[key](task);
        }
    }
}