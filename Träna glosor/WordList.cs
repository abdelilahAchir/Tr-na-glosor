using System.Data;

namespace Träna_glosor
{
    public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }


        private List<Word> _words = new List<Word>();

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }
        public static string[] GetLists()
        {
            string path = @"C:\Users\abdia\AppData\Local";
            DirectoryInfo directories = new DirectoryInfo(path);
            FileInfo[] files = directories.GetFiles("*.dat");
            List<string> filesNames = new List<string>();
            foreach (var file in files)
            {
                filesNames.Add(Path.GetFileNameWithoutExtension(file.Name));
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

        public void Add(params string[] translations)
        {
            Random random = new Random();
            int fromLanguage = random.Next(0, translations.Length);
            int toLanguage = random.Next(0, translations.Length);

            
                if (translations.Length != Languages.Length)
                {
                    throw new ArgumentException("The amount of translatiosn is wrong, Add as many tranlations as many languages there is!");
                }
                else
                {
                    while (fromLanguage == toLanguage)
                    {
                        fromLanguage = random.Next(0, translations.Length);
                        toLanguage = random.Next(0, translations.Length);
                    }
                    if (fromLanguage != toLanguage)
                    {
                        _words.Add(new Word(fromLanguage, toLanguage, translations));
                    }     
            }
        }

        public bool Remove(int translation, string word)
        {
            bool removed = false;
            _words = _words.Where(w => w.Translations[translation] != word).ToList();
            removed = true;
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
            var word = _words[rndWord];
            return word;
        }
        public int Count()
        {
            var numberOFWords = (_words.Count() * Languages.Length) + Languages.Length;
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
