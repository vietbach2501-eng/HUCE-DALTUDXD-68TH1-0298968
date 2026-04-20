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

namespace HUCE_DALTUDXD_68TH1_0298968.Views.UserControls
{
    /// <summary>
    /// Interaction logic for UC_Ribbon.xaml
    /// </summary>
    public partial class UC_Ribbon : UserControl
    {
        private Frame _mainframe;
        public UC_Ribbon(Frame mainFrame)
        {
            InitializeComponent();
            _mainframe= mainFrame;
        }

        private void btn_Material_Click(object sender, RoutedEventArgs e)
        {
            MaterialView materialView = new MaterialView();
            materialView.Show();
        }

        private void rbt_2Dplan_Click(object sender, RoutedEventArgs e)
        {
            _mainframe.Content = new Plan2DPage();
        }

        private void btn_heso_Click(object sender, RoutedEventArgs e)
        {
            Heso hesoView = new Heso();
            hesoView.Show();
        }
    }
}
