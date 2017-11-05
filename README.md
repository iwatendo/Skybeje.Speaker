## Skybeje.Speaker
* Skybeje.Speakerは音声合成API（[AITalk](http://www.ai-j.jp/cloud/webapi/)及び[VoiceText](http://voicetext.jp/)）を使用して、文章を音声に変換するWindowsアプリです。
* [Skybeje](https://github.com/iwatendo/skybeje)と連動させることができます。
* ![スクリーンショット](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_screenshot.png)

## 機能
* 音声パラメータを指定して音声合成できます。また、指定したスピーカーデバイスで再生させる事ができます。
* 17種類(AITalk 11種類 / VoiceText 6種類)の音声から選択できます。
* 一度に100文字まで文章を変換できます。
* クリップボード経由で音声パラメータや文章を指定し、音声合成させる事ができます。
* 仮想マイクデバイス(YAMAHA NETDUETTO等）を使用する事により、音声通話やライブ配信にも利用できます。
* Skybejeでは アクター/アイコンごとに音声パラメータの設定でき、チャットの発言を喋らせることができます。

## 注意事項
* AITalk及びVoiceTextの無料で利用できるバージョンのWebAPIは、基本的に商用利用や二次利用が禁止されています。
* このプログラムは、開発者向けの検証目的の為のアプリとして公開します。
* このアプリを利用する場合、それぞれのサービスのAPIの利用規約を必ず確認してください。

## ダウンロード
* [Skybeje.Speakerのダウンロード](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/Skybeje.Speaker.zip)
* ※WindowsFormアプリです。Windows10でのみ動作確認済です

## 使用方法
* 上記からダウンロードしたファイルを展開して、中にある Skybeje.Speaker.exe を実行します。
* AITalkまたはVoiceTextのAPIキーを取得して、APIキーを入力します。
* 音声パラメータを指定して「Sample Voice」ボタンを押すと、テキストの文章で音声合成できます。

## 音声合成のWebAPIについて
* __以下のページからAPIキーの申請ができます__
* [AITalk（docomo developer suppurt)](https://dev.smt.docomo.ne.jp/?p=docs.api.page&api_name=text_to_speech&p_name=api_1)
* [VoiceText](https://cloud.voicetext.jp/webapi)

## Skybejeとの連動
* 自身のチャット発言を、音声合成で喋らせる事ができます。（他のメンバーのチャット発言の読み上げはできません）
* Skybeje側でチャット発言時に音声合成パラメータをクリップボードにコピーします。このアプリ側でクリップボードを監視し、指定されたパラメータで音声合成をし再生します。（仮想マイクデバイスで再生することで、音声通話やライブ配信に利用できます）

## Skybejeとの連動させるための設定
* Skybejeの設定画面にて、Skybeje.Speakerとの連動設定を有効にします
* ![設定方法](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_setting.png)
* プロフィールのアイコン→「音声」のボタンにて、アイコンに対してのVoiceCodeを設定します。
* Skybeje.Speakerの AITalk / VoiceTextタブの一番下に表示されているJSONデータが VoiceCodeです。
* 設定した音声パラメータで喋らせることが可能です。
* ![パラメータ](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_voicecode.png)

## Skybejeで音声合成を音声ストリームに流す方法
* YAMAHAの[NETDUETTO β2](http://netduetto.net/download/)の仮想マイクドライバを使用します。
* NETDUETTOβ2をダウンロードしてインストールすると、Yamaha NETDUETTO Driverが登録されます。
* 音声合成の出力デバイスと、配信またはグループ通話機能のマイクデバイスにて、YAMAHA NETDUETTO Driverを選択することで、音声合成音をマイクに流すことができます。
* ![ドライバー](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_device.png)
* ただしデフォルト設定の場合、マイクに流れた音声は聞こえません。
* 音声を確認しながら使用したい場合は、YAMAHA NETDUETTO Driver の設定を変更してください。（下図右側の「このデバイスを聴く」にチェックをいれてください）
* ![サウンド設定](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_yamaha.png)

## 開発環境 / 検証環境
* Visual Studio 2017 Community
* Windows10 professional 64bit

## 使用したライブラリ
* [NAudio](https://naudio.codeplex.com/)
* [VoiceText WebAPI Client for .NET](https://github.com/jsakamoto/voicetext-webapi-client4net)
