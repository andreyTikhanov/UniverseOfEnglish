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
    /// Логика взаимодействия для ViewWordForm.xaml
    /// </summary>
    public partial class ViewWordForm : Window
    {
        
        public ViewWordForm()
        {
            InitializeComponent();
          
        }
       

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (tbRusianWord.Text == "") return;

            string englishTranslation = FindTranslation(tbRusianWord.Text);

            if (englishTranslation != null)
            {
                tbEnglishWord.Text = englishTranslation;
            }
            else
            {
                tbEnglishWord.Text = "Совпадение не найдено";
            }
        }
        private string FindTranslation(string russianWord)
        {
            var translation =
                (from noun in MainWindow.NounList
                 where noun.Translation == russianWord
                 select noun.Title).FirstOrDefault() ??
                (from adjective in MainWindow.AdjectiveList
                 where adjective.Translation == russianWord
                 select adjective.Title).FirstOrDefault() ??
                 (from regular in MainWindow.RegularVerbList
                  where regular.Translation == russianWord
                  select regular.Title).FirstOrDefault() ??
                  (from irregular in MainWindow.IrregularVerbList
                   where irregular.Translation == russianWord
                   select $"{irregular.BaseForm}, {irregular.PastSimple}, {irregular.PastParticiple}").FirstOrDefault();

            return translation ?? "Совпадений нет";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }
    }
}
