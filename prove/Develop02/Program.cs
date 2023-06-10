public class JournalEntry
{
    public DateTime Date { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
}

class Program
{
    static List<JournalEntry> entries = new List<JournalEntry>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add new journal entry");
            Console.WriteLine("2. View existing journal entries");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddEntry();
                    break;
                case 2:
                    ViewEntries();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    static void AddEntry()
    {
        Console.Write("Enter the date of the entry (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the title of the entry: ");
        string title = Console.ReadLine();

        Console.Write("Enter the text of the entry: ");
        string text = Console.ReadLine();

        JournalEntry entry = new JournalEntry()
        {
            Date = date,
            Title = title,
            Text = text
        };

        entries.Add(entry);

        Console.WriteLine("Entry added successfully");
    }

    static void ViewEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found");
            return;
        }

        foreach (JournalEntry entry in entries)
        {
            Console.WriteLine("{0} - {1}", entry.Date.ToShortDateString(), entry.Title);
            Console.WriteLine(entry.Text);
            Console.WriteLine();
        }
    }
}
