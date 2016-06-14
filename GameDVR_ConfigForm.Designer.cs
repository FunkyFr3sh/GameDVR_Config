namespace GameDVR_Config
{
    partial class GameDVR_ConfigForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnableGameDVRCheckBox = new System.Windows.Forms.CheckBox();
            this.EnableAudioCaptureCheckBox = new System.Windows.Forms.CheckBox();
            this.AudioEncodingBitrateLabel = new System.Windows.Forms.Label();
            this.AudioBitrateComboBox = new System.Windows.Forms.ComboBox();
            this.kbpsLabel = new System.Windows.Forms.Label();
            this.VideoEncodingBitrateLabel = new System.Windows.Forms.Label();
            this.kbpsLabel2 = new System.Windows.Forms.Label();
            this.VideoBitrateTextBox = new System.Windows.Forms.TextBox();
            this.ResizeVideoCheckBox = new System.Windows.Forms.CheckBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.EnableMicrophoneCaptureCheckBox = new System.Windows.Forms.CheckBox();
            this.ForceSoftwareMFTCheckBox = new System.Windows.Forms.CheckBox();
            this.DisableCursorBlendingCheckBox = new System.Windows.Forms.CheckBox();
            this.BackgroundRecordingCheckBox = new System.Windows.Forms.CheckBox();
            this.RecordTheLastTextBox = new System.Windows.Forms.TextBox();
            this.RecordTheLastLabel = new System.Windows.Forms.Label();
            this.RecordOnBatteryCheckBox = new System.Windows.Forms.CheckBox();
            this.RecordOnWirelessDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnableGameDVRCheckBox
            // 
            this.EnableGameDVRCheckBox.AutoSize = true;
            this.EnableGameDVRCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableGameDVRCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableGameDVRCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EnableGameDVRCheckBox.Location = new System.Drawing.Point(17, 17);
            this.EnableGameDVRCheckBox.Margin = new System.Windows.Forms.Padding(8);
            this.EnableGameDVRCheckBox.Name = "EnableGameDVRCheckBox";
            this.EnableGameDVRCheckBox.Size = new System.Drawing.Size(225, 24);
            this.EnableGameDVRCheckBox.TabIndex = 0;
            this.EnableGameDVRCheckBox.Text = "Enable Game DVR (Win+G)";
            this.EnableGameDVRCheckBox.UseVisualStyleBackColor = true;
            this.EnableGameDVRCheckBox.CheckedChanged += new System.EventHandler(this.EnableGameDVRCheckBox_CheckedChanged);
            // 
            // EnableAudioCaptureCheckBox
            // 
            this.EnableAudioCaptureCheckBox.AutoSize = true;
            this.EnableAudioCaptureCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableAudioCaptureCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EnableAudioCaptureCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EnableAudioCaptureCheckBox.Location = new System.Drawing.Point(17, 57);
            this.EnableAudioCaptureCheckBox.Margin = new System.Windows.Forms.Padding(8);
            this.EnableAudioCaptureCheckBox.Name = "EnableAudioCaptureCheckBox";
            this.EnableAudioCaptureCheckBox.Size = new System.Drawing.Size(176, 24);
            this.EnableAudioCaptureCheckBox.TabIndex = 1;
            this.EnableAudioCaptureCheckBox.Text = "Enable audio capture";
            this.EnableAudioCaptureCheckBox.UseVisualStyleBackColor = true;
            this.EnableAudioCaptureCheckBox.CheckedChanged += new System.EventHandler(this.EnableAudioCaptureCheckBox_CheckedChanged);
            // 
            // AudioEncodingBitrateLabel
            // 
            this.AudioEncodingBitrateLabel.AutoSize = true;
            this.AudioEncodingBitrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AudioEncodingBitrateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AudioEncodingBitrateLabel.Location = new System.Drawing.Point(13, 137);
            this.AudioEncodingBitrateLabel.Margin = new System.Windows.Forms.Padding(8);
            this.AudioEncodingBitrateLabel.Name = "AudioEncodingBitrateLabel";
            this.AudioEncodingBitrateLabel.Size = new System.Drawing.Size(172, 20);
            this.AudioEncodingBitrateLabel.TabIndex = 2;
            this.AudioEncodingBitrateLabel.Text = "Audio encoding bitrate:";
            // 
            // AudioBitrateComboBox
            // 
            this.AudioBitrateComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.AudioBitrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioBitrateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AudioBitrateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AudioBitrateComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AudioBitrateComboBox.FormattingEnabled = true;
            this.AudioBitrateComboBox.Items.AddRange(new object[] {
            "96",
            "128",
            "160",
            "192"});
            this.AudioBitrateComboBox.Location = new System.Drawing.Point(205, 134);
            this.AudioBitrateComboBox.Margin = new System.Windows.Forms.Padding(8);
            this.AudioBitrateComboBox.Name = "AudioBitrateComboBox";
            this.AudioBitrateComboBox.Size = new System.Drawing.Size(88, 28);
            this.AudioBitrateComboBox.TabIndex = 3;
            this.AudioBitrateComboBox.SelectedIndexChanged += new System.EventHandler(this.AudioBitrateComboBox_SelectedIndexChanged);
            // 
            // kbpsLabel
            // 
            this.kbpsLabel.AutoSize = true;
            this.kbpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kbpsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kbpsLabel.Location = new System.Drawing.Point(309, 137);
            this.kbpsLabel.Margin = new System.Windows.Forms.Padding(8);
            this.kbpsLabel.Name = "kbpsLabel";
            this.kbpsLabel.Size = new System.Drawing.Size(53, 20);
            this.kbpsLabel.TabIndex = 4;
            this.kbpsLabel.Text = "(kbps)";
            // 
            // VideoEncodingBitrateLabel
            // 
            this.VideoEncodingBitrateLabel.AutoSize = true;
            this.VideoEncodingBitrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VideoEncodingBitrateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.VideoEncodingBitrateLabel.Location = new System.Drawing.Point(13, 173);
            this.VideoEncodingBitrateLabel.Margin = new System.Windows.Forms.Padding(8);
            this.VideoEncodingBitrateLabel.Name = "VideoEncodingBitrateLabel";
            this.VideoEncodingBitrateLabel.Size = new System.Drawing.Size(172, 20);
            this.VideoEncodingBitrateLabel.TabIndex = 5;
            this.VideoEncodingBitrateLabel.Text = "Video encoding bitrate:";
            // 
            // kbpsLabel2
            // 
            this.kbpsLabel2.AutoSize = true;
            this.kbpsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kbpsLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kbpsLabel2.Location = new System.Drawing.Point(309, 173);
            this.kbpsLabel2.Margin = new System.Windows.Forms.Padding(8);
            this.kbpsLabel2.Name = "kbpsLabel2";
            this.kbpsLabel2.Size = new System.Drawing.Size(53, 20);
            this.kbpsLabel2.TabIndex = 6;
            this.kbpsLabel2.Text = "(kbps)";
            // 
            // VideoBitrateTextBox
            // 
            this.VideoBitrateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.VideoBitrateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoBitrateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VideoBitrateTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.VideoBitrateTextBox.Location = new System.Drawing.Point(205, 171);
            this.VideoBitrateTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.VideoBitrateTextBox.Name = "VideoBitrateTextBox";
            this.VideoBitrateTextBox.Size = new System.Drawing.Size(88, 26);
            this.VideoBitrateTextBox.TabIndex = 7;
            this.VideoBitrateTextBox.TextChanged += new System.EventHandler(this.VideoBitrateTextBox_TextChanged);
            // 
            // ResizeVideoCheckBox
            // 
            this.ResizeVideoCheckBox.AutoSize = true;
            this.ResizeVideoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResizeVideoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResizeVideoCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ResizeVideoCheckBox.Location = new System.Drawing.Point(17, 209);
            this.ResizeVideoCheckBox.Margin = new System.Windows.Forms.Padding(8);
            this.ResizeVideoCheckBox.Name = "ResizeVideoCheckBox";
            this.ResizeVideoCheckBox.Size = new System.Drawing.Size(115, 24);
            this.ResizeVideoCheckBox.TabIndex = 8;
            this.ResizeVideoCheckBox.Text = "Resize video";
            this.ResizeVideoCheckBox.UseVisualStyleBackColor = true;
            this.ResizeVideoCheckBox.CheckedChanged += new System.EventHandler(this.ResizeVideoCheckBox_CheckedChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Enabled = false;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WidthLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WidthLabel.Location = new System.Drawing.Point(37, 249);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(8);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(54, 20);
            this.WidthLabel.TabIndex = 9;
            this.WidthLabel.Text = "Width:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Enabled = false;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HeightLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeightLabel.Location = new System.Drawing.Point(37, 285);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(8);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(60, 20);
            this.HeightLabel.TabIndex = 10;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.WidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WidthTextBox.Enabled = false;
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WidthTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WidthTextBox.Location = new System.Drawing.Point(205, 247);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(88, 26);
            this.WidthTextBox.TabIndex = 11;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTextBox.Enabled = false;
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HeightTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeightTextBox.Location = new System.Drawing.Point(205, 283);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(88, 26);
            this.HeightTextBox.TabIndex = 12;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // EnableMicrophoneCaptureCheckBox
            // 
            this.EnableMicrophoneCaptureCheckBox.AutoSize = true;
            this.EnableMicrophoneCaptureCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableMicrophoneCaptureCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EnableMicrophoneCaptureCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EnableMicrophoneCaptureCheckBox.Location = new System.Drawing.Point(17, 97);
            this.EnableMicrophoneCaptureCheckBox.Margin = new System.Windows.Forms.Padding(8);
            this.EnableMicrophoneCaptureCheckBox.Name = "EnableMicrophoneCaptureCheckBox";
            this.EnableMicrophoneCaptureCheckBox.Size = new System.Drawing.Size(220, 24);
            this.EnableMicrophoneCaptureCheckBox.TabIndex = 13;
            this.EnableMicrophoneCaptureCheckBox.Text = "Enable microphone capture";
            this.EnableMicrophoneCaptureCheckBox.UseVisualStyleBackColor = true;
            this.EnableMicrophoneCaptureCheckBox.CheckedChanged += new System.EventHandler(this.EnableMicrophoneCaptureCheckBox_CheckedChanged);
            // 
            // ForceSoftwareMFTCheckBox
            // 
            this.ForceSoftwareMFTCheckBox.AutoSize = true;
            this.ForceSoftwareMFTCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForceSoftwareMFTCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForceSoftwareMFTCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ForceSoftwareMFTCheckBox.Location = new System.Drawing.Point(17, 321);
            this.ForceSoftwareMFTCheckBox.Margin = new System.Windows.Forms.Padding(8);
            this.ForceSoftwareMFTCheckBox.Name = "ForceSoftwareMFTCheckBox";
            this.ForceSoftwareMFTCheckBox.Size = new System.Drawing.Size(285, 24);
            this.ForceSoftwareMFTCheckBox.TabIndex = 14;
            this.ForceSoftwareMFTCheckBox.Text = "Force software MFT (16 FPS + VBR)";
            this.ForceSoftwareMFTCheckBox.UseVisualStyleBackColor = true;
            this.ForceSoftwareMFTCheckBox.CheckedChanged += new System.EventHandler(this.ForceSoftwareMFTCheckBox_CheckedChanged);
            // 
            // DisableCursorBlendingCheckBox
            // 
            this.DisableCursorBlendingCheckBox.AutoSize = true;
            this.DisableCursorBlendingCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisableCursorBlendingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DisableCursorBlendingCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DisableCursorBlendingCheckBox.Location = new System.Drawing.Point(17, 361);
            this.DisableCursorBlendingCheckBox.Margin = new System.Windows.Forms.Padding(8);
            this.DisableCursorBlendingCheckBox.Name = "DisableCursorBlendingCheckBox";
            this.DisableCursorBlendingCheckBox.Size = new System.Drawing.Size(190, 24);
            this.DisableCursorBlendingCheckBox.TabIndex = 15;
            this.DisableCursorBlendingCheckBox.Text = "Disable cursor blending";
            this.DisableCursorBlendingCheckBox.UseVisualStyleBackColor = true;
            this.DisableCursorBlendingCheckBox.CheckedChanged += new System.EventHandler(this.DisableCursorBlendingCheckBox_CheckedChanged);
            // 
            // BackgroundRecordingCheckBox
            // 
            this.BackgroundRecordingCheckBox.AutoSize = true;
            this.BackgroundRecordingCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundRecordingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundRecordingCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundRecordingCheckBox.Location = new System.Drawing.Point(17, 401);
            this.BackgroundRecordingCheckBox.Margin = new System.Windows.Forms.Padding(8);
            this.BackgroundRecordingCheckBox.Name = "BackgroundRecordingCheckBox";
            this.BackgroundRecordingCheckBox.Size = new System.Drawing.Size(252, 24);
            this.BackgroundRecordingCheckBox.TabIndex = 16;
            this.BackgroundRecordingCheckBox.Text = "Record game in the background";
            this.BackgroundRecordingCheckBox.UseVisualStyleBackColor = true;
            this.BackgroundRecordingCheckBox.CheckedChanged += new System.EventHandler(this.BackgroundRecordingCheckBox_CheckedChanged);
            // 
            // RecordTheLastTextBox
            // 
            this.RecordTheLastTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.RecordTheLastTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecordTheLastTextBox.Enabled = false;
            this.RecordTheLastTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RecordTheLastTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RecordTheLastTextBox.Location = new System.Drawing.Point(205, 441);
            this.RecordTheLastTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.RecordTheLastTextBox.Name = "RecordTheLastTextBox";
            this.RecordTheLastTextBox.Size = new System.Drawing.Size(88, 26);
            this.RecordTheLastTextBox.TabIndex = 18;
            this.RecordTheLastTextBox.TextChanged += new System.EventHandler(this.RecordTheLastTextBox_TextChanged);
            // 
            // RecordTheLastLabel
            // 
            this.RecordTheLastLabel.AutoSize = true;
            this.RecordTheLastLabel.Enabled = false;
            this.RecordTheLastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RecordTheLastLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RecordTheLastLabel.Location = new System.Drawing.Point(37, 443);
            this.RecordTheLastLabel.Margin = new System.Windows.Forms.Padding(8);
            this.RecordTheLastLabel.Name = "RecordTheLastLabel";
            this.RecordTheLastLabel.Size = new System.Drawing.Size(121, 20);
            this.RecordTheLastLabel.TabIndex = 17;
            this.RecordTheLastLabel.Text = "Record the last:";
            // 
            // RecordOnBatteryCheckBox
            // 
            this.RecordOnBatteryCheckBox.AutoSize = true;
            this.RecordOnBatteryCheckBox.Enabled = false;
            this.RecordOnBatteryCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordOnBatteryCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordOnBatteryCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RecordOnBatteryCheckBox.Location = new System.Drawing.Point(41, 479);
            this.RecordOnBatteryCheckBox.Margin = new System.Windows.Forms.Padding(8);
            this.RecordOnBatteryCheckBox.Name = "RecordOnBatteryCheckBox";
            this.RecordOnBatteryCheckBox.Size = new System.Drawing.Size(191, 24);
            this.RecordOnBatteryCheckBox.TabIndex = 19;
            this.RecordOnBatteryCheckBox.Text = "Record while on battery";
            this.RecordOnBatteryCheckBox.UseVisualStyleBackColor = true;
            this.RecordOnBatteryCheckBox.CheckedChanged += new System.EventHandler(this.RecordOnBatteryCheckBox_CheckedChanged);
            // 
            // RecordOnWirelessDisplayCheckBox
            // 
            this.RecordOnWirelessDisplayCheckBox.AutoSize = true;
            this.RecordOnWirelessDisplayCheckBox.Enabled = false;
            this.RecordOnWirelessDisplayCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordOnWirelessDisplayCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordOnWirelessDisplayCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RecordOnWirelessDisplayCheckBox.Location = new System.Drawing.Point(41, 519);
            this.RecordOnWirelessDisplayCheckBox.Margin = new System.Windows.Forms.Padding(8);
            this.RecordOnWirelessDisplayCheckBox.Name = "RecordOnWirelessDisplayCheckBox";
            this.RecordOnWirelessDisplayCheckBox.Size = new System.Drawing.Size(270, 24);
            this.RecordOnWirelessDisplayCheckBox.TabIndex = 20;
            this.RecordOnWirelessDisplayCheckBox.Text = "Record while using wireless display";
            this.RecordOnWirelessDisplayCheckBox.UseVisualStyleBackColor = true;
            this.RecordOnWirelessDisplayCheckBox.CheckedChanged += new System.EventHandler(this.RecordOnWirelessDisplayCheckBox_CheckedChanged);
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Enabled = false;
            this.SecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SecondsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SecondsLabel.Location = new System.Drawing.Point(309, 443);
            this.SecondsLabel.Margin = new System.Windows.Forms.Padding(8);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(79, 20);
            this.SecondsLabel.TabIndex = 21;
            this.SecondsLabel.Text = "(seconds)";
            // 
            // GameDVR_ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(403, 562);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.RecordOnWirelessDisplayCheckBox);
            this.Controls.Add(this.RecordOnBatteryCheckBox);
            this.Controls.Add(this.RecordTheLastTextBox);
            this.Controls.Add(this.RecordTheLastLabel);
            this.Controls.Add(this.BackgroundRecordingCheckBox);
            this.Controls.Add(this.DisableCursorBlendingCheckBox);
            this.Controls.Add(this.ForceSoftwareMFTCheckBox);
            this.Controls.Add(this.EnableMicrophoneCaptureCheckBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.ResizeVideoCheckBox);
            this.Controls.Add(this.VideoBitrateTextBox);
            this.Controls.Add(this.kbpsLabel2);
            this.Controls.Add(this.VideoEncodingBitrateLabel);
            this.Controls.Add(this.kbpsLabel);
            this.Controls.Add(this.AudioBitrateComboBox);
            this.Controls.Add(this.AudioEncodingBitrateLabel);
            this.Controls.Add(this.EnableAudioCaptureCheckBox);
            this.Controls.Add(this.EnableGameDVRCheckBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameDVR_ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game DVR Config";
            this.Load += new System.EventHandler(this.GameDVR_ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EnableGameDVRCheckBox;
        private System.Windows.Forms.CheckBox EnableAudioCaptureCheckBox;
        private System.Windows.Forms.Label AudioEncodingBitrateLabel;
        private System.Windows.Forms.ComboBox AudioBitrateComboBox;
        private System.Windows.Forms.Label kbpsLabel;
        private System.Windows.Forms.Label VideoEncodingBitrateLabel;
        private System.Windows.Forms.Label kbpsLabel2;
        private System.Windows.Forms.TextBox VideoBitrateTextBox;
        private System.Windows.Forms.CheckBox ResizeVideoCheckBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.CheckBox EnableMicrophoneCaptureCheckBox;
        private System.Windows.Forms.CheckBox ForceSoftwareMFTCheckBox;
        private System.Windows.Forms.CheckBox DisableCursorBlendingCheckBox;
        private System.Windows.Forms.CheckBox BackgroundRecordingCheckBox;
        private System.Windows.Forms.TextBox RecordTheLastTextBox;
        private System.Windows.Forms.Label RecordTheLastLabel;
        private System.Windows.Forms.CheckBox RecordOnBatteryCheckBox;
        private System.Windows.Forms.CheckBox RecordOnWirelessDisplayCheckBox;
        private System.Windows.Forms.Label SecondsLabel;
    }
}

