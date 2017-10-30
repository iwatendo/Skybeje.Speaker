using System;
using System.Text;
using VoiceTextWebAPI.Client;

namespace Skybeje.Speaker.Contener
{

    /// <summary>
    /// 
    /// </summary>
    public class AITalkContener : VoiceContener
    {

        public static string VoiceTypeName = "AITalk";

        public string Speaker { get; set; }
        public int Volume { get; set; }
        public int Pitch { get; set; }
        public int Range { get; set; }
        public int Rate { get; set; }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AITalkContener()
        {
            this.VoiceType = VoiceTypeName;
        }



        /// <summary>
        /// 変換処理
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public string ToSSML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"<?xml version=""1.0"" encoding=""utf-8"" ?>");
            sb.Append(@"<speak version=""1.1"">");

            sb.AppendFormat("<voice name=\"{0}\">"
                , Speaker
            );

            sb.AppendFormat("<prosody pitch=\"{0}\" range=\"{1}\" rate=\"{2}\" volume=\"{3}\">"
                , (Pitch / 100.0).ToString("0.00")
                , (Range / 100.0).ToString("0.00")
                , (Rate / 100.0).ToString("0.00")
                , (Volume / 100.0).ToString("0.00")
            );

            sb.Append(GetVoiceMessageText());

            sb.Append(@"</prosody>");
            sb.Append(@"</voice>");
            sb.Append(@"</speak>");

            return sb.ToString();
        }

    }

}
