using Träna_glosor;

internal class Program
{

    private static void Main(string[] args)
    {
        ConsoleKey consoleKey = ConsoleKey.F1;
        Console.WriteLine("     You got the following options:");

        Console.WriteLine("     -lists");
        Console.WriteLine("     -new <list name> <language 1> <language 2> .. <langauge n> ");
        Console.WriteLine("     -add <list name>");
        Console.WriteLine("     -remove <list name> <language> <word 1> <word 2> .. <word n>");
        Console.WriteLine("     -words <listname> <sortByLanguage>");
        Console.WriteLine("     -count <listname>");
        Console.WriteLine("     -practice <listname>");
        //Remove("Clohtes",1,"byxor","skjorta");

        //New("Forniture","swedish","english");

        //var wordList = WordList.LoadList("Clohtes");
        // wordList.Add("Hat".ToLower(),"haTT".ToLower(),"sombRerO".ToLower());
        //wordList.Count();
        // var w = wordList.GetWordToPractice();
        //var wow = WordList.LoadList("Clohtes");
        //wordList.List(1,ShowTranaslations);
        //string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //// string[] files = Directory.GetFiles(path, "*.dat");
        //DirectoryInfo directories = new DirectoryInfo(path);
        //FileInfo[] files = directories.GetFiles("*.dat");
        Add("Clohtes");

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
        Console.WriteLine(dir);
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
        var list = WordList.LoadList(listName);

        string enteredWord = "0";

        while (enteredWord != " " && enteredWord != "")
        {
            List<string> listOfWords = new List<string>();

            for (int i = 0; i < list.Languages.Length; i++)
            {
                Console.WriteLine($" Enter a word in the following language:    {list.Languages[i].ToUpper()}");
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

    }

    public static void Remove(string listName, int language, params string[] words)
    {


        var list = WordList.LoadList(listName);
        foreach (var word in words)
        {
            list.Remove(language, word);
        }
        //using (StreamReader reader = new StreamReader(path))
        //{
        //    while (!reader.EndOfStream)
        //    {


        //        wordsInFile.Add(reader.ReadLine());
        //    }
        //    //example
        //    //str.ReadToEnd();

        //}

        //languagesList = wordsInFile[0].Split(';').ToList();
        ////Find the language
        //foreach (var lang in languagesList)
        //{
        //    int i = 0;
        //    int x = 0;
        //    bool a = false;
        //    if (language.ToLower() == lang.ToLower())
        //    {
        //        //Remove the selected words from the file list
        //        for (x = 1; x < wordsInFile.Count; x++)
        //        {
        //            wordz = wordsInFile[x].Split(';').ToList();

        //            for (i = 0; i < wordsToErase.Count; i++)
        //            {
        //                if (wordz.Contains(wordsToErase[i]))
        //                {
        //                    wordz.Remove(wordsToErase[i]);
        //                }
        //            }

        //            string str = string.Empty;
        //            //str += ";";
        //            str += string.Join(";", wordz);
        //            //str += ";";
        //            //foreach (var w in wordz)
        //            //{
        //            //    str += w + ";" ;

        //            //}

        //            wordsInFile[x] = str;
        //        }

        //    }
        //}
        //using (StreamWriter stream = new StreamWriter(path))
        //{

        //    foreach (var word in wordsInFile)
        //    {

        //        if (word != ";")
        //        {
        //            stream.WriteLine(word);
        //        }

        //}
        //}
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

        if (list.Languages.Length - 1 < sortByLanguage)
        {
            list.List(sortByLanguage, showTranslations);
        }
        else
        {
            Console.WriteLine(      "There no language at the index that you entered!".ToUpper());
        }


        //List<string> wordsToSort = new List<string>();
        //string raw = string.Empty;
        //List<string> languagesList = new List<string>();
        //using (StreamReader reader = new StreamReader(list))
        //{
        //    while (!reader.EndOfStream)
        //    {
        //        raw = reader.ReadLine();
        //        wordsToSort.Add(raw);
        //    }
        //}
        //string languages = wordsToSort[0];
        //languagesList = languages.Split(';').ToList();
        //string firstLanguage = languagesList[0];
        //if (sortByLanguage != " ")
        //{
        //    var orderedList = wordsToSort.OrderBy(x => x.Length);
        //    foreach (var word in orderedList)
        //    {
        //        Console.WriteLine(word);
        //    }
        //}
        //else
        //{
        //    var orderedList = wordsToSort.OrderBy(firstLanguage => firstLanguage.Length);
        //    foreach (var word in orderedList)
        //    {
        //        Console.WriteLine(word);
        //    }
        //}
    }

    public static void Count(string listname)
    {
        var list = WordList.LoadList(listname);
        Console.WriteLine(list.Count());

    }

    public static void Practice(string listName)
    {
        var list = WordList.LoadList(listName);
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
        Console.WriteLine($"\n \n   The average correct translations was {correctTranslations} / {practicedWords.Count} with percentage of {percentage} %");
    }
    //public static string SearchedList(string listName)
    //{
    //    var listNames = WordList.GetLists();

    //    string searchedList = string.Empty;

    //    foreach (var list in listNames)
    //    {
    //        if (listName == list)
    //        {
    //            searchedList = list;
    //        }
    //    }
    //    searchedList = $@"C:\Users\abdia\AppData\Local\{searchedList}.dat";
    //    return searchedList;
    //}
}