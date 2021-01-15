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
    /// Result.xaml の相互作用ロジック
    /// </summary>
    public partial class Result : Window
    {
        string SelectedPref { get; set; }    //選択されている都道府県

        public Result(string pref)
        {
            InitializeComponent();
            SelectedPref = pref;
            tbPrefecture.Text = SelectedPref;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void btBackSelect_Click(object sender, RoutedEventArgs e)
        {
            Select sl = new Select();
            sl.Show();
            this.Close();
        }
    }
}
