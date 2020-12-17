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

namespace 卒業制作_31062
{
    /// <summary>
    /// Select.xaml の相互作用ロジック
    /// </summary>
    public partial class Select : Window
    {
        public Select()
        {
            InitializeComponent();

            cbBox.Items.Add("北海道(札幌市)");
            cbBox.Items.Add("青森(青森市)");
            cbBox.Items.Add("岩手(盛岡市)");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (cbBox.SelectedItem == null)
            {
                MessageBox.Show("都道府県を選択してください");   
            }
            else
            {
                Result rs = new Result();
                rs.Show();
                this.Close();
            } 
        }
    }
}
