namespace Träna_glosor_winForm
{
    public partial class ListsForm : Form
    {
        private WordList Listwords;
        public string[] lists { get; set; }

        public ListsForm()
        {
            InitializeComponent();
        }


        private void ListsForm_Load(object sender, EventArgs e)
        {
             lists = WordList.GetLists();

            if (lists.Length > 0 )
            {
                foreach (var list in lists)
                {
                    wordListBox.Items.Add(list);

                }
            }
            else
            {
                MessageBox.Show("There no list Available, You should create a new one!");
            }

        }

        private void wordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listName = wordListBox.SelectedItem.ToString();

            if (listName != "" && listName != null)
            {
                Listwords = WordList.LoadList(listName);

                numberOfWords.Text = Listwords.Words.Count().ToString();

                languageBox.Items.Clear();

                for (int i = 0; i < Listwords.Languages.Length; i++)
                {
                    languageBox.Items.Add(Listwords.Languages[i]);

                }

            }
          

        }

        private void Select_Click(object sender, EventArgs e)
        {
            WordListS wordList = new WordListS();
            
            if (Listwords != null)
            {
                Select.Enabled = true;
                wordList.ActiveList = Listwords;
                wordList.Show();
                this.Hide();
            }

        }

        private void NewList_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateListForm createListForm = new CreateListForm();
            createListForm.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
