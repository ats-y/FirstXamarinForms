# はじめてのXamarin.Forms

## はじめに

はじめてXamarin.Formsを触る人向けです。

プログラム基礎研修を修了した新入社員を対象としています。

とにかく動くアプリを作るという目的で、MicrosoftのXamarinページにあるチュートリアルを実施します。

各チュートリアルにサンプルコードと説明記載されているので、
サンプルコードを入力して、動かして、解説を読んで、入力したXMLやプログラムがどんな役割をしているのか理解してください。
サンプルコードのコピペは禁止です。
XMLやプログラムはどのように定義するのか、手入力しながら体験・理解してください。

サンプルには[アクセシビリティ識別子](https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/accessibility-levels)がついていません。業務プログラムはアクセシビリティ識別子を必ずつけることが慣例となっているので、どの識別子が適切か考えてつけてください。

1. サンプルを写経する
1. 動かしてみる
1. 動いたらコミット
1. 入力したXML・プログラムと説明を見返して、XML・プログラムのどの部分がどのような役割なのか理解する。
1. 理解できたら、その理解を確かめるために少し改造してみる。
1. コミット。

## Xamarin.Formsチュートリアル

https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/

### アプリのビルド
https://docs.microsoft.com/ja-jp/xamarin/get-started/first-app/

### StackLayout
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/stacklayout

### Label
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/label

### Button
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/button

イベントが登場します。

書き込む行が以下のうちのどれなのか意識して描いてください。
* クラスの定義
* メンバ変数（別名：属性、クラスメンバ変数）の定義
* メソッド（別名：操作、クラスメソッド、関数）の定義
* ローカル変数の定義
* 処理

### Entry
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/entry

デバック実行も体験。

### Editor
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/editor

### Image
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/image

### Grid
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/grid

Grid.Row、Grid.Column属性の既定値は0です。</br>
よって、Grid.Row、Grid.Column属性を省略した場合は、Grid.Row="0"、Row、Grid.Column="0"を定義した場合と同じ動きとなります。

Xamlを見た時にどのようにレイアウトされるのかがわかるようにGrid.Row、Grid.Column属性は明示的に定義したほうがよいです。

### ListView
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/listview

Bindingが登場します。

ItemSelectedイベントとItemTappedイベントのイベントハンドラでブレークポイントを貼ってデバッグ実行し、引数の中身をのぞいてみてください。

### ポップアップ
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/pop-ups

awaitが登場します。</br>
awaitを付けないとどうなるか試してみてください。

### アプリのライフサイクル
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/app-lifecycle

constが登場します。

設定要素名と定数名が同じなので注意。

### Web サービス
https://docs.microsoft.com/ja-jp/xamarin/get-started/tutorials/web-service

「APIキーにサインアップ」は行わず、教育担当に訊いてください。

Nugetが登場します。

名前空間が登場します。

Taskが登場します。

Try/Catchが登場します。
例外を起こしてみよう。
例外の型、メッセージ、スタックトレース、InnerExceptionを見てみよう。
何に利用できるか考えてみよう。

JSON

Binding
