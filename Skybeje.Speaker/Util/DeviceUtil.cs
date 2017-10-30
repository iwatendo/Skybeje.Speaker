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
        public static void PlaySound_VoiceText(Stream stream, int index)
        {
            var waveReader = new NAudio.Wave.WaveFileReader(stream);

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
        public static void PlaySound_AITalk(Stream stream, int index)
        {

            var format = new WaveFormat(16000, 16, 1);
            var provider = new BufferedWaveProvider(format);

            using (BinaryReader reader = new BinaryReader(stream))
            {
                Byte[] lnByte = reader.ReadBytes(1 * 1024 * 1024 * 10);
                var cnByte = ConvertBytesEndian(lnByte);
                provider.AddSamples(cnByte, 0, cnByte.Length);
            }

            var waveOut = new NAudio.Wave.WaveOut();

            waveOut.DeviceNumber = index;
            waveOut.PlaybackStopped += (sender, e) => { stream.Close(); };
            waveOut.Init(provider);
            waveOut.Play();
        }


        /// <summary>
        /// Big Endian→Little Endianに変換
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
            return newBytes;
        }

    }

}
