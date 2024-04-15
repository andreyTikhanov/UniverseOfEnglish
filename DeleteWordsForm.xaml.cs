using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace myEnglish_with_Button
{
    /// <summary>
    /// Логика взаимодействия для DeleteWordsForm.xaml
    /// </summary>
    public partial class DeleteWordsForm : Window
    {
        public DeleteWordsForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (tbRussianWord.Text == "")
            {
                tbEnglishWord.Text = "Введите слово для проверки"; return;
            }
            if (CheckingWords(tbRussianWord.Text, out string check))
            {
                tbEnglishWord.Text = check;
            }
            else
            {
                tbEnglishWord.Text = "Слово не найдено";
            }
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (tbRussianWord.Text == "")
            {
                tbEnglishWord.Text = "Введите слово для удаления";
            }
            string englishWord = tbEnglishWord.Text.Trim();
            if (CheckingWords(tbRussianWord.Text, out englishWord))
            {
                DeleteWordInList(tbRussianWord.Text);
                tbRussianWord.Text = "";
                tbEnglishWord.Text = "Слово успешно удалено";
            }
            else
            {
                tbEnglishWord.Text = "Слово не найдено";
            }

        }
        private void DeleteWordInList(string russianWord)
        {

            var nounToUpdate = MainWindow.NounList.FirstOrDefault(noun => noun.Translation == russianWord);
            if (nounToUpdate != null)
            {
                MainWindow.NounList.Remove(nounToUpdate);
                MainWindow.SaveListToJson(MainWindow.NounList, MainWindow.pathNoun);
                return;
            }

            var adjectiveToUpdate = MainWindow.AdjectiveList.FirstOrDefault(adjective => adjective.Translation == russianWord);
            if (adjectiveToUpdate != null)
            {
                MainWindow.AdjectiveList.Remove(adjectiveToUpdate);
                MainWindow.SaveListToJson(MainWindow.AdjectiveList, MainWindow.pathAdjective);
                return;
            }

            var regularVerbToUpdate = MainWindow.RegularVerbList.FirstOrDefault(verb => verb.Translation == russianWord);
            if (regularVerbToUpdate != null)
            {
                MainWindow.RegularVerbList.Remove(regularVerbToUpdate);
                MainWindow.SaveListToJson(MainWindow.RegularVerbList, MainWindow.pathRegularVerb);
                return;
            }
        }
    }
}
