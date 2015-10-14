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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Details : Page
    {
        public Details(SwitchSilver.study4DataSet.PapersRow paper, Frame frame)
        {
            InitializeComponent();
            this.DataContext = paper;
            btnHome.Click += (s, e) => frame.Visibility = Visibility.Hidden;
        }

    }
}
