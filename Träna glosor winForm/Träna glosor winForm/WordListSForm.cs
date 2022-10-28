using Träna_glosor;

namespace Träna_glosor_winForm
{
    public partial class WordListS : Form
    {
        public WordList ActiveList { get; set; }

        AddWordsForm addWordsForm = new AddWordsForm();

        ListsForm listsForm = new ListsForm();

        private int score = 0;

        private int guessedWords = 0;


        private Word word;
        public WordListS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                wordToTranslateLabel.Hide();
                translatedWordBox.Hide();
                scorePracticeLabel.Hide();
                restartPracticeButton.Hide();
                endPracticeButton.Hide();
                checkTranslationbutton.Hide();
            }

            dataGridView1.AllowUserToAddRows = false;

            this.Text = ActiveList.Name.ToUpper();

            foreach (var language in ActiveList.Languages)
            {

                dataGridView1.Columns.Add($"{language}", $"{language}");
            }

            foreach (var word in ActiveList.Words)
            {

                dataGridView1.Rows.Add(word.Translations);

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var numberOfCells = dataGridView1.Rows[0].Cells.Count;

                for (int j = 0; j < numberOfCells; j++)
                {
                    dataGridView1.Rows[i].Cells[j].ReadOnly = true;
                }
            }

            if (dataGridView1.Rows.Count <= 0)
            {
                removeWords.Enabled = false;
                practiceWords.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveList.Save();
            listsForm.Show();
            this.Close();
        }

        private void AddWord_Click(object sender, EventArgs e)
        {
            this.Close();
            addWordsForm.ActiveList = ActiveList;
            ActiveList.Save();
            addWordsForm.Show();
        }

        private void removeWords_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                removeWords.Enabled = false;
            }
            if (dataGridView1.Rows.Count > 0)
            {
                this.Text = ActiveList.Name.ToUpper();

                int columnindex = dataGridView1.CurrentCell.ColumnIndex;

                var wordToRemove = dataGridView1.CurrentCell.Value.ToString();

                ActiveList.Remove(columnindex, wordToRemove.ToString());

                dataGridView1.AllowUserToAddRows = false;

                DataGridViewRow row;

                int length;

                length = dataGridView1.SelectedRows.Count;

                if (length > 0)
                {
                    for (int i = length - 1; i >= 0; i--)
                    {
                        row = dataGridView1.SelectedRows[i];

                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
        }
        private void doneButton_Click(object sender, EventArgs e)
        {
            ActiveList.Save();
            listsForm.Show();
            this.Close();

        }
        private void practiceWords_Click(object sender, EventArgs e)
        {
            if (ActiveList.Count() > 0)
            {
                {
                    wordToTranslateLabel.Show();
                    translatedWordBox.Show();
                    scorePracticeLabel.Show();
                    restartPracticeButton.Show();
                    endPracticeButton.Show();
                    checkTranslationbutton.Show();
                    scorePracticeLabel.Location = new Point(160, 190);
                    wordToTranslateLabel.Location = new Point(160, 60);
                    dataGridView1.Hide();
                    removeWords.Hide();
                    AddWord.Hide();
                    practiceWords.Hide();
                    doneButton.Hide();
                }

                guessedWords = 0;
                score = 0;
                word = ActiveList.GetWordToPractice();

                wordToTranslateLabel.Text = $" Enter the trnslation of {word.Translations[word.FromLanguage]} from {ActiveList.Languages[word.FromLanguage]} to {ActiveList.Languages[word.ToLanguage]}".ToUpper();

                scorePracticeLabel.Text = $"You made {score} of {guessedWords} correct translations".ToUpper();

            }
        }

        private void endPracticeButton_Click(object sender, EventArgs e)
        {
            {
                wordToTranslateLabel.Hide();
                translatedWordBox.Hide();
                scorePracticeLabel.Hide();
                restartPracticeButton.Hide();
                endPracticeButton.Hide();
                checkTranslationbutton.Hide();
                dataGridView1.Show();
                removeWords.Show();
                AddWord.Show();
                practiceWords.Show();
                doneButton.Show();
            }

        }

        private void checkTranslationbutton_Click(object sender, EventArgs e)
        {
            guessedWords++;

            var userTranslation = translatedWordBox.Text;
            var correctTranslation = word.Translations[word.ToLanguage];


            if (!string.IsNullOrWhiteSpace(userTranslation) &&
                !string.IsNullOrWhiteSpace(correctTranslation) &&
                userTranslation.ToLower() == correctTranslation.ToLower())
            {
                word = ActiveList.GetWordToPractice();
                score++;
                scorePracticeLabel.Text = $"You made {score} of {guessedWords} correct translations".ToUpper();
                wordToTranslateLabel.Text = $" Enter the trnslation of {word.Translations[word.FromLanguage]} from {ActiveList.Languages[word.FromLanguage]} to {ActiveList.Languages[word.ToLanguage]}".ToUpper();
                translatedWordBox.Text = "";
            }
            else
            {
                word = ActiveList.GetWordToPractice();
                scorePracticeLabel.Text = $"You made {score} of {guessedWords} correct translations".ToUpper();
                wordToTranslateLabel.Text = $" Enter the trnslation of {word.Translations[word.FromLanguage]} from {ActiveList.Languages[word.FromLanguage]} to {ActiveList.Languages[word.ToLanguage]}".ToUpper();
                translatedWordBox.Text = "";

            }



        }

        private void restartPracticeButton_Click(object sender, EventArgs e)
        {
            score = 0;
            guessedWords = 0;
            word = ActiveList.GetWordToPractice();
            scorePracticeLabel.Text = $"You made {score} of {guessedWords} correct translations".ToUpper();
            wordToTranslateLabel.Text = $" Enter the trnslation of {word.Translations[word.FromLanguage]} from {ActiveList.Languages[word.FromLanguage]} to {ActiveList.Languages[word.ToLanguage]}".ToUpper();
            translatedWordBox.Text = "";
        }

        private void setActiveWordListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            listsForm.Show();
        }

        private void practiceModeMenu_Click(object sender, EventArgs e)
        {
            if (ActiveList.Count() > 0)
            {
                {
                    wordToTranslateLabel.Show();
                    translatedWordBox.Show();
                    scorePracticeLabel.Show();
                    restartPracticeButton.Show();
                    endPracticeButton.Show();
                    checkTranslationbutton.Show();
                    scorePracticeLabel.Location = new Point(160, 190);
                    wordToTranslateLabel.Location = new Point(160, 60);
                    dataGridView1.Hide();
                    removeWords.Hide();
                    AddWord.Hide();
                    practiceWords.Hide();
                    doneButton.Hide();
                }

                guessedWords = 0;
                score = 0;
                word = ActiveList.GetWordToPractice();

                wordToTranslateLabel.Text = $" Enter the trnslation of {word.Translations[word.FromLanguage]} from {ActiveList.Languages[word.FromLanguage]} to {ActiveList.Languages[word.ToLanguage]}".ToUpper();

                scorePracticeLabel.Text = $"You made {score} correct translations".ToUpper();

            }
        }
    }
}