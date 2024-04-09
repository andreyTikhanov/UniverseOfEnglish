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

        private void btnSave_Click(object sender, RoutedEventArgs e)
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
                SaveToJson(MainWindow.pathNoun);
            tbAddEnglish.Text = "";
            tbAddRussian.Text = "";


        }


        public void SaveToJson(string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(MainWindow.NounList);
                File.WriteAllText(path, json);
            }
            catch (Exception ex) { }
        }

    }
}
