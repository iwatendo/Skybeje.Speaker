namespace Skybeje.Speaker.Contener
{

    /// <summary>
    /// 
    /// </summary>
    public class VoiceContener
    {
        public static string DEFAULT_MESSGE = "{{Message}}";


        public string VoiceType { get; set; }
        public string Message { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public VoiceContener()
        {
            Message = VoiceContener.DEFAULT_MESSGE;
        }



        /// <summary>
        /// 音声変換用文字列
        /// </summary>
        public string GetVoiceMessageText()
        {
            var msg = Message.Trim();

            if (msg == VoiceContener.DEFAULT_MESSGE)
                return string.Empty;

            if (msg.Length > 100)
            {
                //  100文字を超える場合は省略する
                return msg.Substring(0, 97) + "以下略";
            }
            else
            {
                return msg;
            }
        }

    }

}
