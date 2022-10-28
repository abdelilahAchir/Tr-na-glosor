using System.Data;

namespace Träna_glosor
{
    public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }


        private List<Word> _words = new List<Word>();

        public List<Word> Words => _words;


        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }
        public static string[] GetLists()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            DirectoryInfo directories = new DirectoryInfo(path);
            FileInfo[] files = directories.GetFiles("*.dat");
            List<string> filesNames = new List<string>();
            foreach (var file in files)
            {
                filesNames.Add(Path.GetFileNameWithoutExtension(file.Name).ToLower());
            }
            return filesNames.ToArray();
        }

        public static WordList LoadList(string name)
        {
            var listNames = GetLists();

            string searchedList = string.Empty;

            string languagesString = string.Empty;

            List<string> languagesList = new List<string>();

            List<string[]> translations = new List<string[]>();


            List<Word> words = new List<Word>();

            Random random = new Random();

            int fromLanguage = random.Next(0, translations.Count);

            int toLanguage = random.Next(0, translations.Count);

            foreach (var list in listNames)
            {
                if (name == list)
                {
                    searchedList = list;
                    break;
                }

            }

            if (searchedList != "")
            {
                var dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var path = Path.Combine($@"{dir}\{searchedList}.dat");
                using (StreamReader reader = new StreamReader(path))
                {
                    languagesString = reader.ReadLine().ToLower();

                    while (!reader.EndOfStream)
                    {
                        string translationsString = reader.ReadLine().ToLower();

                        if (translationsString != "")
                        {
                            translations.Add(translationsString.Split(';'));
                        }
                    }
                }
                if (languagesString != "")
                {
                    languagesList = languagesString.Split(';').ToList();
                }

                WordList wordList = new WordList(name, languagesList.ToArray());

                foreach (var translation in translations)
                {
                    while (fromLanguage == toLanguage)
                    {
                        fromLanguage = random.Next(0, translation.Length);
                        toLanguage = random.Next(0, translation.Length);
                    }
                    if (fromLanguage != toLanguage)
                    {
                        wordList._words.Add(new Word(fromLanguage, toLanguage, translation));
                    }
                }
                return wordList;
            }
            return null;
        }

        public void Add(params string[] translations)
        {
            if (translations.Length != Languages.Length)
            {
                throw new ArgumentException("The amount of translatiosn is wrong, Add as many tranlations as many languages there is!");
            }
            _words.Add(new Word(translations));
        }

        public bool Remove(int translation, string word)
        {
            bool removed = false;
            foreach (var wrd in _words)
            {
                if (wrd.Translations.Length - 1 >= translation)
                {
                    _words = _words.Where(w => w.Translations[translation] != word).ToList();
                    removed = true;
                }
                else
                {
                    Console.WriteLine($"        The index: {translation} of the language that you entered doesn't exist!".ToUpper());
                    Console.WriteLine("         You have the following options...".ToUpper());
                    for (int i = 0; i < Languages.Length; i++)
                    {
                        Console.WriteLine($"        {Languages[i]} have the following index {i}".ToUpper());
                    }

                    removed = false;

                    break;
                }

            }

            return removed;
        }


        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            _words = _words.OrderBy(w => w.Translations[sortByTranslation]).ToList();
            foreach (var word in _words)
            {
                showTranslations(word.Translations);
            }
        }

        public Word GetWordToPractice()
        {
            Random random = new Random();
            var rndWord = random.Next(0, _words.Count);
            var fromLanguage = random.Next(0, Languages.Length);
            var toLanguage = random.Next(0, Languages.Length);
            var word = _words[rndWord];
            Word wrd = new Word();
            while (fromLanguage == toLanguage)
            {
                fromLanguage = random.Next(0, Languages.Length);
                toLanguage = random.Next(0, Languages.Length);

            }

            if (fromLanguage != toLanguage)
            {
                wrd = new Word(fromLanguage, toLanguage, word.Translations);
            }
            return wrd;
        }
        public int Count()
        {
            var numberOFWords = (_words.Count() * Languages.Length);
            return numberOFWords;
        }
        public void Save()
        {
            var dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var path = Path.Combine($@"{dir}\{Name}.dat");
            using (StreamWriter stream = new StreamWriter(path))
            {
                var lng = String.Join(';', Languages);

                stream.WriteLine(lng);

                foreach (var word in _words)
                {
                    var tr = string.Join(';', word.Translations);

                    stream.WriteLine(tr);
                }
            }
        }

    }
}
