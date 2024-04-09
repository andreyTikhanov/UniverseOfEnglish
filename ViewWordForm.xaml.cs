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
            foreach (var word in NounList)
            {
                if (tbRusianWord.Text == word.Translation)
                {
                    tbEnglishWord.Text = word.Title;
                }
            }
        }
    }
}
