## Skybeje.Speaker
* Skybeje.Speakerは音声合成WebAPI（[AITalk](http://www.ai-j.jp/cloud/webapi/)及び[VoiceText](http://voicetext.jp/)）を使用して文章を音声に変換するWindowsアプリです。
* AITalkとVoiceText合わせて、17種類の音声の合成が可能です。
* また[Skybeje](https://github.com/iwatendo/skybeje)と連動させることができます。
* アクター / アイコンごとに音声パラメータを設定し、チャットの文章を喋らせることが可能です。
* ![スクリーンショット](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_screenshot.png)

## 機能
* 音声パラメータを指定して音声合成し、指定スピーカーで再生させる事ができます。
* １回に100文字まで変換できます。
* クリップボード経由でパラメータや文章を指定して、音声合成させる事ができます。
* 仮想マイクデバイス(YAMAHA NETDUETTO等）を使用する事により、音声通話やライブ配信にも利用できます。

## 使用方法
* AITalkまたはVoiceTextのAPIキーを取得し、APIキーを入力します。
* 音声パラメータを指定して「Sample Voice」ボタンを押すと、テキストの文章で音声合成されます。

## 音声合成のWebAPIについて
* __以下のページからAPIキーの申請ができます__
* [AITalk（docomo developer suppurt)](https://dev.smt.docomo.ne.jp/?p=docs.api.page&api_name=text_to_speech&p_name=api_1)
* [VoiceText](https://cloud.voicetext.jp/webapi)

## 注意事項
* __AITalk及びVoiceTextのWebAPIは、基本的に商用利用や二次利用が禁止されています。__
* __このアプリを利用する場合、必ずそれぞれのAPIの利用規約を確認してください。__

## Skybejeとの連動
* 自身のチャット発言を、音声合成で喋らせる事ができます。
* アクター / アイコン毎に音声パラメータの指定が可能です。
* 仮想マイクデバイスを利用することにより、グループ通話やライブ配信の音声として利用できます。
* 但し、他のメンバーのチャット発言の読み上げはできません。

## Skybejeとの連動させるための設定
* Skybejeの設定画面にて、Skybeje.Speakerとの連動設定を有効にします
* ![設定方法](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_setting.png)
* プロフィールのアイコン→「音声」のボタンにて、アイコンに対してのVoiceCodeを設定します。
* Skybeje.Speakerの AITalk / VoiceTextタブの一番下に表示されているJSONデータが VoiceCodeです。
* 設定した音声パラメータで喋らせることが可能です。
* ![パラメータ](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_voicecode.png)

## Skybejeで音声合成を音声ストリームに流す方法
* YAMAHAの[NETDUETTO β2](http://netduetto.net/download/)のデバイスドライバを利用する事で実現できます
* 上記のページから、NETDUETTOβ2をダウンロードし、インストールします。
* 音声合成の出力デバイスと、配信またはグループ通話機能のマイクデバイスにて、YAMAHA NETDUETTO Driverを選択します
* ![ドライバー](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_device.png)
* 自分のPC上でも音声合成した声を聴きたい場合は、サウンドドライバのプロパティの設定を変更してください。
* ※下図、右側の「このデバイスを聴く」にチェックをいれてください。
* ![サウンド設定](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_yamaha.png)

## 処理の概要
* Skybeje側は、アイコンに設定されたVoiceCodeの{{Message}}に文章を設定し、クリップボードにコピーします。
* Skybeje.Speakerはクリップボードを監視しています。
* クリップボードに VoiceCodeがコピーされたタイミングで、指定されたパラメータで音声合成します。
* Skybeje.Speaker側で、仮想マイクデバイスに音声を流します。
* Skybeje側で、上記を音声ストリームに流します。

## 開発環境 / 検証環境
* Visual Studio 2017 Community
* Windows10 professional 64bit

## 使用したライブラリ
* [NAudio](https://naudio.codeplex.com/)
* [VoiceText WebAPI Client for .NET](https://github.com/jsakamoto/voicetext-webapi-client4net)
