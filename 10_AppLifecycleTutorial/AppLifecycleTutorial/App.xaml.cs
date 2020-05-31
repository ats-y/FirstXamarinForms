using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLifecycleTutorial
{
    public partial class App : Application
    {
        /// <summary>
        /// 表示テキスト内容を保存するアプリ設定要素のキー名称。
        /// </summary>
        const string keyOfDispTxt = "mySettingDispTxt";

        /// <summary>
        /// 表示テキスト内容
        /// </summary>
        public string DisplayText { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");

            // アプリの設定に「mySettingDispTxt」キーがあれば読み出す。
            if (Properties.ContainsKey(keyOfDispTxt))
            {
                DisplayText = (string)Properties[keyOfDispTxt];
            }
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");

            // アプリの設定に「mySettingDispTxt」キーの値として
            // DisplayTextの内容を保存する。
            Properties[keyOfDispTxt] = DisplayText;
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
        }
    }
}
