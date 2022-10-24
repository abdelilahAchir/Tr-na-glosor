using Träna_glosor;

internal class Program
{


    private static void Main(string[] args)
    {
      
      

        Dialog(args);
        


    }
    public static void Lists()
    {

        var lists = WordList.GetLists();
        foreach (var list in lists)
        {
            Console.WriteLine(list.ToUpper());
        }

    }

    public static void New(string listName, params string[] language)
    {

        if (language.Length < 2)
        {
            throw new ArgumentException("       You gotta enter at leat two languages for the new list".ToUpper());
        }
        var dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string path = Path.Combine($@"{dir}\{listName}.dat");
        if (!File.Exists(path))
        {
            using (StreamWriter stream = new StreamWriter(path))
            {

                string languges = string.Join(";", language);
                foreach (var lang in languges)
                {
                    stream.Write(lang);

                }
            }
            Add(listName);
        }
        else
        {
            Console.WriteLine("     The list already exists! Try with another Name".ToUpper());
        }

    }

    public static void Add(string listName)
    {
        var list = WordList.LoadList(listName.ToLower());

        if (list != null)
        {
            string enteredWord = "0";

            while (enteredWord != " " && enteredWord != "")
            {
                List<string> listOfWords = new List<string>();

                for (int i = 0; i < list.Languages.Length; i++)
                {
                    Console.WriteLine($"    Enter a word in the following language:    {list.Languages[i].ToUpper()}");
                    enteredWord = Console.ReadLine().ToLower();
                    if (enteredWord == "" || enteredWord == " ")
                    {
                        break;
                    }
                    else
                    {
                        listOfWords.Add(enteredWord);
                    }
                }
                if (enteredWord == "" || enteredWord == " ")
                {
                    break;
                }
                list.Add(listOfWords.ToArray());
            }
            list.Save();
        }
        else
        {
            Console.WriteLine("     There no list with such name!".ToUpper());
        }
    }

    public static void Remove(string listName, int language, params string[] words)
    {


        var list = WordList.LoadList(listName);
        if (list != null)
        {
            if (list.Languages.Length > language)
            {
                foreach (var word in words)
                {
                    list.Remove(language, word.ToLower());
                }
                list.Save();
            }
            else
            {
                Console.WriteLine("     The language that you chosen doesn't exist!".ToUpper());
                Console.WriteLine($"    Chose a index between the following...");
                for (int i = 0; i < list.Languages.Length; i++)
                {
                    Console.WriteLine($"        {list.Languages[i]} is index: {i}");
                }
            }

        }
        else
        {
            Console.WriteLine("     The list that you entered doesn't exists!\n".ToUpper());

            var lists = WordList.GetLists();

            if (lists.Length != 0)
            {
                Console.WriteLine("     Chose between the fallowing lists...\n".ToUpper());
                foreach (var s in lists)
                {
                    Console.WriteLine($"        {s}".ToUpper());
                }
            }
           
        }
    }

    public static void Words(string listaName, int sortByLanguage = 0)
    {
        static void Print(string[] words)
        {
            foreach (var word in words)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
        }
        Action<string[]> showTranslations = Print;

        var list = WordList.LoadList(listaName);

        if (list.Languages.Length - 1 >= sortByLanguage)
        {
            list.List(sortByLanguage, showTranslations);
        }
        else
        {
            Console.WriteLine("     There no language at the index that you entered! You can choose between the following indexes".ToUpper());
            for (int i = 0; i < list.Languages.Length; i++)
            {
                Console.WriteLine($"        {list.Languages[i]} is at index: {i}");
            }
        }
    }

    public static void Count(string listname)
    {
        var list = WordList.LoadList(listname);
        if (list != null)
        {
            Console.WriteLine($"        The amount of words in the list {listname} is: {list.Count()}".ToUpper());
        }
        else
        {
            Console.WriteLine("     The list name the you entered doesn't exist");
            Console.WriteLine("     Choose between the following lists, or create a new one!");
           var lists = WordList.GetLists();
           if (lists.Length != 0)
           {
               foreach (var lst in lists)
               {
                   Console.WriteLine($"     {lst.ToUpper()}".ToUpper());
               }
           }
        }

    }

