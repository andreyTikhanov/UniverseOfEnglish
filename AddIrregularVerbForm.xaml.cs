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
    /// Логика взаимодействия для AddIrregularVerbForm.xaml
    /// </summary>
    public partial class AddIrregularVerbForm : Window
    {
        public AddIrregularVerbForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void btnSaveIrregular_Click(object sender, RoutedEventArgs e)
        {
            if (tbAddRussian.Text == "" && tbAddTheFirstForm.Text =="") return;
            IrregularVerb irregularVerb=new IrregularVerb();
            irregularVerb.Translation=tbAddRussian.Text;
            irregularVerb.BaseForm=tbAddTheFirstForm.Text;
            irregularVerb.PastSimple=tbAddTheSecondForm.Text;
            irregularVerb.PastParticiple=tbAddTheThirdForm.Text;
            if (MainWindow.IrregularVerbList == null)
            {
                MainWindow.IrregularVerbList = new List<IrregularVerb>();
                MainWindow.IrregularVerbList.Add(irregularVerb);
            }
            else
            {
                MainWindow.IrregularVerbList.Add (irregularVerb);
            }
            MainWindow.SaveListToJson(MainWindow.IrregularVerbList, MainWindow.pathIrregularVerb);
            tbAddRussian.Text = "";
            tbAddTheFirstForm.Text = "";
            tbAddTheSecondForm.Text = "";
            tbAddTheThirdForm.Text = "";

           
        }
    }
}
