using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// カウンターの数値を格納するメンバ変数。
        /// </summary>
        private int _count = 0;

        void Button_Clicked(object sender, System.EventArgs e)
        {
            // カウンターをインクリメント（1を足す）
            _count = _count + 1;

            // 表示する文字列を作成する。
            string displayText = string.Format("You clicked {0} times.", _count);

            // 作成した文字列をボタンのキャプションに表示する。
            Button myButton = (Button)sender;
            myButton.Text = displayText;
        }
    }
}
