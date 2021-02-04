using Newtonsoft.Json;
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

            /*北海道・東北地方
            cbBox.Items.Add("北海道(札幌市)");
            cbBox.Items.Add("青森県(青森市)");
            cbBox.Items.Add("岩手県(盛岡市)");
            cbBox.Items.Add("宮城県(仙台市)");
            cbBox.Items.Add("秋田県(秋田市)");
            cbBox.Items.Add("山形県(山形市)");
            cbBox.Items.Add("福島県(福島市)");*/
            //関東地方
            //cbBox.Items.Add("茨城県(水戸市)");
            //cbBox.Items.Add("栃木県(宇都宮市)");
            cbBox.Items.Add("群馬県(前橋市)");
            //cbBox.Items.Add("埼玉県(さいたま市)");
            //cbBox.Items.Add("千葉県(千葉市)");
            //cbBox.Items.Add("東京都(新宿区)");
            //cbBox.Items.Add("神奈川県(横浜市)");
            /*中部地方
            cbBox.Items.Add("新潟県(新潟市)");
            cbBox.Items.Add("富山県(富山市)");
            cbBox.Items.Add("石川県(金沢市)");
            cbBox.Items.Add("福井県(福井市)");
            cbBox.Items.Add("山梨県(甲府市)");
            cbBox.Items.Add("長野県(長野市)");
            cbBox.Items.Add("岐阜県(岐阜市)");
            cbBox.Items.Add("静岡県(静岡市)");
            cbBox.Items.Add("愛知県(名古屋市)");
            //近畿地方
            cbBox.Items.Add("三重県(津市)");
            cbBox.Items.Add("滋賀県(大津市)");
            cbBox.Items.Add("京都府(京都市)");
            cbBox.Items.Add("大阪府(大阪市)");
            cbBox.Items.Add("兵庫県(神戸市)");
            cbBox.Items.Add("奈良県(奈良市)");
            cbBox.Items.Add("和歌山県(和歌山市)");
            //中国地方
            cbBox.Items.Add("鳥取県(鳥取市)");
            cbBox.Items.Add("島根県(松江市)");
            cbBox.Items.Add("岡山県(岡山市)");
            cbBox.Items.Add("広島県(広島市)");
            cbBox.Items.Add("山口県(山口市)");
            //四国地方
            cbBox.Items.Add("徳島県(徳島市)");
            cbBox.Items.Add("香川県(高松市)");
            cbBox.Items.Add("愛媛県(松山市)");
            cbBox.Items.Add("高知県(高知市)");
            //九州地方
            cbBox.Items.Add("福岡県(福岡市)");
            cbBox.Items.Add("佐賀県(佐賀市)");
            cbBox.Items.Add("長崎県(長崎市)");
            cbBox.Items.Add("大分県(大分市)");
            cbBox.Items.Add("熊本県(熊本市)");
            cbBox.Items.Add("宮崎県(宮崎市)");
            cbBox.Items.Add("鹿児島県(鹿児島市)");
            cbBox.Items.Add("沖縄県(那覇市)");*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var api = new OwmApi();

            //天気情報を取得
            var data = api.GetWeather();

            //var tenki = data;

 
            if (cbBox.SelectedItem == null)
            {
                MessageBox.Show("都道府県を選択してください");   
            }
            else
            {
                Result rs = new Result(cbBox.SelectedItem.ToString(),data);

                rs.Show();

                this.Close();
            }
        }
    }
}
