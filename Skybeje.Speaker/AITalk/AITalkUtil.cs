using Skybeje.Speaker.Util;
using System;
using System.IO;
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
                        // HTTPレスポンスボディの内容を.lpcmファイルとして書き出す
                        var msgResponseBody = asyncSendTask.Result.Content;
                        var stmResponseBody = msgResponseBody.ReadAsStreamAsync().GetAwaiter().GetResult();

                        var wavByte = ToWavStream(stmResponseBody);
                        DeviceUtil.PlaySound(wavByte, deviceIndex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //
                }
            }
        }



        /// <summary>
        /// 音声の再生
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="index"></param>
        public static byte[] ToWavStream(Stream stream)
        {
            using (BinaryReader reader = new BinaryReader(stream))
            {
                Byte[] lnByte = reader.ReadBytes((int)stream.Length);
                Byte[] wavByte = ConvertBytesEndian(lnByte);
                return wavByte;

            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static byte[] ConvertBytesEndian(byte[] bytes)
        {
            byte[] newBytes = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i += 2)
            {
                newBytes[i] = bytes[i + 1];
                newBytes[i + 1] = bytes[i];
            }
            // 44byte付加したnewBytes
            newBytes = AddWAVHeader(newBytes);
            return newBytes;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static byte[] AddWAVHeader(byte[] bytes)
        {
            byte[] header = new byte[44];
            long longSampleRate = 16000;
            int channels = 1;
            int bits = 16;
            long byteRate = longSampleRate * (bits / 2) * channels;
            long dataLength = bytes.Length;
            long totalDataLen = dataLength + 36;
            // 最終的なWAVファイルのバイナリ
            byte[] finalWAVBytes = new byte[bytes.Length + header.Length];
            int typeSize = System.Runtime.InteropServices.Marshal.SizeOf(bytes.GetType().GetElementType());

            header[0] = ConvertByte("R");
            header[1] = ConvertByte("I");
            header[2] = ConvertByte("F");
            header[3] = ConvertByte("F");
            header[4] = (byte)(totalDataLen & 0xff);
            header[5] = (byte)((totalDataLen >> 8) & 0xff);
            header[6] = (byte)((totalDataLen >> 16) & 0xff);
            header[7] = (byte)((totalDataLen >> 24) & 0xff);
            header[8] = ConvertByte("W");
            header[9] = ConvertByte("A");
            header[10] = ConvertByte("V");
            header[11] = ConvertByte("E");
            header[12] = ConvertByte("f");
            header[13] = ConvertByte("m");
            header[14] = ConvertByte("t");
            header[15] = ConvertByte(" ");
            header[16] = 16;
            header[17] = 0;
            header[18] = 0;
            header[19] = 0;
            header[20] = 1;
            header[21] = 0;
            header[22] = (byte)channels;
            header[23] = 0;
            header[24] = (byte)(longSampleRate & 0xff);
            header[25] = (byte)((longSampleRate >> 8) & 0xff);
            header[26] = (byte)((longSampleRate >> 16) & 0xff);
            header[27] = (byte)((longSampleRate >> 24) & 0xff);
            header[28] = (byte)(byteRate & 0xff);
            header[29] = (byte)((byteRate >> 8) & 0xff);
            header[30] = (byte)((byteRate >> 16) & 0xff);
            header[31] = (byte)((byteRate >> 24) & 0xff);
            header[32] = (byte)((bits / 8) * channels);
            header[33] = 0;
            header[34] = (byte)bits;
            header[35] = 0;
            header[36] = ConvertByte("d");
            header[37] = ConvertByte("a");
            header[38] = ConvertByte("t");
            header[39] = ConvertByte("a");
            header[40] = (byte)(dataLength & 0xff);
            header[41] = (byte)((dataLength >> 8) & 0xff);
            header[42] = (byte)((dataLength >> 16) & 0xff);
            header[43] = (byte)((dataLength >> 24) & 0xff);

            System.Buffer.BlockCopy(header, 0, finalWAVBytes, 0, header.Length * typeSize);
            System.Buffer.BlockCopy(bytes, 0, finalWAVBytes, header.Length * typeSize, bytes.Length * typeSize);

            return finalWAVBytes;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static byte ConvertByte(string str)
        {
            return Encoding.UTF8.GetBytes(str)[0];
        }

    }

}