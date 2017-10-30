using Skybeje.Speaker.Util;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;


namespace Skybeje.Speaker.AITalk
{

    /// <summary>
    /// AITalkの音声合成用Util
    /// </summary>
    /// <remarks>
    /// Special thanks: 参考にさせて頂いたページ
    /// https://qiita.com/kanatano_mirai/items/677fde8589a4d810329a
    /// http://www.atmarkit.co.jp/ait/articles/1706/23/news026_3.html
    /// </remarks>
    public static class AITalkUtil
    {
        private static string _apiEndPointURL = "https://api.apigw.smt.docomo.ne.jp/aiTalk/v1/textToSpeech?APIKEY=";
        private static string _apiContentType = "application/ssml+xml";
        private static string _apiAccept = "audio/L16";
        private static HttpMethod _apiMethod = HttpMethod.Post;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="apikey"></param>
        /// <param name="ssml"></param>
        /// <param name="deviceIndex"></param>
        public static void Speech(string apikey, string ssml, int deviceIndex)
        {
            var sbResponseHeaders = new StringBuilder();    // HTTPレスポンスヘッダの結果情報
            var isSuccessResponse = false;                  // 最後にまとめて情報出力するためのフラグ

            // .NET Coreのコンソールアプリでは日本語の文字列出力が文字化けしてしまう問題がある。
            // この問題を回避するために、Encoding～で始まる以下の1行を追加している。
            // 事前に、NuGetで「System.Text.Encoding.CodePages」をインストールしておく必要がある
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // REST APIリクエストボディ送信用にバイト配列データを作成

            byte[] bytesBySSML = Encoding.UTF8.GetBytes(ssml);

            using (HttpClient client = new HttpClient())
            {
                // HTTPメソッド／エンドポイントURL／［APIKEY］
                var request = new HttpRequestMessage(_apiMethod, _apiEndPointURL + apikey);

                // HTTPリクエストボディ
                request.Content = new ByteArrayContent(bytesBySSML);

                // HTTPリクエストヘッダ： ［Content-Type］／［Accept］
                request.Content.Headers.ContentType = new MediaTypeHeaderValue(_apiContentType);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(_apiAccept));
                // ［Content-Length］： （※ HTTPリクエストボディのバイトサイズは自動計算）

                try
                {
                    // REST APIの呼び出し
                    var asyncSendTask = client.SendAsync(request);
                    asyncSendTask.Wait();

                    // HTTPレスポンスヘッダ情報を全て取得する
                    sbResponseHeaders.AppendLine($"HTTP-Status-Code: {asyncSendTask.Result.StatusCode}");
                    foreach (var headerItem in asyncSendTask.Result.Headers)
                    {
                        var headkey = headerItem.Key;
                        var headValue = String.Join(",", headerItem.Value);
                        sbResponseHeaders.AppendLine($"{headkey}: {headValue}");
                    }

                    if (asyncSendTask.Result.StatusCode == HttpStatusCode.OK)
                    {
                        isSuccessResponse = true;

                        // HTTPレスポンスボディの内容を.lpcmファイルとして書き出す
                        var msgResponseBody = asyncSendTask.Result.Content;
                        var stmResponseBody = msgResponseBody.ReadAsStreamAsync().GetAwaiter().GetResult();

                        //  音声再生処理
                        DeviceUtil.PlaySound_AITalk(stmResponseBody, deviceIndex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (isSuccessResponse)
                    {
                        //  処理成功
                    }
                    else
                    {

                    }
                }
            }
        }

    }
}