# ZoomMuter
<h2>ビデオ会議のための音声＆カメラミュートツール</h2>

![ZoomMuter](https://raw.githubusercontent.com/taksas/ZoomMuter/master/HelpResources/ZoomMuterMuted.png)　![ZoomMuter](https://raw.githubusercontent.com/taksas/ZoomMuter/master/HelpResources/ZoomMuterMuted2.png) ![ZoomMuter](https://raw.githubusercontent.com/taksas/ZoomMuter/master/HelpResources/ZoomMuterMuted4.png)　![ZoomMuter](https://raw.githubusercontent.com/taksas/ZoomMuter/master/HelpResources/ZoomMuterMuted3.png)
ZoomMuterはZoom会議におけるマイク＆カメラコントロールを簡便化するために開発しました。
それぞれのミュート状態を分かりやすく表示し、（例えZoomのウインドウが最小化されていようと）ワンタップでミュート＆ミュート解除操作が可能です。
<br>
Zoomはマイク、カメラのミュート状態を他アプリが取得するための機能を用意していません。その為、このアプリを使用するときはいくつかの注意点に留意してください。
<br>
<br>
・ZoomMuterとZoomを起動するたび、ミュート表示を同期させること
<br>
・ホストからの強制ミュートなど、このアプリ以外からのミュート操作があった場合、再度ミュート表示を同期させること
<br>
・**初期セットアップなしではこのアプリは全く動かないこと**
<br>
・Zoomのアップデートによってこのアプリが動かなくなる可能性があるということ
<h1>ダウンロード</h1>
ダウンロード及びアップデートは以下から可能です。

[GitHhb上でリリースを見る](https://github.com/taksas/ZoomMuter/tags)

<h1>初期セットアップ</h1>
ZoomMuterの圧縮ファイルを解凍し、「ZoomMuter」又は「ZoomMuter.exe」をダブルクリックします。

<h2>.NET Coreのインストール</h2>

![netCoreダイアログ](https://raw.githubusercontent.com/taksas/ZoomMuter/master/HelpResources/netcore_dialog.png)

初回起動時はエラーメッセージが表示されますが、これはPC内にZoomMuterの実行に必要なソフトウェアフレームワークがインストールされていない為です。
<br>
「はい」をクリックしてください。

![netCoreダイアログ](https://raw.githubusercontent.com/taksas/ZoomMuter/master/HelpResources/netcore_web.png)

ZoomMuterの起動に必要な「Microsoft .NET Core」のダウンロードページがブラウザで開きます。
<br>
「Run desktop apps」の「Download x64」をクリックすることで、フレームワークのダウンロードが行われます。
<br>
フレームワークのインストール後、「ZoomMuter」又は「ZoomMuter.exe」を再度ダブルクリックしてください。
<br>
ZoomMuterが正常に起動します。

<h2>Zoom側の設定</h2>
ZoomMuterの使用前に、Zoomアプリケーションでショートカットキーの設定が必要です。
<br>

![Zoomの設定ウインドウ](https://raw.githubusercontent.com/taksas/ZoomMuter/master/HelpResources/ZoomInitialize.png)
<br>
[設定]→[キーボードショートカット]から、「自分のオーディオをミュート/ミュート解除」の項目を見つけ出し、そのショートカットを「ALT+A」から「F1」へと変更してください。
<br>
同様にして、「ビデオを開始/停止」を「ALT+V」から「F2」へと変更してください。
<br>
<br>
この設定はZoomをインストールしているPC間で同期されません。複数のPCでZoomMuterを使用したい場合はそれぞれのPC上で初期セットアップが必要です。

<h1>ZoomMuterとZoomのミュート表示を同期させる</h1>

ZoomMuterからミュート操作をしたときは、ミュートの状態表示がZoomMuterとZoom間で同期されます。
<br>
しかし、Zoomからミュート操作をしたときは**ミュートの状態表示はZoomMuterとZoom間で同期されません。**
<br>
そのため、Zoom上ではマイクがミュート表示になっているが、ZoomMuter上ではそうではないという現象がよく起こります。
<br>
**これはZoom側からミュート操作をした場合は必ず起こる現象です。**
<br>
ZoomMuter使用中はZoomからミュート操作をしないでください。
<br>
**もしZoomMuterとZoomのミュート表示がずれている場合は、Zoomからミュート操作をしてZoomMuterの画面表示に合わせてください。**

![ZoomMuter](https://raw.githubusercontent.com/taksas/ZoomMuter/master/HelpResources/OK.png)　![ZoomMuter](https://raw.githubusercontent.com/taksas/ZoomMuter/master/HelpResources/NG.png)