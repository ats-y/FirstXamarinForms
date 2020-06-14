# はじめてのXamarin.Forms

<!-- TOC -->

- [はじめてのXamarin.Forms](#はじめてのxamarinforms)
    - [はじめに](#はじめに)
    - [Xamarin.Formsチュートリアル](#xamarinformsチュートリアル)
        - [チュートリアル：アプリのビルド](#チュートリアルアプリのビルド)
        - [チュートリアル：StackLayout](#チュートリアルstacklayout)
        - [チュートリアル：Label](#チュートリアルlabel)
        - [チュートリアル：Button](#チュートリアルbutton)
        - [チュートリアル：Entry](#チュートリアルentry)
        - [チュートリアル：Editor](#チュートリアルeditor)
        - [チュートリアル：Image](#チュートリアルimage)
        - [チュートリアル：Grid](#チュートリアルgrid)
        - [チュートリアル：ListView](#チュートリアルlistview)
        - [チュートリアル：ポップアップ](#チュートリアルポップアップ)
        - [チュートリアル：アプリのライフサイクル](#チュートリアルアプリのライフサイクル)
        - [チュートリアル：Web サービス](#チュートリアルweb-サービス)
        - [チュートリアル:クイックスタート](#チュートリアルクイックスタート)
    - [おわりに](#おわりに)

<!-- /TOC -->

## はじめに

はじめてXamarin.Formsを触る人向けです。<br>
プログラム基礎研修を修了した新入社員を対象としています。

目的は、**Xamarin.Forms**という**Android/iOSアプリ作成フレームワーク**を利用した、基本的な画面への表示や入力に関するプログラムを体験し、それらの方法について理解することです。 <br>
「こうやったらこうなるんだな」「こうしたいときはこれだな」というのがわかってくれれば良いです。

Xamarin.Formsプログラムの体験は、MicosoftのXamarin.Forms公式ページのチュートリアルに合わせて行います。

https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/

各チュートリアルにサンプルコードと説明が記載されているので、
実際にサンプルコードを入力して、動かして、解説を読んで、入力したXMLやプログラムがどんな役割をしているのか理解してください。

サンプルコードのコピペは禁止です。<br>
XMLやプログラムはどのように定義するのか、手入力しながら体験・理解してください。

サンプルには[アクセシビリティ識別子](https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/accessibility-levels)がついていません。<br>業務プログラムはアクセシビリティ識別子は必須です。<br>どの識別子が適切か考えてつけてください。

## Xamarin.Formsチュートリアル

各チュートリアルごとに以下の手順を行なってください。

1. チュートリアルにしたがってプログラムを作成する（コピペ禁止）
1. 動かしてみる。
1. 動いたらコミット。
1. クラス、メンバ変数、メソッドにアクセシビリティ識別子をつけてみる。
1. 動かしてみる。
1. 動いたらコミット。
1. 入力したXML・プログラムと説明を見返して、XML・プログラムのどの部分がどのような役割なのか理解する。
1. 理解できたら、その理解を確かめるために少し改造してみる。
1. 動かしてみる。改造の意図通り動いているか確認する。
1. コミット。コミットコメントには改造した内容を描いてください。

### チュートリアル：アプリのビルド

https://docs.microsoft.com/ja-jp/xamarin/get-started/first-app/

Xamarin.Formsアプリのソリューションおよびプロジェクトの新規作成方法です。

### チュートリアル：StackLayout
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/stacklayout

### チュートリアル：Label
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/label

### チュートリアル：Button

https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/button

書き込む行が以下のうちのどれなのか意識して書いてください。
* クラスの定義
* メンバ変数（別名：属性、クラスメンバ変数）の定義
* メソッド（別名：操作、クラスメソッド、関数）の定義
* ローカル変数の定義
* 処理

イベントが登場します。<br>
イベントハンドラOnButtonClicked()にブレークポイントを設定し、引数の中身をみてどんな値が入っているか確認してください。

### チュートリアル：Entry

https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/entry

イベントハンドラにブレークポイントを設定し、引数の中身を確認してください。

### チュートリアル：Editor

https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/editor

イベントハンドラにブレークポイントを設定し、引数の中身を確認してください。

### チュートリアル：Image
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/image

### チュートリアル：Grid
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/grid

Grid.Row、Grid.Column属性の既定値（定義しなくてもそのように動作する値）は0です。</br>
よって、Grid.Row、Grid.Column属性を省略した場合は、Grid.Row="0"、Row、Grid.Column="0"を定義した場合と同じ動きとなります。

Xamlを見た時にどのようにレイアウトされるのかがわかるようにGrid.Row、Grid.Column属性は明示的に定義したほうがよいです。

### チュートリアル：ListView
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/listview

Bindingが登場します。

ItemSelectedイベントとItemTappedイベントのイベントハンドラでブレークポイントを貼ってデバッグ実行し、引数の中身をのぞいてみてください。

### チュートリアル：ポップアップ
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/pop-ups

awaitが登場します。</br>
awaitを付けている場合とつけない場合はではどうなるか、ステップ実行して試してみてください。

### チュートリアル：アプリのライフサイクル
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/app-lifecycle

constが登場します。<br>
設定要素名と定数名が同じなので注意。

### チュートリアル：Web サービス

**★おねがい★<br>「APIキーにサインアップ」は行わず、教育担当に訊いてください。**

https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/web-service

* Try/Catchが登場します。

    例外を起こしてみよう。<br>
    無線LANをOFFにして実行するとRestService.GetWeatherDataAsync()で例外が発生します。RestService.GetWeatherDataAsync()をステップ実行して、例外発生の挙動をみてください。

    catchステートメントに入ったら例外の型、メッセージ、スタックトレース、InnerExceptionを見てみよう。<br>
    何に利用できるか考えてみよう。

* 他、以下の新しいものが登場します。

    * Nuget
    * 名前空間
    * Task
    * JSON

### チュートリアル:クイックスタート

https://docs.microsoft.com/ja-jp/xamarin/get-started/quickstarts/

ここまでの総仕上げです。<br>
以下を順に実施し、簡単なメモアプリを作ります。

* [単一ページの Xamarin.Forms アプリケーションを作成する](https://docs.microsoft.com/ja-jp/xamarin/get-started/quickstarts/single-page)
* [Xamarin.Forms複数ページの アプリケーションでナビゲーションを実行する](https://docs.microsoft.com/ja-jp/xamarin/get-started/quickstarts/multi-page)
* [ローカルの SQLite.NET データベースにデータを格納する](https://docs.microsoft.com/ja-jp/xamarin/get-started/quickstarts/database)
* [クロスプラットフォーム Xamarin.Forms アプリケーションのスタイルを設定する](https://docs.microsoft.com/ja-jp/xamarin/get-started/quickstarts/styling)


最後の[DeepDrive](https://docs.microsoft.com/ja-jp/xamarin/get-started/quickstarts/deepdive)にXamarin.Formsアプリのしくみと基礎が記載されていますので、必ず読んでください。

## おわりに

おつかれさまでした。<br>
これでXamarin.FromsでAndroid/iOSアプリを作る最低限の知識が身についたと思います。

今回はネイティブアプリの作成でしたが、Webアプリや他のアプリでも必ずフレームワークを使います。

今後、新しいフレームワークを使う、または使用するプロジェクトに途中から参加する場合は、必ず次のことをしてください。

* **チュートリアルをやってみる**

    今回行なったチュートリアルのように、フレームワークのドキュメントにはチュートリアルがあります。

    チュートリアルにしたがって、実際に手を動かして動くものをつくってみます。

    見た目の挙動はもちろん、ステップ実行してプログラムの挙動（どんな順番で動くか、変数には何が入ってくるのか）を確認します。

    チュートリアルをやっておくことで最低限のやりかたがわかるので、プロジェクトに配属された時に「何もできずお手上げ」になることはなくなるでしょう。

* **公式ドキュメントを読む**

    Xamarin.Formsだと↓です。<br>
    https://docs.microsoft.com/ja-jp/xamarin/xamarin-forms/ <br>
    （[APIリファレンス](https://docs.microsoft.com/ja-jp/dotnet/api/?view=xamarin-forms)ではありません）

    目次としては https://docs.microsoft.com/ja-jp/xamarin/get-started/what-is-xamarin-forms の左側に表示されている内容です。

    
    全て一通り読んでください。

    ただし、全部理解する必要はありません。<br>
    大まかな仕組みと、どんな言葉があるか・なにがどこに書いてあるか、頭の中にインデックスを作っておくくらいでよいです。

    わからない言葉が出てきた時や、要件を実現したい時どうしたらよいかわからない時に、「あそこに書いてあったな」「あそこに書いてあったことを利用すればできそうだな」となって、解決の糸口になります。
