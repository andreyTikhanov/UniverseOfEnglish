using System.IO;
using System.Windows;
using System.Xml;
using Newtonsoft.Json;

namespace myEnglish_with_Button
{
    /// <summary>
    /// Логика взаимодействия для AddWordForm.xaml
    /// </summary>
    public partial class AddWordForm : Window
    {
        public AddWordForm()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void btnNoun_Click(object sender, RoutedEventArgs e)
        {
            if (tbAddEnglish.Text == "" && tbAddRussian.Text == "") return;
            Noun noun = new Noun();
            noun.Title = tbAddEnglish.Text;
            noun.Translation = tbAddRussian.Text;

            if (MainWindow.NounList == null)
            {
                MainWindow.NounList = new List<Noun>();
                MainWindow.NounList.Add(noun);
            }
            else
            {
                MainWindow.NounList.Add(noun);

            }
            MainWindow.SaveListToJson(MainWindow.NounList, MainWindow.pathNoun);
            tbAddEnglish.Text = "";
            tbAddRussian.Text = "";


        }
        private void btnAdjective_Click(object sender, RoutedEventArgs e)
        {
            if (tbAddEnglish.Text == "" && tbAddRussian.Text == "") return;
            Adjective adjective = new Adjective();
            adjective.Title = tbAddEnglish.Text;
            adjective.Translation = tbAddRussian.Text;

            if (MainWindow.AdjectiveList == null)
            {
                MainWindow.AdjectiveList = new List<Adjective>();
                MainWindow.AdjectiveList.Add(adjective);
            }
            else
            {
                MainWindow.AdjectiveList.Add(adjective);

            }
            MainWindow.SaveListToJson(MainWindow.AdjectiveList, MainWindow.pathAdjective);
            tbAddEnglish.Text = "";
            tbAddRussian.Text = "";

        }

        private void btnPhraseVerb_Click(object sender, RoutedEventArgs e)
        {
            if (tbAddEnglish.Text == "" && tbAddRussian.Text == "") return;
            PhraseVerb phraseVerb = new PhraseVerb();
            phraseVerb.Title = tbAddEnglish.Text;
            phraseVerb.Translation = tbAddRussian.Text;

            if (MainWindow.PhraseVerbList == null)
            {
                MainWindow.PhraseVerbList = new List<PhraseVerb>();
                MainWindow.PhraseVerbList.Add(phraseVerb);
            }
            else
            {
                MainWindow.PhraseVerbList.Add(phraseVerb);

            }
            MainWindow.SaveListToJson(MainWindow.PhraseVerbList, MainWindow.pathPhraseVerb);
            tbAddEnglish.Text = "";
            tbAddRussian.Text = "";
        }

        private void btnRegularVerb_Click(object sender, RoutedEventArgs e)
        {
            if (tbAddEnglish.Text == "" && tbAddRussian.Text == "") return;
            RegularVerb regularVerb = new RegularVerb();
            regularVerb.Title = tbAddEnglish.Text;
            regularVerb.Translation = tbAddRussian.Text;

            if (MainWindow.RegularVerbList == null)
            {
                MainWindow.RegularVerbList = new List<RegularVerb>();
                MainWindow.RegularVerbList.Add(regularVerb);
            }
            else
            {
                MainWindow.RegularVerbList.Add(regularVerb);

            }
            MainWindow.SaveListToJson(MainWindow.RegularVerbList, MainWindow.pathRegularVerb);
            tbAddEnglish.Text = "";
            tbAddRussian.Text = "";
        }

        private void btnIrregularVerb_Click(object sender, RoutedEventArgs e)
        {
            Close();
            AddIrregularVerbForm addIrregularVerbForm = new AddIrregularVerbForm();
            addIrregularVerbForm.ShowDialog();
        }
    }
   
}
