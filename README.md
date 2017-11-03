## Skybeje.Speaker
* Skybeje.Speakerは、Windows上で音声合成して再生させるアプリです。
* [AITalk](http://www.ai-j.jp/cloud/webapi/) または [VoiceText](http://voicetext.jp/)のWebAPIを利用して音声合成をします
* ![スクリーンショット](https://raw.githubusercontent.com/wiki/iwatendo/skybeje.speaker/images/ss_screenshot.png)
## 機能
* AITalk / VoiceText のWebAPIを使って音声合成し、Windows上で音声を再生します
* __但し、上記のWebAPIは基本的に商用利用や二次利用は禁止です。__ 使用する場合は利用規約を確認してください。
* 単独でも動作しますが、[Skybeje](https://github.com/iwatendo/skybeje) と連動させ、自分のチャット発言を喋らせることができます
* 仮想マイクデバイス(YAMAHA NETDUETTO等）を使用する事により、音声通話やライブ配信に利用できます

## 使用方法
* AITalkまたはVoiceTextのAPIキーを取得し、APIキーを設定します。
* 音声パラメータを設定し「サンプル再生ボタン」を押すと、サンプルテキストの内容で音声が再生されます。

## 音声合成のWebAPIについて（以下のリンクから、APIキーの申請ができます）
* [AITalk（docomo developer suppurt)](https://dev.smt.docomo.ne.jp/?p=docs.api.page&api_name=text_to_speech&p_name=api_1)
* [VoiceText](https://cloud.voicetext.jp/webapi)

## Skybejeとの連動
* 自分のチャットの発言を音声合成で喋らせる事ができます。
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

## 動作の概要
* Skybeje側は、アイコンに設定されたVoiceCodeに文章を設定してクリップボードにコピーします。
* Skybeje.Speakerはクリップボードを監視しています。
* クリップボードに VoiceCodeがコピーされたタイミングで、指定されたパラメータで音声合成。
* Skybeje.Speaker側で、仮想マイクデバイスに音声を流します。
* Skybeje側で、上記を音声ストリームに流します。

## 開発環境 / 検証環境
* Visual Studio 2017 Community
* Windows10 professional 64bit

## 使用ライブラリ
* [VoiceText WebAPI Client for .NET](https://github.com/jsakamoto/voicetext-webapi-client4net)
* [NAudio](https://naudio.codeplex.com/)
