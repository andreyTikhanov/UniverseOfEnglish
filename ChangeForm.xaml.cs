using System.Windows;

namespace myEnglish_with_Button
{
    /// <summary>
    /// Логика взаимодействия для ChangeForm.xaml
    /// </summary>
    public partial class ChangeForm : Window
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {

            string russianWord = tbRussian.Text.Trim();
            if (string.IsNullOrEmpty(russianWord))
            {
                tbRussian.Text = "Введите слово";
                return;

            }
            string englishWord = tbEnglish.Text.Trim();
            if (Edit(russianWord, out englishWord))
            {
                UpdateWordInList(russianWord, tbEnglish.Text);
                tbRussian.Text = "";
                tbEnglish.Text = "Слово успешно сохранено";
            }
            else
            {
                tbEnglish.Text = "Слово не найдено";
            }
        }




        private bool Edit(string russianWord, out string check)
        {
            var nounToUpdate = MainWindow.NounList.FirstOrDefault(noun => noun.Translation == russianWord);
            if (nounToUpdate != null)
            {
                check = nounToUpdate.Translation;

                return true;
            }

            var adjectiveToUpdate = MainWindow.AdjectiveList.FirstOrDefault(adjective => adjective.Translation == russianWord);
            if (adjectiveToUpdate != null)
            {
                check = adjectiveToUpdate.Translation;
                return true;
            }

            var regularVerbToUpdate = MainWindow.RegularVerbList.FirstOrDefault(verb => verb.Translation == russianWord);
            if (regularVerbToUpdate != null)
            {
                check = regularVerbToUpdate.Translation;
                return true;
            }

            check = "";
            return false;
        }
        private bool CheckingWords(string russianWord, out string check)
        {
            var nounToUpdate = MainWindow.NounList.FirstOrDefault(noun => noun.Translation == russianWord);
            if (nounToUpdate != null)
            {
                check = nounToUpdate.Title;

                return true;
            }

            var adjectiveToUpdate = MainWindow.AdjectiveList.FirstOrDefault(adjective => adjective.Translation == russianWord);
            if (adjectiveToUpdate != null)
            {
                check = adjectiveToUpdate.Title;
                return true;
            }

            var regularVerbToUpdate = MainWindow.RegularVerbList.FirstOrDefault(verb => verb.Translation == russianWord);
            if (regularVerbToUpdate != null)
            {
                check = regularVerbToUpdate.Title;
                return true;
            }

            check = "";
            return false;
        }


        private void UpdateWordInList(string russianWord, string newEnglishTranslation)
        {

            var nounToUpdate = MainWindow.NounList.FirstOrDefault(noun => noun.Translation == russianWord);
            if (nounToUpdate != null)
            {
                nounToUpdate.Title = newEnglishTranslation;
                MainWindow.SaveListToJson(MainWindow.NounList, MainWindow.pathNoun);
                return;
            }

            var adjectiveToUpdate = MainWindow.AdjectiveList.FirstOrDefault(adjective => adjective.Translation == russianWord);
            if (adjectiveToUpdate != null)
            {
                adjectiveToUpdate.Title = newEnglishTranslation;
                MainWindow.SaveListToJson(MainWindow.AdjectiveList, MainWindow.pathAdjective);
                return;
            }

            var regularVerbToUpdate = MainWindow.RegularVerbList.FirstOrDefault(verb => verb.Translation == russianWord);
            if (regularVerbToUpdate != null)
            {
                regularVerbToUpdate.Title = newEnglishTranslation;
                MainWindow.SaveListToJson(MainWindow.RegularVerbList, MainWindow.pathRegularVerb);
                return;
            }

            var irregularVerbToUpdate = MainWindow.IrregularVerbList.FirstOrDefault(verb => verb.Translation == russianWord);
            if (irregularVerbToUpdate != null)
            {
                var forms = newEnglishTranslation.Split(',');
                if (forms.Length == 3)
                {
                    irregularVerbToUpdate.BaseForm = forms[0].Trim();
                    irregularVerbToUpdate.PastSimple = forms[1].Trim();
                    irregularVerbToUpdate.PastParticiple = forms[2].Trim();
                }
                return;
            }
        }


        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void btnCheckWord_Click(object sender, RoutedEventArgs e)
        {
            if (CheckingWords(tbRussian.Text, out string check))
            {
                tbEnglish.Text = check;
            }
        }

        private void btnIrregular_Click(object sender, RoutedEventArgs e)
        {
            Close();
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
        }
    }
}
