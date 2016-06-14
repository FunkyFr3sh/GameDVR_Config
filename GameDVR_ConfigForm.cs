using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GameDVR_Config
{
    public partial class GameDVR_ConfigForm : Form
    {
        const string keyName = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\GameDVR";

        public GameDVR_ConfigForm()
        {
            InitializeComponent();
        }

        private void GameDVR_ConfigForm_Load(object sender, EventArgs e)
        {
            EnableGameDVRCheckBox.Checked = GetBool("AppCaptureEnabled", true);
            EnableAudioCaptureCheckBox.Checked = GetBool("AudioCaptureEnabled", true);
            EnableMicrophoneCaptureCheckBox.Checked = GetBool("MicrophoneCaptureEnabled", false);
            int audioBitrate = GetInt("AudioEncodingBitrate", 192000);
            try { AudioBitrateComboBox.SelectedItem = (audioBitrate / 1000).ToString(); }
            finally
            {
                if (AudioBitrateComboBox.SelectedIndex == -1)
                    AudioBitrateComboBox.SelectedIndex = 3;
            }
            int videoBitrate = GetInt("CustomVideoEncodingBitrate", 4000000);
            VideoBitrateTextBox.Text = (videoBitrate / 1000).ToString();
            ResizeVideoCheckBox.Checked = GetInt("VideoEncodingResolutionMode", 2) == 0;
            WidthTextBox.Text = GetInt("CustomVideoEncodingWidth", 1280).ToString();
            HeightTextBox.Text = GetInt("CustomVideoEncodingHeight", 720).ToString();
            ForceSoftwareMFTCheckBox.Checked = GetBool("ForceSoftwareMFT", false);
            DisableCursorBlendingCheckBox.Checked = GetBool("DisableCursorBlending", false);
            BackgroundRecordingCheckBox.Checked = GetBool("HistoricalCaptureEnabled", false);
            RecordTheLastTextBox.Text = GetInt("HistoricalBufferLength", 15).ToString();
            RecordOnBatteryCheckBox.Checked = GetBool("HistoricalCaptureOnBatteryAllowed", true);
            RecordOnWirelessDisplayCheckBox.Checked = GetBool("HistoricalCaptureOnWirelessDisplayAllowed", true);

            SetInt("VideoEncodingBitrateMode", 0);
        }

        private void EnableGameDVRCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBool("AppCaptureEnabled", EnableGameDVRCheckBox.Checked);
        }

        private void EnableAudioCaptureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBool("AudioCaptureEnabled", EnableAudioCaptureCheckBox.Checked);
        }

        private void EnableMicrophoneCaptureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBool("MicrophoneCaptureEnabled", EnableMicrophoneCaptureCheckBox.Checked);
        }

        private void AudioBitrateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetInt("AudioEncodingBitrate", Convert.ToInt32(AudioBitrateComboBox.SelectedItem) * 1000);
        }

        private void VideoBitrateTextBox_TextChanged(object sender, EventArgs e)
        {
            int videoBitrate;
            try { videoBitrate = Convert.ToInt32(VideoBitrateTextBox.Text) * 1000; }
            catch { videoBitrate = 4000000; }

            SetInt("CustomVideoEncodingBitrate", videoBitrate > 30000000 ? 30000000 : videoBitrate);
        }

        private void ResizeVideoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetInt("VideoEncodingResolutionMode", ResizeVideoCheckBox.Checked ? 0 : 2);
            HeightLabel.Enabled = WidthLabel.Enabled = WidthTextBox.Enabled = HeightTextBox.Enabled = ResizeVideoCheckBox.Checked;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            int width;
            try { width = Convert.ToInt32(WidthTextBox.Text); }
            catch { width = 1280; }

            SetInt("CustomVideoEncodingWidth", width > 1920 ? 1920 : width);
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            int height;
            try { height = Convert.ToInt32(HeightTextBox.Text); }
            catch { height = 720; }

            SetInt("CustomVideoEncodingHeight", height > 1080 ? 1080 : height);
        }

        private void ForceSoftwareMFTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBool("ForceSoftwareMFT", ForceSoftwareMFTCheckBox.Checked);
            SetBool("AllowSoftwareEncode", ForceSoftwareMFTCheckBox.Checked);
        }

        private void DisableCursorBlendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBool("DisableCursorBlending", DisableCursorBlendingCheckBox.Checked);
        }

        private void BackgroundRecordingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBool("HistoricalCaptureEnabled", BackgroundRecordingCheckBox.Checked);
            RecordTheLastLabel.Enabled = RecordTheLastTextBox.Enabled = RecordOnBatteryCheckBox.Enabled = 
                RecordOnWirelessDisplayCheckBox.Enabled = SecondsLabel.Enabled = BackgroundRecordingCheckBox.Checked;
        }

        private void RecordTheLastTextBox_TextChanged(object sender, EventArgs e)
        {
            int seconds;
            try { seconds = Convert.ToInt32(RecordTheLastTextBox.Text); }
            catch { seconds = 15; }

            SetInt("HistoricalBufferLength", seconds);
        }

        private void RecordOnBatteryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBool("HistoricalCaptureOnBatteryAllowed", RecordOnBatteryCheckBox.Checked);
        }

        private void RecordOnWirelessDisplayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetBool("HistoricalCaptureOnWirelessDisplayAllowed", RecordOnWirelessDisplayCheckBox.Checked);
        }

        int GetInt(string valueName, int defaultValue)
        {
            try { return (int)Registry.GetValue(keyName, valueName, defaultValue.ToString()); }
            catch { return defaultValue; }
        }

        bool GetBool(string valueName, bool defaultValue)
        {
            try { return (int)Registry.GetValue(keyName, valueName, defaultValue ? "1" : "0") == 1; }
            catch { return defaultValue; }
        }

        void SetInt(string valueName, int value)
        {
            Registry.SetValue(keyName, valueName, value);
        }

        void SetBool(string valueName, bool value)
        {
            Registry.SetValue(keyName, valueName, value ? 1 : 0);
        }

    }
}
