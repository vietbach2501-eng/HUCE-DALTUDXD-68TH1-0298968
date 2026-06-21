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

namespace HUCE_DALTUDXD_68TH1_0298968.View.UC_Ribbon
{
    /// <summary>
    /// Interaction logic for UC_Ribbon.xaml
    /// </summary>
    public partial class UC_Ribbon : UserControl
    {
        public UC_Ribbon()
        {
            InitializeComponent();
        }

      

       

        private void rbt_KetNoiEtabstabs_Click(object sender, RoutedEventArgs e)
        {
            KetNoiEtabs KetNoiEtabs= new KetNoiEtabs();
            KetNoiEtabs.ShowDialog();
        }

        private void Ribbon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
