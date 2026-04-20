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
using HUCE_DALTUDXD_68TH1_0298968;
using HUCE_DALTUDXD_68TH1_0298968.Views.UserControls;

namespace HUCE_DALTUDXD_68TH1_0298968.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new HomePage();

            UC_Ribbon uC_Ribbon=new UC_Ribbon(MainFrame);
            Plan0.Children.Add(uC_Ribbon);
        }
    }
}
