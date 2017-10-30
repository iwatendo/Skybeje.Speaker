using System;
using VoiceTextWebAPI.Client;

namespace Skybeje.Speaker.Contener
{

    /// <summary>
    /// 
    /// </summary>
    public class VoiceTextContener : VoiceContener
    {

        public static string VoiceTypeName = "VoiceText";

        public string Speaker { get; set; }
        public string Emotion { get; set; }
        public string EmotionLevel { get; set; }
        public int Volume { get; set; }
        public int Speed { get; set; }
        public int Pitch { get; set; }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public VoiceTextContener()
        {
        }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vtc"></param>
        public VoiceTextContener(VoiceTextClient vtc)
        {
            this.VoiceType = VoiceTypeName;
            this.Speaker = vtc.Speaker.ToString();
            this.Emotion = vtc.Emotion.ToString();
            this.EmotionLevel = vtc.EmotionLevel.ToString();
            this.Volume = vtc.Volume;
            this.Speed = vtc.Speed;
            this.Pitch = vtc.Pitch;
        }



        /// <summary>
        /// 変換処理
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public VoiceTextClient ToVoiceTextClient(string apiKey)
        {
            var result = new VoiceTextClient();

            result.APIKey = apiKey;
            result.Speaker = (VoiceTextWebAPI.Client.Speaker)Enum.Parse(typeof(VoiceTextWebAPI.Client.Speaker), this.Speaker);
            result.Emotion = (Emotion)Enum.Parse(typeof(Emotion), this.Emotion);
            result.EmotionLevel = (EmotionLevel)Enum.Parse(typeof(EmotionLevel), this.EmotionLevel);
            result.Volume = this.Volume;
            result.Speed = this.Speed;
            result.Pitch = this.Pitch;
            result.Format = Format.WAV;

            return result;
        }

    }

}
