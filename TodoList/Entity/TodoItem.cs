namespace TodoList.Entity;

public class TodoItem
{
    private string id;
    public string Id
    {
        get => id;
        set => id = value;
    }

    private string title;
    public string Title
    {
        get => title;
        set => title = value;
    }

    private bool isDone;
    public bool IsDone
    {
        get => isDone;
        set => isDone = value;
    }
}

