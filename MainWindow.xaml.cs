using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Noun>? NounList;
        public static string pathAdmin = "admin.txt";
        public static string pathNoun = "nouns.json";
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
            Visibility= Visibility.Hidden;
            ViewWordForm viewWordForm = new ViewWordForm();
            viewWordForm.ShowDialog();
        }
    }
}
