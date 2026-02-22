public class Menu
{
    private Journal _journal;
    private PromptGenerator _promptGenerator;
    public Menu(Journal journal, PromptGenerator promptGenerator)
    {
        _journal = journal;
        _promptGenerator = promptGenerator;
    }
    public void Display()
    {
        string response = "";
        string[] options= {"1","2","3","4","5"};
        while(response != "5"){
            while(options.Contains(response)==false){
                Console.WriteLine("Please select one of the following choices:");
                Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\nWhat would you like to do? ");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch(response){
                case "1":
                    string prompt = _promptGenerator.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    string responseText = Console.ReadLine() ?? "";
                    Console.WriteLine();

                    string dateText = DateTime.Now.ToShortDateString();

                    Entry entry = new Entry(dateText, prompt, responseText);

                    _journal.AddEntry(entry);
                    break;

                case "2":
                    _journal.DisplayAll();
                    break;

                case "3":
                    Console.WriteLine("Enter filename: ");
                    string loadFile = Console.ReadLine() ?? "";
                    
                    _journal.LoadFromFile(loadFile);

                    Console.WriteLine("File loaded.");
                    Console.WriteLine();
                    break;

                case "4":
                    Console.WriteLine("Enter filename: ");
                    string saveFile = Console.ReadLine() ?? "";

                    _journal.SaveToFile(saveFile);
                    
                    Console.WriteLine("File saved.");
                    Console.WriteLine();
                    break;

                case "5":
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }
    }
}