    public static void Practice(string listName)
    {
        var list = WordList.LoadList(listName);

        if (list != null)
        {
            string enteredWord = ".";

            List<string> practicedWords = new List<string>();

            int correctTranslations = 0;

            while (enteredWord != "" && enteredWord != " ")
            {
                var word = list.GetWordToPractice();

                var wordToTranslate = word.Translations[word.FromLanguage];

                var translation = word.Translations[word.ToLanguage].ToLower();

                Console.WriteLine($"        Enter the translation of {wordToTranslate} in {list.Languages[word.ToLanguage]}");

                practicedWords.Add(wordToTranslate);

                enteredWord = Console.ReadLine();

                if (enteredWord == translation)
                {
                    correctTranslations++;
                    Console.WriteLine("     Correct translation");
                }
                else
                {
                    Console.WriteLine("   Wrong answer\n");
                }
            }
            string.Join("-", practicedWords);

            foreach (var word in practicedWords)
            {
                Console.Write($"   {word}");
            }

            var percentage = Math.Round(((decimal)correctTranslations / practicedWords.Count) * 100, 2);

            Console.WriteLine($"\n \n   The average correct translations was {correctTranslations} / {practicedWords.Count} with percentage of {percentage} %".ToUpper());
        }
        else
        {
            Console.WriteLine("     The list that you entered doesn't exist".ToUpper());
        }
    }
    public static void Dialog(string[] args)
    {
        ConsoleKey consoleKey = ConsoleKey.F1;
        Console.WriteLine("     You got the following options:");
        Console.WriteLine("     -lists");
        Console.WriteLine("     -new <list name> <language 1> <language 2> .. <langauge n> ");
        Console.WriteLine("     -add <list name>");
        Console.WriteLine("     -remove <list name> <language> <word 1> <word 2> .. <word n>");
        Console.WriteLine("     -words <listname> <sortByLanguage>");
        Console.WriteLine("     -count <listname>");
        Console.WriteLine("     -practice <listname>\n");


        if ( args.Length > 0 && args[0].ToLower() == "-lists")
        {
            Lists();
        }
        else if (args.Length > 0 && args[0].ToLower() == "-new")
        {
            if (  args.Length > 1 && args[1].ToLower() != String.Empty)
            {
                var listName = args[1].ToLower();

                if (args.Length > 3)
                {
                    List<string> languages = new List<string>();

                    for (int i = 2; i < args.Length; i++)
                    {
                        languages.Add(args[i]);
                    }
                    New(listName, languages.ToArray());
                }
                else
                {
                    Console.WriteLine("     You gotta insert two languages minimum".ToUpper());
                }
            }
            else
            {
                Console.WriteLine("     Give a name to the new list, Can't be empty!".ToUpper());
            }
        }
        else if (args.Length > 0 && args[0].ToLower() == "-add")
        {
            if (args.Length == 2 && args[1] != string.Empty && !string.IsNullOrWhiteSpace(args[1]))
            {
                var listName = args[1];
                Add(listName);
            }
            else if (args.Length > 2 )
            {
                Console.WriteLine("Insert just the action and list name".ToUpper());
                Console.WriteLine("Example : -add ListName".ToUpper());
            }
            else
            {
                Console.WriteLine("     Enter a list name as a second argument!".ToUpper());

            }
        }
        else if ( args.Length > 0 && args[0].ToLower() == "-remove")
        {
            if (args.Length >= 2 && !string.IsNullOrWhiteSpace(args[1]) && !string.IsNullOrEmpty(args[1]))
            {
                var listName = args[1];

                if (args.Length >= 3 && args[2].All(char.IsDigit))
                {
                    var language = int.Parse(args[2]);

                    if (args.Length >= 4)
                    {
                        List<string> wordsToRemove = new List<string>();
                        for (int i = 3; i < args.Length; i++)
                        {
                            wordsToRemove.Add(args[i]);
                        }
                        Remove(listName, language, wordsToRemove.ToArray());
                    }
                    else
                    {
                        Console.WriteLine("     You entered no words to erase");
                    }
                }
                else
                {
                    Console.WriteLine("         You must enter a language and must a number");
                }
            }
            else
            {
                Console.WriteLine("     You must entered a list name !");

            }
        }
        else if (args.Length > 0 && args[0].ToLower() == "-words")
        {
            if (args.Length >= 2 && !string.IsNullOrWhiteSpace(args[1]) && !string.IsNullOrEmpty(args[1]))
            {
                var listName = args[1].ToLower();

                if (args.Length == 3 && args[2].All(char.IsDigit))
                {
                    var language = int.Parse(args[2]);

                    Words(listName, language);

                }
                else
                {
                    Console.WriteLine("     You must enter a language to sort for, and it has to be a number!\n".ToUpper());
                }
            }
            else
            {
                Console.WriteLine("     You must enter a list name!".ToUpper());

                var lists = WordList.GetLists();

                if (lists.Length != 0)
                {
                    Console.WriteLine("     You have the following options...".ToUpper());
                    foreach (var list in lists)
                    {
                        Console.WriteLine($"        {list}".ToUpper());
                    }
                }
            }
        }
        else if ( args.Length > 0  && args[0].ToLower() == "-count")
        {
            if (args.Length == 2 && !string.IsNullOrWhiteSpace(args[1]) && !string.IsNullOrEmpty(args[1]))
            {
                var listName = args[1].ToLower();

                Count(listName);
            }
            else
            {
                Console.WriteLine("     You must enter a list name!".ToUpper());

                var lists = WordList.GetLists();

                if (lists.Length != 0)
                {
                    Console.WriteLine("     You have the following options...".ToUpper());
                    foreach (var list in lists)
                    {
                        Console.WriteLine($"        {list}".ToUpper());
                    }
                }
            }
        }
        else if (args.Length > 0 &&  args[0].ToLower() == "-practice")
        {
            if (args.Length == 2 && !string.IsNullOrEmpty(args[1]) && !string.IsNullOrWhiteSpace(args[1]))
            {
                var listName = args[1].ToLower();

                Practice(listName);
            }
            else
            {
                Console.WriteLine("     You must enter a list name. You got the following lists\n".ToUpper());

                var lists = WordList.GetLists();
                if (lists.Length != 0)
                {
                    foreach (var lst in lists)
                    {
                        Console.WriteLine($"        {lst}".ToUpper());
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("     You must choose a choice from the following options.\n".ToUpper());
            Console.WriteLine("     You got the following options:");
            Console.WriteLine("     -lists");
            Console.WriteLine("     -new <list name> <language 1> <language 2> .. <langauge n> ");
            Console.WriteLine("     -add <list name>");
            Console.WriteLine("     -remove <list name> <language> <word 1> <word 2> .. <word n>");
            Console.WriteLine("     -words <listname> <sortByLanguage>");
            Console.WriteLine("     -count <listname>");
            Console.WriteLine("     -practice <listname>");

        }
    }
}

