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

namespace DanMuJi.Pages.Settings
{
    /// <summary>
    /// Interaction logic for DanMuSetting.xaml
    /// </summary>
    public partial class DanMuSetting : UserControl
    {
        public DanMuSetting()
        {
            InitializeComponent();
        }

        private void DanMuFieldComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            //DanMuFieldTextBlock.Text = item.Content.ToString();
        }
    }
}
