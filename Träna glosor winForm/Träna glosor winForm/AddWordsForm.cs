namespace Träna_glosor_winForm
{
    public partial class AddWordsForm : Form
    {
        //public string ActiveListName { get; set; }
        public WordList ActiveList { get; set; }
        public AddWordsForm()
        {
            InitializeComponent();
        }

        private void AddWordsForm_Load(object sender, EventArgs e)
        {
           // ActiveList = new WordList("miao", "english", "Swedish"); //WordList.LoadList(ActiveListName);

           this.Text = $"Add words to : {ActiveList.Name}".ToUpper();

            if (ActiveList != null)
            {
                dataGridAddWords.AllowUserToAddRows = false;

                if (ActiveList.Languages.Length > 1)
                {
                    dataGridAddWords.Columns.Add("", "");

                    foreach (var language in ActiveList.Languages)
                    {
                        var i = dataGridAddWords.Rows.Add(language);
                    }

                    dataGridAddWords.Columns.Add("", "");

                    for (int i = 0; i < dataGridAddWords.Rows.Count; i++)
                    {
                        dataGridAddWords.Rows[i].Cells[0].ReadOnly = true;
                    }

                    var rowsNumber = dataGridAddWords.Rows.Count;

                    List<string> words = new List<string>();

                    if (rowsNumber > 0)
                    {
                        for (int i = 0; i < rowsNumber; i++)
                        {
                            while ((dataGridAddWords.Rows[i].Cells[1].Value != null && string.IsNullOrWhiteSpace(dataGridAddWords.Rows[i].Cells[1].Value.ToString())))
                            {
                                AddWordsButton.Enabled = false;
                            }
                            AddWordsButton.Enabled = true;
                        }
                    }
                }
            }

        }

        private void AddWordsButton_Click(object sender, EventArgs e)
        {
            var rowsNumber = dataGridAddWords.Rows.Count;

            List<string> words = new List<string>();

            if (rowsNumber > 0)
            {
                for (int i = 0; i < rowsNumber; i++)
                {
                    if ((dataGridAddWords.Rows[i].Cells[1].Value != null) && !string.IsNullOrWhiteSpace(dataGridAddWords.Rows[i].Cells[1].Value.ToString()))
                    {
                        words.Add(dataGridAddWords.Rows[i].Cells[1].Value.ToString());
                    }
                }
                if (words.Count == rowsNumber)
                {
                    ActiveList.Add(words.ToArray());

                    MessageBox.Show($"The word was added!".ToUpper());

                    for (int i = 0; i < rowsNumber; i++)
                    {
                        if ((dataGridAddWords.Rows[i].Cells[1].Value != null) && !string.IsNullOrWhiteSpace(dataGridAddWords.Rows[i].Cells[1].Value.ToString()))
                        {
                            dataGridAddWords.Rows[i].Cells[1].Value = "";
                        }
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ActiveList.Save();
            WordListS wordList = new WordListS();
            wordList.ActiveList = ActiveList;
            this.Close();
            wordList.Show();
        }
    }
}
