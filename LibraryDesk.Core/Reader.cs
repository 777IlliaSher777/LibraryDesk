namespace LibraryDesk.Core;

public class Reader
{
    public int Id { get; set; }

    public string Name { get; set; }

    public bool IsActive { get; set; }

    public Reader(int id, string name)
    {
        Id = id;
        Name = name;
        IsActive = true;
    }
}