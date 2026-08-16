namespace AppCore;

public class Note
{
    public string Title { get; set; } = "";
    public string Body { get; set; } = "";
    public DateTime Created { get; set; } = DateTime.Now;
}

public static class NoteStore
{
    public static string Describe(Note n) =>
        $"{n.Title} ({n.Created:yyyy-MM-dd})";
}