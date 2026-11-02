namespace LibraryDesk.Core;

public class LoanItem
{
    public Book Book { get; set; }

    public DateOnly DueDate { get; set; }

    public bool IsReturned { get; set; }

    public LoanItem(Book book, DateOnly dueDate)
    {
        Book = book;
        DueDate = dueDate;
        IsReturned = false;
    }
}