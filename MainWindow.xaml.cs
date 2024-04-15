using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace myEnglish_with_Button
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static void SaveListToJson<T>(List<T> list, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(list);
                File.WriteAllText(path, json);
            }
            catch (Exception ex) { }
        }
        public static List<T> LoadListFromJson<T>(string path)
        {

            try
            {
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
            catch (Exception ex)
            {
                return new List<T>();
            }

        }

        public static List<Noun>? NounList;
        public static List<Adjective>? AdjectiveList;
        public static List<PhraseVerb>? PhraseVerbList;
        public static List<RegularVerb>? RegularVerbList;
        public static List<IrregularVerb>? IrregularVerbList;

        public static string pathAdmin = "admin.txt";
        public static string pathNoun = "nouns.json";
        public static string pathAdjective = "adjective.json";
        public static string pathPhraseVerb = "phrase_verb.json";
        public static string pathRegularVerb = "regular_verb.json";
        public static string pathIrregularVerb = "irregular_verb.json";


        public string? Name = "";
        public MainWindow()
        {

            if (!File.Exists(pathAdmin))
            {
                Login login = new Login();
                login.ShowDialog();
            }
            LoadAdmin(pathAdmin);
            //comment
            InitializeComponent();
            tbName.Content = $"Привет, {Name}Что будем делать?";
            NounList = LoadListFromJson<Noun>(pathNoun);
            AdjectiveList =LoadListFromJson<Adjective>(pathAdjective);
            RegularVerbList=LoadListFromJson<RegularVerb>(pathRegularVerb);
            IrregularVerbList=LoadListFromJson<IrregularVerb>(pathIrregularVerb);





        }
        public void LoadAdmin(string path)
        {
            if (!File.Exists(path)) { return; }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string nameAdmin = sr.ReadToEnd();
                    Name = nameAdmin;
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок
            }
        }


        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAddWord_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            AddWordForm addWordForm = new AddWordForm();
            addWordForm.ShowDialog();
        }

        private void btnLookWord_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            ViewWordForm viewWordForm = new ViewWordForm();
            viewWordForm.ShowDialog();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            Visibility= Visibility.Hidden;
            ChangeForm changeForm = new ChangeForm();
            changeForm.ShowDialog();
        }

        private void btnDeleteWord_Click(object sender, RoutedEventArgs e)
        {
            Visibility= Visibility.Hidden ;
            DeleteWordsForm deleteWordsForm = new DeleteWordsForm();
            deleteWordsForm.ShowDialog();
        }
    }
}
