using System.Net.Http.Headers;
using System.Text;
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
        
         static void Print(string[] words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
        Action<string[]> ShowTranaslations = Print;
        var wordList = WordList.LoadList("Clohtes");
       // wordList.Add("hat","hatt","sombrero");
        wordList.GetWordToPractice();

        string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        // string[] files = Directory.GetFiles(path, "*.dat");
        DirectoryInfo directories = new DirectoryInfo(path);
        FileInfo[] files = directories.GetFiles("*.dat");
      

    }
    public static List<string> _lists()
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        DirectoryInfo directories = new DirectoryInfo(path);
        FileInfo[] files = directories.GetFiles("*.dat");
        List<string> filesNames = new List<string>();
        foreach (var file in files)
        {
            Console.WriteLine(Path.GetFileNameWithoutExtension(file.Name));
            filesNames.Add(Path.GetFileNameWithoutExtension(file.Name));
        }
        return filesNames;
    }

    public static void _new(string listName, params string[] language)
    {
        var dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        Console.WriteLine(dir);
        string path = Path.Combine( $@"{dir}\{listName}.dat");
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
        }
        else
        {
            using (StreamWriter stream = new StreamWriter(path, append: true))
            {

                string languages = string.Join(";", language);
                foreach (var lang in languages)
                {
                    stream.Write(lang);

                }
            }
        }
        _add(listName);
    }

    public static void _add(string name)
    {
        var listNames = _lists();
        string languages = String.Empty;
        string enteredWord = "0";
        List<string> enteredWords = new List<string>();
        List<string> languagesList = new List<string>();


        string path = SearchedList(name);

        using (FileStream fs = File.OpenRead(path))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b, 0, b.Length) > 0)
            {
                languages = File.ReadAllLines(path).First();
            }
        }
        //take away coma between words
        languagesList = languages.Split(';').ToList();

        //Get one words and its translation on each language

        for (int i = 0; i < languagesList.Count; i++)
        {
            Console.WriteLine($" Enter a word in the following language:    {languagesList[i].ToUpper()}");
            enteredWord = Console.ReadLine();
            if (enteredWord == "")
            {
                break;
            }
            else
            {
                enteredWords.Add(enteredWord);
            }
        }
    }

    public static void Remove(string listaName, string language, params string[] words)
    {
        string path = SearchedList(listaName);
        string languages = string.Empty;
        string Words = string.Empty;
        List<string> wordsToErase = words.ToList();
        List<string> wordsInFile = new List<string>();
        List<string> languagesList = new List<string>();
        List<string> wordz = new List<string>();

        int count = 0;
        string line;
        TextReader rdr = new StreamReader(path);
        while ((line = rdr.ReadLine()) != null)
        {
            count++;
        }
        rdr.Close();
        using (StreamReader reader = new StreamReader(path))
        {
            while (!reader.EndOfStream)
            {


                wordsInFile.Add(reader.ReadLine());
            }
            //example
            //str.ReadToEnd();

        }

        languagesList = wordsInFile[0].Split(';').ToList();
        //Find the language
        foreach (var lang in languagesList)
        {
            int i = 0;
            int x = 0;
            bool a = false;
            if (language.ToLower() == lang.ToLower())
            {
                //Remove the selected words from the file list
                for (x = 1; x < wordsInFile.Count; x++)
                {
                    wordz = wordsInFile[x].Split(';').ToList();

                    for (i = 0; i < wordsToErase.Count; i++)
                    {
                        if (wordz.Contains(wordsToErase[i]))
                        {
                            wordz.Remove(wordsToErase[i]);
                        }
                    }

                    string str = string.Empty;
                    //str += ";";
                    str += string.Join(";", wordz);
                    //str += ";";
                    //foreach (var w in wordz)
                    //{
                    //    str += w + ";" ;

                    //}

                    wordsInFile[x] = str;
                }

            }
        }
        using (StreamWriter stream = new StreamWriter(path))
        {

            foreach (var word in wordsInFile)
            {

                if (word != ";")
                {
                    stream.WriteLine(word);
                }

            }
        }
    }

    public static void Word(string listaName, string sortByLanguage = " ")
    {
        string list = SearchedList(listaName);
        List<string> wordsToSort = new List<string>();
        string raw = string.Empty;
        List<string> languagesList = new List<string>();
        using (StreamReader reader = new StreamReader(list))
        {
            while (!reader.EndOfStream)
            {
                raw = reader.ReadLine();
                wordsToSort.Add(raw);
            }
        }
        string languages = wordsToSort[0];
        languagesList = languages.Split(';').ToList();
        string firstLanguage = languagesList[0];
        if (sortByLanguage != " ")
        {
             var orderedList = wordsToSort.OrderBy(x => x.Length);
            foreach (var word in orderedList)
            {
                Console.WriteLine(word);
            }
        }
        else
        {
            var orderedList = wordsToSort.OrderBy(firstLanguage => firstLanguage.Length);
            foreach (var word in orderedList)
            {
                Console.WriteLine(word);
            }
        }
    }

    public static string SearchedList(string listName)
    {
        var listNames = _lists();

        string searchedList = string.Empty;

        foreach (var list in listNames)
        {
            if (listName == list)
            {
                searchedList = list;
            }
        }
        searchedList = $@"C:\Users\abdia\AppData\Local\{searchedList}.dat";
        return searchedList;
    }
}