using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;


namespace Skybeje.Speaker.Util
{

    public static class DeviceUtil
    {


        /// <summary>
        /// デバイス一覧の取得
        /// </summary>
        /// <returns></returns>
        public static List<string> GetDevices()
        {

            List<string> deviceList = new List<string>();
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                var capabilities = WaveOut.GetCapabilities(i);
                deviceList.Add(capabilities.ProductName);
            }
            return deviceList;
        }



        /// <summary>
        /// 音声の再生
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="index"></param>
        public static void PlaySound(string filePath, int index)
        {
            var waveReader = new NAudio.Wave.WaveFileReader(filePath);

            var waveOut = new NAudio.Wave.WaveOut();
            waveOut.DeviceNumber = index;
            waveOut.PlaybackStopped += (sender, e) =>
            {
                waveReader.Close();
            };
            waveOut.Init(waveReader);
            waveOut.Play();
        }


        /// <summary>
        /// 音声の再生
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="index"></param>
        public static void PlaySound(byte[] bytes, int index)
        {
            MemoryStream stream = new MemoryStream(bytes);

            var waveReader = new NAudio.Wave.WaveFileReader(stream);

            var waveOut = new NAudio.Wave.WaveOut();
            waveOut.DeviceNumber = index;
            waveOut.PlaybackStopped += (sender, e) =>
            {
                waveReader.Close();
                stream.Close();
            };

            waveOut.Init(waveReader);
            waveOut.Play();
        }


    }

}
