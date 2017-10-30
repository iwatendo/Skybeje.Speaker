namespace Skybeje.Speaker
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox_Clipboard = new System.Windows.Forms.CheckBox();
            this.comboBox_Device = new System.Windows.Forms.ComboBox();
            this.label_Audio = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grouBox_AI_VoiceCode = new System.Windows.Forms.GroupBox();
            this.textBox_AI_VoiceCode = new System.Windows.Forms.TextBox();
            this.groupBox_AI_VoiceCodeSetting = new System.Windows.Forms.GroupBox();
            this.label_AI_VolumeValue = new System.Windows.Forms.Label();
            this.label_AI_Volume = new System.Windows.Forms.Label();
            this.tracBar_AI_Volume = new System.Windows.Forms.TrackBar();
            this.button_AI_SampleVoice = new System.Windows.Forms.Button();
            this.label_AI_RateValue = new System.Windows.Forms.Label();
            this.label_AI_Rate = new System.Windows.Forms.Label();
            this.tracBar_AI_Rate = new System.Windows.Forms.TrackBar();
            this.label_AI_RangeValue = new System.Windows.Forms.Label();
            this.label_AI_Range = new System.Windows.Forms.Label();
            this.tracBar_AI_Range = new System.Windows.Forms.TrackBar();
            this.label_AI_PitchValue = new System.Windows.Forms.Label();
            this.label_AI_Pitch = new System.Windows.Forms.Label();
            this.tracBar_AI_Pitch = new System.Windows.Forms.TrackBar();
            this.label_AI_Speaker = new System.Windows.Forms.Label();
            this.comboBox_AI_Speaker = new System.Windows.Forms.ComboBox();
            this.textBox_AI_SampleVoice = new System.Windows.Forms.TextBox();
            this.groupBox_AI_APIKey = new System.Windows.Forms.GroupBox();
            this.linkLabel_AI_HomePage_Kiyaku = new System.Windows.Forms.LinkLabel();
            this.linkLabel_AI_HomePage = new System.Windows.Forms.LinkLabel();
            this.textBox_AI_APIKey = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grouBox_VT_VoiceCode = new System.Windows.Forms.GroupBox();
            this.textBox_VT_VoiceCode = new System.Windows.Forms.TextBox();
            this.groupBox_VT_VoiceCodeSetting = new System.Windows.Forms.GroupBox();
            this.label_VT_EmotionLevel = new System.Windows.Forms.Label();
            this.comboBox_VT_EmotionLevel = new System.Windows.Forms.ComboBox();
            this.button_VT_SampleVoice = new System.Windows.Forms.Button();
            this.label_VT_PitchValue = new System.Windows.Forms.Label();
            this.label_VT_Pitch = new System.Windows.Forms.Label();
            this.tracBar_VT_Pitch = new System.Windows.Forms.TrackBar();
            this.label_VT_SpeedValue = new System.Windows.Forms.Label();
            this.label_VT_Speed = new System.Windows.Forms.Label();
            this.tracBar_VT_Speed = new System.Windows.Forms.TrackBar();
            this.label_VT_VolumeValue = new System.Windows.Forms.Label();
            this.label_VT_Volume = new System.Windows.Forms.Label();
            this.tracBar_VT_Volume = new System.Windows.Forms.TrackBar();
            this.label_VT_Emotion = new System.Windows.Forms.Label();
            this.comboBox_VT_Emotion = new System.Windows.Forms.ComboBox();
            this.label_VT_Speaker = new System.Windows.Forms.Label();
            this.comboBox_VT_Speaker = new System.Windows.Forms.ComboBox();
            this.textBox_VT_SampleVoice = new System.Windows.Forms.TextBox();
            this.groupBox_VT_APIKey = new System.Windows.Forms.GroupBox();
            this.linkLabel_VT_HomePage_Kiyaku = new System.Windows.Forms.LinkLabel();
            this.linkLabel_VT_HomePage = new System.Windows.Forms.LinkLabel();
            this.textBox_VT_APIKey = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grouBox_AI_VoiceCode.SuspendLayout();
            this.groupBox_AI_VoiceCodeSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_AI_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_AI_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_AI_Range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_AI_Pitch)).BeginInit();
            this.groupBox_AI_APIKey.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grouBox_VT_VoiceCode.SuspendLayout();
            this.groupBox_VT_VoiceCodeSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_VT_Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_VT_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_VT_Volume)).BeginInit();
            this.groupBox_VT_APIKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(595, 675);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox_Clipboard);
            this.tabPage1.Controls.Add(this.comboBox_Device);
            this.tabPage1.Controls.Add(this.label_Audio);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox_Clipboard
            // 
            this.checkBox_Clipboard.AutoSize = true;
            this.checkBox_Clipboard.Checked = true;
            this.checkBox_Clipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Clipboard.Location = new System.Drawing.Point(21, 27);
            this.checkBox_Clipboard.Name = "checkBox_Clipboard";
            this.checkBox_Clipboard.Size = new System.Drawing.Size(150, 24);
            this.checkBox_Clipboard.TabIndex = 1;
            this.checkBox_Clipboard.Text = "クリップボードを監視";
            this.checkBox_Clipboard.UseVisualStyleBackColor = true;
            // 
            // comboBox_Device
            // 
            this.comboBox_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Device.FormattingEnabled = true;
            this.comboBox_Device.Location = new System.Drawing.Point(21, 100);
            this.comboBox_Device.Name = "comboBox_Device";
            this.comboBox_Device.Size = new System.Drawing.Size(330, 28);
            this.comboBox_Device.TabIndex = 3;
            // 
            // label_Audio
            // 
            this.label_Audio.AutoSize = true;
            this.label_Audio.Location = new System.Drawing.Point(17, 77);
            this.label_Audio.Name = "label_Audio";
            this.label_Audio.Size = new System.Drawing.Size(140, 20);
            this.label_Audio.TabIndex = 2;
            this.label_Audio.Text = "音声出力先デバイス";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grouBox_AI_VoiceCode);
            this.tabPage3.Controls.Add(this.groupBox_AI_VoiceCodeSetting);
            this.tabPage3.Controls.Add(this.groupBox_AI_APIKey);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(587, 642);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AITalk";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grouBox_AI_VoiceCode
            // 
            this.grouBox_AI_VoiceCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouBox_AI_VoiceCode.Controls.Add(this.textBox_AI_VoiceCode);
            this.grouBox_AI_VoiceCode.Location = new System.Drawing.Point(12, 502);
            this.grouBox_AI_VoiceCode.Name = "grouBox_AI_VoiceCode";
            this.grouBox_AI_VoiceCode.Size = new System.Drawing.Size(557, 125);
            this.grouBox_AI_VoiceCode.TabIndex = 130;
            this.grouBox_AI_VoiceCode.TabStop = false;
            this.grouBox_AI_VoiceCode.Text = "Voice Code";
            // 
            // textBox_AI_VoiceCode
            // 
            this.textBox_AI_VoiceCode.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AI_VoiceCode.Location = new System.Drawing.Point(18, 27);
            this.textBox_AI_VoiceCode.Multiline = true;
            this.textBox_AI_VoiceCode.Name = "textBox_AI_VoiceCode";
            this.textBox_AI_VoiceCode.ReadOnly = true;
            this.textBox_AI_VoiceCode.Size = new System.Drawing.Size(516, 82);
            this.textBox_AI_VoiceCode.TabIndex = 131;
            // 
            // groupBox_AI_VoiceCodeSetting
            // 
            this.groupBox_AI_VoiceCodeSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.label_AI_VolumeValue);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.label_AI_Volume);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.tracBar_AI_Volume);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.button_AI_SampleVoice);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.label_AI_RateValue);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.label_AI_Rate);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.tracBar_AI_Rate);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.label_AI_RangeValue);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.label_AI_Range);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.tracBar_AI_Range);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.label_AI_PitchValue);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.label_AI_Pitch);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.tracBar_AI_Pitch);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.label_AI_Speaker);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.comboBox_AI_Speaker);
            this.groupBox_AI_VoiceCodeSetting.Controls.Add(this.textBox_AI_SampleVoice);
            this.groupBox_AI_VoiceCodeSetting.Location = new System.Drawing.Point(12, 81);
            this.groupBox_AI_VoiceCodeSetting.Name = "groupBox_AI_VoiceCodeSetting";
            this.groupBox_AI_VoiceCodeSetting.Size = new System.Drawing.Size(557, 411);
            this.groupBox_AI_VoiceCodeSetting.TabIndex = 110;
            this.groupBox_AI_VoiceCodeSetting.TabStop = false;
            this.groupBox_AI_VoiceCodeSetting.Text = "Vocie Code Setting";
            // 
            // label_AI_VolumeValue
            // 
            this.label_AI_VolumeValue.AutoSize = true;
            this.label_AI_VolumeValue.Location = new System.Drawing.Point(14, 109);
            this.label_AI_VolumeValue.Name = "label_AI_VolumeValue";
            this.label_AI_VolumeValue.Size = new System.Drawing.Size(59, 20);
            this.label_AI_VolumeValue.TabIndex = 114;
            this.label_AI_VolumeValue.Text = "(1.00)";
            // 
            // label_AI_Volume
            // 
            this.label_AI_Volume.AutoSize = true;
            this.label_AI_Volume.Location = new System.Drawing.Point(14, 89);
            this.label_AI_Volume.Name = "label_AI_Volume";
            this.label_AI_Volume.Size = new System.Drawing.Size(67, 20);
            this.label_AI_Volume.TabIndex = 113;
            this.label_AI_Volume.Text = "Volume";
            // 
            // tracBar_AI_Volume
            // 
            this.tracBar_AI_Volume.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tracBar_AI_Volume.Location = new System.Drawing.Point(92, 89);
            this.tracBar_AI_Volume.Maximum = 200;
            this.tracBar_AI_Volume.Name = "tracBar_AI_Volume";
            this.tracBar_AI_Volume.Size = new System.Drawing.Size(442, 45);
            this.tracBar_AI_Volume.SmallChange = 5;
            this.tracBar_AI_Volume.TabIndex = 115;
            this.tracBar_AI_Volume.TickFrequency = 10;
            this.tracBar_AI_Volume.Value = 100;
            this.tracBar_AI_Volume.ValueChanged += new System.EventHandler(this._AITalk_valueChanged);
            // 
            // button_AI_SampleVoice
            // 
            this.button_AI_SampleVoice.Location = new System.Drawing.Point(18, 306);
            this.button_AI_SampleVoice.Name = "button_AI_SampleVoice";
            this.button_AI_SampleVoice.Size = new System.Drawing.Size(142, 35);
            this.button_AI_SampleVoice.TabIndex = 125;
            this.button_AI_SampleVoice.Text = "Sample Voice";
            this.button_AI_SampleVoice.UseVisualStyleBackColor = true;
            this.button_AI_SampleVoice.Click += new System.EventHandler(this.button_AI_SampleVoice_Click);
            // 
            // label_AI_RateValue
            // 
            this.label_AI_RateValue.AutoSize = true;
            this.label_AI_RateValue.Location = new System.Drawing.Point(14, 262);
            this.label_AI_RateValue.Name = "label_AI_RateValue";
            this.label_AI_RateValue.Size = new System.Drawing.Size(59, 20);
            this.label_AI_RateValue.TabIndex = 123;
            this.label_AI_RateValue.Text = "(1.00)";
            // 
            // label_AI_Rate
            // 
            this.label_AI_Rate.AutoSize = true;
            this.label_AI_Rate.Location = new System.Drawing.Point(14, 242);
            this.label_AI_Rate.Name = "label_AI_Rate";
            this.label_AI_Rate.Size = new System.Drawing.Size(44, 20);
            this.label_AI_Rate.TabIndex = 122;
            this.label_AI_Rate.Text = "Rate";
            // 
            // tracBar_AI_Rate
            // 
            this.tracBar_AI_Rate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tracBar_AI_Rate.Location = new System.Drawing.Point(92, 242);
            this.tracBar_AI_Rate.Maximum = 400;
            this.tracBar_AI_Rate.Minimum = 50;
            this.tracBar_AI_Rate.Name = "tracBar_AI_Rate";
            this.tracBar_AI_Rate.Size = new System.Drawing.Size(442, 45);
            this.tracBar_AI_Rate.SmallChange = 5;
            this.tracBar_AI_Rate.TabIndex = 124;
            this.tracBar_AI_Rate.TickFrequency = 10;
            this.tracBar_AI_Rate.Value = 100;
            this.tracBar_AI_Rate.ValueChanged += new System.EventHandler(this._AITalk_valueChanged);
            // 
            // label_AI_RangeValue
            // 
            this.label_AI_RangeValue.AutoSize = true;
            this.label_AI_RangeValue.Location = new System.Drawing.Point(14, 211);
            this.label_AI_RangeValue.Name = "label_AI_RangeValue";
            this.label_AI_RangeValue.Size = new System.Drawing.Size(59, 20);
            this.label_AI_RangeValue.TabIndex = 120;
            this.label_AI_RangeValue.Text = "(1.00)";
            // 
            // label_AI_Range
            // 
            this.label_AI_Range.AutoSize = true;
            this.label_AI_Range.Location = new System.Drawing.Point(14, 191);
            this.label_AI_Range.Name = "label_AI_Range";
            this.label_AI_Range.Size = new System.Drawing.Size(58, 20);
            this.label_AI_Range.TabIndex = 119;
            this.label_AI_Range.Text = "Range";
            // 
            // tracBar_AI_Range
            // 
            this.tracBar_AI_Range.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tracBar_AI_Range.Location = new System.Drawing.Point(92, 191);
            this.tracBar_AI_Range.Maximum = 200;
            this.tracBar_AI_Range.Name = "tracBar_AI_Range";
            this.tracBar_AI_Range.Size = new System.Drawing.Size(442, 45);
            this.tracBar_AI_Range.SmallChange = 5;
            this.tracBar_AI_Range.TabIndex = 121;
            this.tracBar_AI_Range.TickFrequency = 10;
            this.tracBar_AI_Range.Value = 100;
            this.tracBar_AI_Range.ValueChanged += new System.EventHandler(this._AITalk_valueChanged);
            // 
            // label_AI_PitchValue
            // 
            this.label_AI_PitchValue.AutoSize = true;
            this.label_AI_PitchValue.Location = new System.Drawing.Point(14, 160);
            this.label_AI_PitchValue.Name = "label_AI_PitchValue";
            this.label_AI_PitchValue.Size = new System.Drawing.Size(59, 20);
            this.label_AI_PitchValue.TabIndex = 117;
            this.label_AI_PitchValue.Text = "(1.00)";
            // 
            // label_AI_Pitch
            // 
            this.label_AI_Pitch.AutoSize = true;
            this.label_AI_Pitch.Location = new System.Drawing.Point(14, 140);
            this.label_AI_Pitch.Name = "label_AI_Pitch";
            this.label_AI_Pitch.Size = new System.Drawing.Size(47, 20);
            this.label_AI_Pitch.TabIndex = 116;
            this.label_AI_Pitch.Text = "Pitch";
            // 
            // tracBar_AI_Pitch
            // 
            this.tracBar_AI_Pitch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tracBar_AI_Pitch.Location = new System.Drawing.Point(92, 140);
            this.tracBar_AI_Pitch.Maximum = 200;
            this.tracBar_AI_Pitch.Minimum = 50;
            this.tracBar_AI_Pitch.Name = "tracBar_AI_Pitch";
            this.tracBar_AI_Pitch.Size = new System.Drawing.Size(442, 45);
            this.tracBar_AI_Pitch.SmallChange = 5;
            this.tracBar_AI_Pitch.TabIndex = 118;
            this.tracBar_AI_Pitch.TickFrequency = 10;
            this.tracBar_AI_Pitch.Value = 100;
            this.tracBar_AI_Pitch.ValueChanged += new System.EventHandler(this._AITalk_valueChanged);
            // 
            // label_AI_Speaker
            // 
            this.label_AI_Speaker.AutoSize = true;
            this.label_AI_Speaker.Location = new System.Drawing.Point(14, 41);
            this.label_AI_Speaker.Name = "label_AI_Speaker";
            this.label_AI_Speaker.Size = new System.Drawing.Size(72, 20);
            this.label_AI_Speaker.TabIndex = 111;
            this.label_AI_Speaker.Text = "Speaker";
            // 
            // comboBox_AI_Speaker
            // 
            this.comboBox_AI_Speaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AI_Speaker.FormattingEnabled = true;
            this.comboBox_AI_Speaker.Location = new System.Drawing.Point(92, 38);
            this.comboBox_AI_Speaker.Name = "comboBox_AI_Speaker";
            this.comboBox_AI_Speaker.Size = new System.Drawing.Size(173, 28);
            this.comboBox_AI_Speaker.TabIndex = 112;
            this.comboBox_AI_Speaker.SelectedIndexChanged += new System.EventHandler(this._AITalk_valueChanged);
            // 
            // textBox_AI_SampleVoice
            // 
            this.textBox_AI_SampleVoice.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_AI_SampleVoice.Location = new System.Drawing.Point(18, 347);
            this.textBox_AI_SampleVoice.Multiline = true;
            this.textBox_AI_SampleVoice.Name = "textBox_AI_SampleVoice";
            this.textBox_AI_SampleVoice.Size = new System.Drawing.Size(516, 52);
            this.textBox_AI_SampleVoice.TabIndex = 126;
            this.textBox_AI_SampleVoice.Text = "AITalkの音声合成サンプル";
            // 
            // groupBox_AI_APIKey
            // 
            this.groupBox_AI_APIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_AI_APIKey.Controls.Add(this.linkLabel_AI_HomePage_Kiyaku);
            this.groupBox_AI_APIKey.Controls.Add(this.linkLabel_AI_HomePage);
            this.groupBox_AI_APIKey.Controls.Add(this.textBox_AI_APIKey);
            this.groupBox_AI_APIKey.Location = new System.Drawing.Point(12, 6);
            this.groupBox_AI_APIKey.Name = "groupBox_AI_APIKey";
            this.groupBox_AI_APIKey.Size = new System.Drawing.Size(557, 69);
            this.groupBox_AI_APIKey.TabIndex = 100;
            this.groupBox_AI_APIKey.TabStop = false;
            this.groupBox_AI_APIKey.Text = "API Key";
            // 
            // linkLabel_AI_HomePage_Kiyaku
            // 
            this.linkLabel_AI_HomePage_Kiyaku.AutoSize = true;
            this.linkLabel_AI_HomePage_Kiyaku.Location = new System.Drawing.Point(364, 30);
            this.linkLabel_AI_HomePage_Kiyaku.Name = "linkLabel_AI_HomePage_Kiyaku";
            this.linkLabel_AI_HomePage_Kiyaku.Size = new System.Drawing.Size(152, 20);
            this.linkLabel_AI_HomePage_Kiyaku.TabIndex = 103;
            this.linkLabel_AI_HomePage_Kiyaku.TabStop = true;
            this.linkLabel_AI_HomePage_Kiyaku.Text = "API利用のガイドライン";
            this.linkLabel_AI_HomePage_Kiyaku.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AI_HomePage_Kiyaku_LinkClicked);
            // 
            // linkLabel_AI_HomePage
            // 
            this.linkLabel_AI_HomePage.AutoSize = true;
            this.linkLabel_AI_HomePage.Location = new System.Drawing.Point(206, 30);
            this.linkLabel_AI_HomePage.Name = "linkLabel_AI_HomePage";
            this.linkLabel_AI_HomePage.Size = new System.Drawing.Size(152, 20);
            this.linkLabel_AI_HomePage.TabIndex = 102;
            this.linkLabel_AI_HomePage.TabStop = true;
            this.linkLabel_AI_HomePage.Text = "音声合成APIについて";
            this.linkLabel_AI_HomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AI_HomePage_LinkClicked);
            // 
            // textBox_AI_APIKey
            // 
            this.textBox_AI_APIKey.Location = new System.Drawing.Point(18, 27);
            this.textBox_AI_APIKey.Name = "textBox_AI_APIKey";
            this.textBox_AI_APIKey.PasswordChar = '*';
            this.textBox_AI_APIKey.Size = new System.Drawing.Size(173, 28);
            this.textBox_AI_APIKey.TabIndex = 101;
            this.textBox_AI_APIKey.WordWrap = false;
            this.textBox_AI_APIKey.TextChanged += new System.EventHandler(this.textBox_AI_APIKey_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grouBox_VT_VoiceCode);
            this.tabPage2.Controls.Add(this.groupBox_VT_VoiceCodeSetting);
            this.tabPage2.Controls.Add(this.groupBox_VT_APIKey);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VoiceText";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grouBox_VT_VoiceCode
            // 
            this.grouBox_VT_VoiceCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouBox_VT_VoiceCode.Controls.Add(this.textBox_VT_VoiceCode);
            this.grouBox_VT_VoiceCode.Location = new System.Drawing.Point(12, 502);
            this.grouBox_VT_VoiceCode.Name = "grouBox_VT_VoiceCode";
            this.grouBox_VT_VoiceCode.Size = new System.Drawing.Size(557, 125);
            this.grouBox_VT_VoiceCode.TabIndex = 230;
            this.grouBox_VT_VoiceCode.TabStop = false;
            this.grouBox_VT_VoiceCode.Text = "Voice Code";
            // 
            // textBox_VT_VoiceCode
            // 
            this.textBox_VT_VoiceCode.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VT_VoiceCode.Location = new System.Drawing.Point(18, 27);
            this.textBox_VT_VoiceCode.Multiline = true;
            this.textBox_VT_VoiceCode.Name = "textBox_VT_VoiceCode";
            this.textBox_VT_VoiceCode.ReadOnly = true;
            this.textBox_VT_VoiceCode.Size = new System.Drawing.Size(516, 82);
            this.textBox_VT_VoiceCode.TabIndex = 231;
            // 
            // groupBox_VT_VoiceCodeSetting
            // 
            this.groupBox_VT_VoiceCodeSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.label_VT_EmotionLevel);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.comboBox_VT_EmotionLevel);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.button_VT_SampleVoice);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.label_VT_PitchValue);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.label_VT_Pitch);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.tracBar_VT_Pitch);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.label_VT_SpeedValue);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.label_VT_Speed);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.tracBar_VT_Speed);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.label_VT_VolumeValue);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.label_VT_Volume);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.tracBar_VT_Volume);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.label_VT_Emotion);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.comboBox_VT_Emotion);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.label_VT_Speaker);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.comboBox_VT_Speaker);
            this.groupBox_VT_VoiceCodeSetting.Controls.Add(this.textBox_VT_SampleVoice);
            this.groupBox_VT_VoiceCodeSetting.Location = new System.Drawing.Point(12, 81);
            this.groupBox_VT_VoiceCodeSetting.Name = "groupBox_VT_VoiceCodeSetting";
            this.groupBox_VT_VoiceCodeSetting.Size = new System.Drawing.Size(557, 411);
            this.groupBox_VT_VoiceCodeSetting.TabIndex = 210;
            this.groupBox_VT_VoiceCodeSetting.TabStop = false;
            this.groupBox_VT_VoiceCodeSetting.Text = "Vocie Code Setting";
            // 
            // label_VT_EmotionLevel
            // 
            this.label_VT_EmotionLevel.AutoSize = true;
            this.label_VT_EmotionLevel.Location = new System.Drawing.Point(290, 86);
            this.label_VT_EmotionLevel.Name = "label_VT_EmotionLevel";
            this.label_VT_EmotionLevel.Size = new System.Drawing.Size(49, 20);
            this.label_VT_EmotionLevel.TabIndex = 215;
            this.label_VT_EmotionLevel.Text = "Level";
            // 
            // comboBox_VT_EmotionLevel
            // 
            this.comboBox_VT_EmotionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VT_EmotionLevel.FormattingEnabled = true;
            this.comboBox_VT_EmotionLevel.Location = new System.Drawing.Point(361, 83);
            this.comboBox_VT_EmotionLevel.Name = "comboBox_VT_EmotionLevel";
            this.comboBox_VT_EmotionLevel.Size = new System.Drawing.Size(173, 28);
            this.comboBox_VT_EmotionLevel.TabIndex = 216;
            this.comboBox_VT_EmotionLevel.SelectedIndexChanged += new System.EventHandler(this._VT_valueChanged);
            // 
            // button_VT_SampleVoice
            // 
            this.button_VT_SampleVoice.Location = new System.Drawing.Point(18, 306);
            this.button_VT_SampleVoice.Name = "button_VT_SampleVoice";
            this.button_VT_SampleVoice.Size = new System.Drawing.Size(142, 35);
            this.button_VT_SampleVoice.TabIndex = 226;
            this.button_VT_SampleVoice.Text = "Sample Voice";
            this.button_VT_SampleVoice.UseVisualStyleBackColor = true;
            this.button_VT_SampleVoice.Click += new System.EventHandler(this.btnSampleVT_Click);
            // 
            // label_VT_PitchValue
            // 
            this.label_VT_PitchValue.AutoSize = true;
            this.label_VT_PitchValue.Location = new System.Drawing.Point(14, 262);
            this.label_VT_PitchValue.Name = "label_VT_PitchValue";
            this.label_VT_PitchValue.Size = new System.Drawing.Size(53, 20);
            this.label_VT_PitchValue.TabIndex = 225;
            this.label_VT_PitchValue.Text = "(100)";
            // 
            // label_VT_Pitch
            // 
            this.label_VT_Pitch.AutoSize = true;
            this.label_VT_Pitch.Location = new System.Drawing.Point(14, 242);
            this.label_VT_Pitch.Name = "label_VT_Pitch";
            this.label_VT_Pitch.Size = new System.Drawing.Size(47, 20);
            this.label_VT_Pitch.TabIndex = 223;
            this.label_VT_Pitch.Text = "Pitch";
            // 
            // tracBar_VT_Pitch
            // 
            this.tracBar_VT_Pitch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tracBar_VT_Pitch.Location = new System.Drawing.Point(92, 242);
            this.tracBar_VT_Pitch.Maximum = 200;
            this.tracBar_VT_Pitch.Minimum = 50;
            this.tracBar_VT_Pitch.Name = "tracBar_VT_Pitch";
            this.tracBar_VT_Pitch.Size = new System.Drawing.Size(442, 45);
            this.tracBar_VT_Pitch.SmallChange = 5;
            this.tracBar_VT_Pitch.TabIndex = 224;
            this.tracBar_VT_Pitch.TickFrequency = 10;
            this.tracBar_VT_Pitch.Value = 100;
            this.tracBar_VT_Pitch.ValueChanged += new System.EventHandler(this._VT_valueChanged);
            // 
            // label_VT_SpeedValue
            // 
            this.label_VT_SpeedValue.AutoSize = true;
            this.label_VT_SpeedValue.Location = new System.Drawing.Point(14, 211);
            this.label_VT_SpeedValue.Name = "label_VT_SpeedValue";
            this.label_VT_SpeedValue.Size = new System.Drawing.Size(53, 20);
            this.label_VT_SpeedValue.TabIndex = 222;
            this.label_VT_SpeedValue.Text = "(100)";
            // 
            // label_VT_Speed
            // 
            this.label_VT_Speed.AutoSize = true;
            this.label_VT_Speed.Location = new System.Drawing.Point(14, 191);
            this.label_VT_Speed.Name = "label_VT_Speed";
            this.label_VT_Speed.Size = new System.Drawing.Size(57, 20);
            this.label_VT_Speed.TabIndex = 220;
            this.label_VT_Speed.Text = "Speed";
            // 
            // tracBar_VT_Speed
            // 
            this.tracBar_VT_Speed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tracBar_VT_Speed.Location = new System.Drawing.Point(92, 191);
            this.tracBar_VT_Speed.Maximum = 400;
            this.tracBar_VT_Speed.Minimum = 50;
            this.tracBar_VT_Speed.Name = "tracBar_VT_Speed";
            this.tracBar_VT_Speed.Size = new System.Drawing.Size(442, 45);
            this.tracBar_VT_Speed.SmallChange = 5;
            this.tracBar_VT_Speed.TabIndex = 221;
            this.tracBar_VT_Speed.TickFrequency = 10;
            this.tracBar_VT_Speed.Value = 100;
            this.tracBar_VT_Speed.ValueChanged += new System.EventHandler(this._VT_valueChanged);
            // 
            // label_VT_VolumeValue
            // 
            this.label_VT_VolumeValue.AutoSize = true;
            this.label_VT_VolumeValue.Location = new System.Drawing.Point(14, 160);
            this.label_VT_VolumeValue.Name = "label_VT_VolumeValue";
            this.label_VT_VolumeValue.Size = new System.Drawing.Size(53, 20);
            this.label_VT_VolumeValue.TabIndex = 219;
            this.label_VT_VolumeValue.Text = "(100)";
            // 
            // label_VT_Volume
            // 
            this.label_VT_Volume.AutoSize = true;
            this.label_VT_Volume.Location = new System.Drawing.Point(14, 140);
            this.label_VT_Volume.Name = "label_VT_Volume";
            this.label_VT_Volume.Size = new System.Drawing.Size(67, 20);
            this.label_VT_Volume.TabIndex = 217;
            this.label_VT_Volume.Text = "Volume";
            // 
            // tracBar_VT_Volume
            // 
            this.tracBar_VT_Volume.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tracBar_VT_Volume.Location = new System.Drawing.Point(92, 140);
            this.tracBar_VT_Volume.Maximum = 200;
            this.tracBar_VT_Volume.Minimum = 50;
            this.tracBar_VT_Volume.Name = "tracBar_VT_Volume";
            this.tracBar_VT_Volume.Size = new System.Drawing.Size(442, 45);
            this.tracBar_VT_Volume.SmallChange = 5;
            this.tracBar_VT_Volume.TabIndex = 218;
            this.tracBar_VT_Volume.TickFrequency = 10;
            this.tracBar_VT_Volume.Value = 100;
            this.tracBar_VT_Volume.ValueChanged += new System.EventHandler(this._VT_valueChanged);
            // 
            // label_VT_Emotion
            // 
            this.label_VT_Emotion.AutoSize = true;
            this.label_VT_Emotion.Location = new System.Drawing.Point(14, 86);
            this.label_VT_Emotion.Name = "label_VT_Emotion";
            this.label_VT_Emotion.Size = new System.Drawing.Size(74, 20);
            this.label_VT_Emotion.TabIndex = 213;
            this.label_VT_Emotion.Text = "Emotion";
            // 
            // comboBox_VT_Emotion
            // 
            this.comboBox_VT_Emotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VT_Emotion.FormattingEnabled = true;
            this.comboBox_VT_Emotion.Location = new System.Drawing.Point(92, 83);
            this.comboBox_VT_Emotion.Name = "comboBox_VT_Emotion";
            this.comboBox_VT_Emotion.Size = new System.Drawing.Size(173, 28);
            this.comboBox_VT_Emotion.TabIndex = 214;
            this.comboBox_VT_Emotion.SelectedIndexChanged += new System.EventHandler(this._VT_valueChanged);
            // 
            // label_VT_Speaker
            // 
            this.label_VT_Speaker.AutoSize = true;
            this.label_VT_Speaker.Location = new System.Drawing.Point(14, 41);
            this.label_VT_Speaker.Name = "label_VT_Speaker";
            this.label_VT_Speaker.Size = new System.Drawing.Size(72, 20);
            this.label_VT_Speaker.TabIndex = 211;
            this.label_VT_Speaker.Text = "Speaker";
            // 
            // comboBox_VT_Speaker
            // 
            this.comboBox_VT_Speaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VT_Speaker.FormattingEnabled = true;
            this.comboBox_VT_Speaker.Location = new System.Drawing.Point(92, 38);
            this.comboBox_VT_Speaker.Name = "comboBox_VT_Speaker";
            this.comboBox_VT_Speaker.Size = new System.Drawing.Size(173, 28);
            this.comboBox_VT_Speaker.TabIndex = 212;
            this.comboBox_VT_Speaker.SelectedIndexChanged += new System.EventHandler(this._VT_valueChanged);
            // 
            // textBox_VT_SampleVoice
            // 
            this.textBox_VT_SampleVoice.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_VT_SampleVoice.Location = new System.Drawing.Point(18, 347);
            this.textBox_VT_SampleVoice.Multiline = true;
            this.textBox_VT_SampleVoice.Name = "textBox_VT_SampleVoice";
            this.textBox_VT_SampleVoice.Size = new System.Drawing.Size(516, 52);
            this.textBox_VT_SampleVoice.TabIndex = 227;
            this.textBox_VT_SampleVoice.Text = "VoiceTextの音声合成サンプル";
            // 
            // groupBox_VT_APIKey
            // 
            this.groupBox_VT_APIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_VT_APIKey.Controls.Add(this.linkLabel_VT_HomePage_Kiyaku);
            this.groupBox_VT_APIKey.Controls.Add(this.linkLabel_VT_HomePage);
            this.groupBox_VT_APIKey.Controls.Add(this.textBox_VT_APIKey);
            this.groupBox_VT_APIKey.Location = new System.Drawing.Point(12, 6);
            this.groupBox_VT_APIKey.Name = "groupBox_VT_APIKey";
            this.groupBox_VT_APIKey.Size = new System.Drawing.Size(557, 69);
            this.groupBox_VT_APIKey.TabIndex = 200;
            this.groupBox_VT_APIKey.TabStop = false;
            this.groupBox_VT_APIKey.Text = "API Key";
            // 
            // linkLabel_VT_HomePage_Kiyaku
            // 
            this.linkLabel_VT_HomePage_Kiyaku.AutoSize = true;
            this.linkLabel_VT_HomePage_Kiyaku.Location = new System.Drawing.Point(325, 30);
            this.linkLabel_VT_HomePage_Kiyaku.Name = "linkLabel_VT_HomePage_Kiyaku";
            this.linkLabel_VT_HomePage_Kiyaku.Size = new System.Drawing.Size(73, 20);
            this.linkLabel_VT_HomePage_Kiyaku.TabIndex = 203;
            this.linkLabel_VT_HomePage_Kiyaku.TabStop = true;
            this.linkLabel_VT_HomePage_Kiyaku.Text = "利用規約";
            this.linkLabel_VT_HomePage_Kiyaku.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKiyaku_LinkClicked);
            // 
            // linkLabel_VT_HomePage
            // 
            this.linkLabel_VT_HomePage.AutoSize = true;
            this.linkLabel_VT_HomePage.Location = new System.Drawing.Point(206, 30);
            this.linkLabel_VT_HomePage.Name = "linkLabel_VT_HomePage";
            this.linkLabel_VT_HomePage.Size = new System.Drawing.Size(113, 20);
            this.linkLabel_VT_HomePage.TabIndex = 202;
            this.linkLabel_VT_HomePage.TabStop = true;
            this.linkLabel_VT_HomePage.Text = "VoiceText公式";
            this.linkLabel_VT_HomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkVoiceText_LinkClicked);
            // 
            // textBox_VT_APIKey
            // 
            this.textBox_VT_APIKey.Location = new System.Drawing.Point(18, 27);
            this.textBox_VT_APIKey.Name = "textBox_VT_APIKey";
            this.textBox_VT_APIKey.PasswordChar = '*';
            this.textBox_VT_APIKey.Size = new System.Drawing.Size(173, 28);
            this.textBox_VT_APIKey.TabIndex = 201;
            this.textBox_VT_APIKey.WordWrap = false;
            this.textBox_VT_APIKey.TextChanged += new System.EventHandler(this.TxtAPIKey_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 675);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Skybeje.Speaker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grouBox_AI_VoiceCode.ResumeLayout(false);
            this.grouBox_AI_VoiceCode.PerformLayout();
            this.groupBox_AI_VoiceCodeSetting.ResumeLayout(false);
            this.groupBox_AI_VoiceCodeSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_AI_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_AI_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_AI_Range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_AI_Pitch)).EndInit();
            this.groupBox_AI_APIKey.ResumeLayout(false);
            this.groupBox_AI_APIKey.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grouBox_VT_VoiceCode.ResumeLayout(false);
            this.grouBox_VT_VoiceCode.PerformLayout();
            this.groupBox_VT_VoiceCodeSetting.ResumeLayout(false);
            this.groupBox_VT_VoiceCodeSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_VT_Pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_VT_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracBar_VT_Volume)).EndInit();
            this.groupBox_VT_APIKey.ResumeLayout(false);
            this.groupBox_VT_APIKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_VT_SampleVoice;
        private System.Windows.Forms.Label label_Audio;
        private System.Windows.Forms.ComboBox comboBox_Device;
        private System.Windows.Forms.CheckBox checkBox_Clipboard;
        private System.Windows.Forms.TextBox textBox_VT_APIKey;
        private System.Windows.Forms.GroupBox groupBox_VT_VoiceCodeSetting;
        private System.Windows.Forms.GroupBox groupBox_VT_APIKey;
        private System.Windows.Forms.Label label_VT_Emotion;
        private System.Windows.Forms.ComboBox comboBox_VT_Emotion;
        private System.Windows.Forms.Label label_VT_Speaker;
        private System.Windows.Forms.ComboBox comboBox_VT_Speaker;
        private System.Windows.Forms.TrackBar tracBar_VT_Volume;
        private System.Windows.Forms.Label label_VT_Volume;
        private System.Windows.Forms.Label label_VT_VolumeValue;
        private System.Windows.Forms.Label label_VT_PitchValue;
        private System.Windows.Forms.Label label_VT_Pitch;
        private System.Windows.Forms.TrackBar tracBar_VT_Pitch;
        private System.Windows.Forms.Label label_VT_SpeedValue;
        private System.Windows.Forms.Label label_VT_Speed;
        private System.Windows.Forms.TrackBar tracBar_VT_Speed;
        private System.Windows.Forms.Button button_VT_SampleVoice;
        private System.Windows.Forms.Label label_VT_EmotionLevel;
        private System.Windows.Forms.ComboBox comboBox_VT_EmotionLevel;
        private System.Windows.Forms.LinkLabel linkLabel_VT_HomePage;
        private System.Windows.Forms.LinkLabel linkLabel_VT_HomePage_Kiyaku;
        private System.Windows.Forms.GroupBox grouBox_VT_VoiceCode;
        private System.Windows.Forms.TextBox textBox_VT_VoiceCode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grouBox_AI_VoiceCode;
        private System.Windows.Forms.TextBox textBox_AI_VoiceCode;
        private System.Windows.Forms.GroupBox groupBox_AI_VoiceCodeSetting;
        private System.Windows.Forms.Button button_AI_SampleVoice;
        private System.Windows.Forms.Label label_AI_RateValue;
        private System.Windows.Forms.Label label_AI_Rate;
        private System.Windows.Forms.TrackBar tracBar_AI_Rate;
        private System.Windows.Forms.Label label_AI_RangeValue;
        private System.Windows.Forms.Label label_AI_Range;
        private System.Windows.Forms.TrackBar tracBar_AI_Range;
        private System.Windows.Forms.Label label_AI_PitchValue;
        private System.Windows.Forms.Label label_AI_Pitch;
        private System.Windows.Forms.TrackBar tracBar_AI_Pitch;
        private System.Windows.Forms.Label label_AI_Speaker;
        private System.Windows.Forms.ComboBox comboBox_AI_Speaker;
        private System.Windows.Forms.TextBox textBox_AI_SampleVoice;
        private System.Windows.Forms.GroupBox groupBox_AI_APIKey;
        private System.Windows.Forms.LinkLabel linkLabel_AI_HomePage_Kiyaku;
        private System.Windows.Forms.LinkLabel linkLabel_AI_HomePage;
        private System.Windows.Forms.TextBox textBox_AI_APIKey;
        private System.Windows.Forms.Label label_AI_VolumeValue;
        private System.Windows.Forms.Label label_AI_Volume;
        private System.Windows.Forms.TrackBar tracBar_AI_Volume;
    }
}

