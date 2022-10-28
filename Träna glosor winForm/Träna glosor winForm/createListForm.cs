using System.Data;
using System.Windows.Forms.VisualStyles;

namespace Träna_glosor_winForm
{
    public partial class CreateListForm : Form
    {

        ListsForm listsForm = new ListsForm();

        public CreateListForm()
        {
            InitializeComponent();
        }

        public List<string> LanguagesList = new List<string>();

        private void createList_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(listNameBox.Text) && !string.IsNullOrWhiteSpace(listNameBox.Text) && 
                !string.IsNullOrEmpty(languagesBox.Text))
            {
                LanguagesList = languagesBox.Text.Split('\n', '\r').Where(l => l != "").ToList();
                //LanguagesList = LanguagesList.Where(l => l != "").ToList();

                if (LanguagesList.Count >= 2)
                {
                    WordList wordList = new WordList(listNameBox.Text, LanguagesList.ToArray());
                    wordList.Save();
                    listsForm.lists = WordList.GetLists();
                    MessageBox.Show($"Your list {listNameBox.Text} has been created!".ToUpper());

                    listsForm.Show();
                    listNameBox.Text = "";
                    languagesBox.Text = "";
                }
                else
                {
                    MessageBox.Show("You must enter 2 languages minimum".ToUpper());
                }
            }
            else
            {
                MessageBox.Show("You must enter a list name and 2 languages minimum".ToUpper());
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            listsForm.Show();
            this.Close();
        }
    }
}
