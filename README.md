## Skybeje.Speaker
* Skybeje.Speakerは、Windows上で音声合成して再生させるアプリです。
* [AITalk](http://www.ai-j.jp/cloud/webapi/) または [VoiceText](http://voicetext.jp/)のWebAPIを利用して音声合成をします
## 機能
* AITalk / VoiceText のWebAPIを使って音声合成し、Windows上で音声を再生します
* __但し、上記のWebAPIは基本的に商用利用や二次利用は禁止です。__ 使用する場合は利用規約を確認してください。
* 単独でも動作しますが、[Skybeje](https://github.com/iwatendo/skybeje) と連動させ、自分のチャット発言を喋らせることができます
* 仮想マイクデバイス(YAMAHA NETDUETTO等）を使用する事により、音声通話やライブ配信に利用できます

## 使用方法
* AITalkまたはVoiceTextのAPIキーを取得し、APIキーを設定します。
* 音声パラメータを設定して「サンプル再生ボタン」を押すと音声合成された声が再生されます。
* [AITalkのWabAPI（docomo developer suppurt)](https://dev.smt.docomo.ne.jp/?p=docs.api.page&api_name=text_to_speech&p_name=api_1)
* [VoiceTextのWebAPI](https://cloud.voicetext.jp/webapi)

## Skybejeとの連動設定
* 自分のチャットの発言を音声合成で喋らせる事ができます。（現状、他の人のチャット発言の読み上げはできません）
* 設定方法

## 使用API / ライブラリ
* [AITalk（docomo developer suppurt)](https://dev.smt.docomo.ne.jp/?p=docs.api.page&api_name=text_to_speech&p_name=api_1)
* [VoiceText](https://cloud.voicetext.jp/webapi)
* [VoiceText WebAPI Client for .NET](https://github.com/jsakamoto/voicetext-webapi-client4net)
* [NAudio](https://naudio.codeplex.com/)

## 開発環境 / 検証環境
* Visual Studio 2017 Community
* Windows10 professional 64bit
