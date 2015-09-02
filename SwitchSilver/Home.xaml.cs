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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SwitchSilver
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            
            //study4DataSet data = this.FindResource("study4DataSet") as study4DataSet;
            /*foreach (var x in this.Resources)
            {
                tbx.Text += x.ToString() + "\n";
            }*/

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var details = new Details((((Hyperlink)sender).DataContext) as SwitchSilver.study4DataSet.PapersRow);
            this.NavigationService.Navigate(details);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            study4DataSet papersDataSet = (study4DataSet)(this.FindResource("study4DataSet"));
            //this.Resources
            study4DataSetTableAdapters.PapersTableAdapter paperTableAdapter = new study4DataSetTableAdapters.PapersTableAdapter();
            paperTableAdapter.Fill(papersDataSet.Papers);
            CollectionViewSource paperViewSource = new CollectionViewSource();//(CollectionViewSource)(this.FindResource("papersViewSource"));
            paperViewSource.View.MoveCurrentToFirst();

            //cbx1.ItemsSource = papersDataSet.Papers;



            tbx.Text = Environment.UserName;
        }
    }
}
