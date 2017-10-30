using Newtonsoft.Json;
using Skybeje.Speaker.AITalk;
using Skybeje.Speaker.Contener;
using Skybeje.Speaker.Util;
using System;
using System.IO;
using System.Windows.Forms;
using VoiceTextWebAPI.Client;


namespace Skybeje.Speaker
{


    /// <summary>
    /// 
    /// </summary>
    public partial class MainForm : Form
    {
        //
        private bool _initialized = false;
        //
        private MyClipboardViewer _clipboardViewer;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            //  クリップボード監視用
            _clipboardViewer = new MyClipboardViewer(this);
            _clipboardViewer.ClipboardHandler += this.OnClipBoardChanged;

            InitializeComponent();
        }


        /// <summary>
        /// 初期化処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Initialize();
            InitializeAITalk();
            InitializeVT();

            _initialized = true;
            _AITalk_valueChanged(null, null);
            _VT_valueChanged(null, null);
        }

        #region 共通


        /// <summary>
        /// 初期化処理
        /// </summary>
        private void Initialize()
        {
            var index = 0;
            var initIndex = 0;

            //  出力デバイス一覧を表示
            foreach (string device in DeviceUtil.GetDevices())
            {
                comboBox_Device.Items.Add(device);

                //  Yamaha NETDUETTO Driver をある場合は、初期選択状態にする
                if (device.IndexOf(" NETDUETTO ") >= 0) initIndex = index;
                index++;
            }

            comboBox_Device.SelectedIndex = initIndex;
        }


        /// <summary>
        /// クリップボード変更時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnClipBoardChanged(object sender, ClipboardEventArgs args)
        {
            if (_initialized && checkBox_Clipboard.Checked)
            {
                try
                {
                    if (args.Text.IndexOf("VoiceType") < 0) return;
                    var vtype = JsonConvert.DeserializeObject<VoiceContener>(args.Text);

                    if (vtype.VoiceType == AITalkContener.VoiceTypeName)
                    {
                        var contener = JsonConvert.DeserializeObject<AITalkContener>(args.Text);
                        SpeechAITalk(contener);
                    }
                    else if (vtype.VoiceType == VoiceTextContener.VoiceTypeName)
                    {
                        var contener = JsonConvert.DeserializeObject<VoiceTextContener>(args.Text);
                        SpeechVoiceVT(contener);
                    }
                }
                catch (Exception)
                {
                    //  JSON変換時のエラーは処理しない
                }
            }
        }


        #endregion


        #region AITalk用イベント処理


        /// <summary>
        /// AITalk用のコンポーネント初期化処理
        /// </summary>
        private void InitializeAITalk()
        {
            textBox_AI_APIKey.Text = Properties.Settings.Default.AITalkAPIKey;

            InitilizeEnumComboAITalk(typeof(AITalk.Speaker), comboBox_AI_Speaker);

            InitilizeTrackBarAITalk(tracBar_AI_Volume, label_AI_VolumeValue);
            InitilizeTrackBarAITalk(tracBar_AI_Pitch, label_AI_PitchValue);
            InitilizeTrackBarAITalk(tracBar_AI_Range, label_AI_RangeValue);
            InitilizeTrackBarAITalk(tracBar_AI_Rate, label_AI_RateValue);
        }


        /// <summary>
        /// Enumコンボの初期化
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="enumType"></param>
        private void InitilizeEnumComboAITalk(Type enumType, ComboBox combo)
        {
            foreach (var speaker in Enum.GetValues(enumType))
            {
                combo.Items.Add(Enum.GetName(enumType, speaker));
            }
            combo.SelectedIndex = 0;
        }


        /// <summary>
        /// トラックバーの初期化
        /// </summary>
        /// <param name="trackBar"></param>
        /// <param name="label"></param>
        private void InitilizeTrackBarAITalk(TrackBar trackBar, Label label)
        {
            trackBar.ValueChanged += (sender, e) =>
            {
                label.Text = "(" + (trackBar.Value / 100.00).ToString("0.00") + ")";
            };
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _AITalk_valueChanged(object sender, EventArgs e)
        {
            if (_initialized)
            {
                var contener = ToAITalkContener();
                textBox_AI_VoiceCode.Text = JsonConvert.SerializeObject(contener);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private AITalkContener ToAITalkContener()
        {
            var result = new AITalkContener
            {
                Speaker = comboBox_AI_Speaker.SelectedItem.ToString(),
                Volume = tracBar_AI_Volume.Value,
                Pitch = tracBar_AI_Pitch.Value,
                Range = tracBar_AI_Range.Value,
                Rate = tracBar_AI_Rate.Value,
            };
            return result;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_AI_APIKey_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AITalkAPIKey = textBox_AI_APIKey.Text;
            Properties.Settings.Default.Save();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel_AI_HomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dev.smt.docomo.ne.jp/?p=docs.api.page&api_name=text_to_speech&p_name=api_1");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel_AI_HomePage_Kiyaku_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dev.smt.docomo.ne.jp/?p=docs.api.page&api_name=text_to_speech&p_name=guideline");
        }


        /// <summary>
        /// AITalkのサンプル再生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AI_SampleVoice_Click(object sender, EventArgs e)
        {
            var contener = ToAITalkContener();
            contener.Message = textBox_AI_SampleVoice.Text;

            SpeechAITalk(contener);
        }



        /// <summary>
        /// AITalkで音声合成してスピーカーに出力
        /// </summary>
        /// <param name="contener"></param>
        public void SpeechAITalk(AITalkContener contener)
        {

            var msg = contener.GetVoiceMessageText();

            if (string.IsNullOrEmpty(msg))
            {
                //  メッセージが設定されていない場合は何も処理しない
                return;
            }

            var apikey = textBox_AI_APIKey.Text;
            var deviceId = comboBox_Device.SelectedIndex;
            var ssml = contener.ToSSML();


            if (apikey.Length > 0)
            {
                AITalkUtil.Speech(apikey, ssml, deviceId);
            }
            else
            {
                //  APIキーが設定されていない場合は警告メッセージを出力
                MessageBox.Show("APIKeyを入力してください", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #endregion


        #region VoiceText用イベント処理


        /// <summary>
        /// VoiceText用のコンポーネント初期化
        /// </summary>
        private void InitializeVT()
        {
            textBox_VT_APIKey.Text = Properties.Settings.Default.VoiceTextAPIKey;

            InitilizeEnumComboVT(typeof(VoiceTextWebAPI.Client.Speaker), comboBox_VT_Speaker);
            InitilizeEnumComboVT(typeof(Emotion), comboBox_VT_Emotion);
            InitilizeEnumComboVT(typeof(EmotionLevel), comboBox_VT_EmotionLevel);

            InitilizeTrackBarVT(tracBar_VT_Volume, label_VT_VolumeValue);
            InitilizeTrackBarVT(tracBar_VT_Speed, label_VT_SpeedValue);
            InitilizeTrackBarVT(tracBar_VT_Pitch, label_VT_PitchValue);
        }


        /// <summary>
        /// Enumコンボの初期化
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="enumType"></param>
        private void InitilizeEnumComboVT(Type enumType, ComboBox combo)
        {
            foreach (var speaker in Enum.GetValues(enumType))
            {
                combo.Items.Add(Enum.GetName(enumType, speaker));
            }
            combo.SelectedIndex = 0;
        }


        /// <summary>
        /// トラックバーの初期化
        /// </summary>
        /// <param name="trackBar"></param>
        /// <param name="label"></param>
        private void InitilizeTrackBarVT(TrackBar trackBar, Label label)
        {
            trackBar.ValueChanged += (sender, e) =>
            {
                label.Text = "(" + trackBar.Value.ToString() + ")";
            };
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSampleVT_Click(object sender, EventArgs e)
        {
            var vtc = ToVoiceTextClient();
            var contener = new VoiceTextContener(vtc);
            contener.Message = textBox_VT_SampleVoice.Text;

            SpeechVoiceVT(contener);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        private async void SpeechVoiceVT(VoiceTextContener contener)
        {
            var msg = contener.GetVoiceMessageText();

            if (string.IsNullOrEmpty(msg))
            {
                return;
            }

            var apikey = textBox_VT_APIKey.Text;

            if (apikey.Length == 0)
            {
                //  APIキーが設定されていない場合は警告メッセージを出力
                MessageBox.Show("APIKeyを設定してください", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var vtc = contener.ToVoiceTextClient(apikey);

            try
            {
                //  指定デバイスの取得
                var device = comboBox_Device.SelectedIndex;

                //  VoiceTextから音声データを取得
                var bytes = await vtc.GetVoiceAsync(msg);
                Stream stream = new MemoryStream(bytes);

                //  再生処理
                DeviceUtil.PlaySound_VoiceText(stream, device);
            }
            catch (VoiceTextException vex)
            {
                MessageBox.Show(vex.Message, "VoceText Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private VoiceTextClient ToVoiceTextClient()
        {
            var result = new VoiceTextClient
            {
                APIKey = textBox_VT_APIKey.Text,
                Speaker = (VoiceTextWebAPI.Client.Speaker)Enum.Parse(typeof(VoiceTextWebAPI.Client.Speaker), comboBox_VT_Speaker.SelectedItem.ToString()),
                Emotion = (Emotion)Enum.Parse(typeof(Emotion), comboBox_VT_Emotion.SelectedItem.ToString()),
                EmotionLevel = (EmotionLevel)Enum.Parse(typeof(EmotionLevel), comboBox_VT_EmotionLevel.SelectedItem.ToString()),
                Volume = tracBar_VT_Volume.Value,
                Speed = tracBar_VT_Speed.Value,
                Pitch = tracBar_VT_Pitch.Value,
                Format = Format.WAV
            };

            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _VT_valueChanged(object sender, EventArgs e)
        {
            if (_initialized)
            {
                var vtc = ToVoiceTextClient();
                SetVoiceCode(vtc);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="vtc"></param>
        private void SetVoiceCode(VoiceTextClient vtc)
        {
            var contener = new VoiceTextContener(vtc);
            textBox_VT_VoiceCode.Text = JsonConvert.SerializeObject(contener);
        }


        /// <summary>
        /// APIキーの設定保持
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtAPIKey_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VoiceTextAPIKey = textBox_VT_APIKey.Text;
            Properties.Settings.Default.Save();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtVoiceCode_Click(object sender, EventArgs e)
        {
            textBox_VT_VoiceCode.SelectAll();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkVoiceText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cloud.voicetext.jp/webapi");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkKiyaku_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cloud.voicetext.jp/webapi/terms-of-service");
        }


        #endregion

    }

}
