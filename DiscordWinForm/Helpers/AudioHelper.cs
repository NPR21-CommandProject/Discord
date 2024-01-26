using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using NAudio;
using NAudio.Wave;

namespace DiscordWinForm.Helpers
{
    static public class AudioHelper
    {
        static private WaveInEvent Recorder;
        static public byte[] AudioBuffer;
        static int RecordSize;

        static AudioHelper()
        {
            Recorder = new WaveInEvent();
            Recorder.WaveFormat = new WaveFormat(20000, 16, 1);
            RecordSize = Recorder.WaveFormat.AverageBytesPerSecond / 4;
            Recorder.DataAvailable += (object sender, WaveInEventArgs e) =>
                Buffer.BlockCopy(e.Buffer, 0, AudioBuffer, 0, e.BytesRecorded); ;
        }


        static public void Record(ushort TimeOfRecordingMilliseconds)
        {
            AudioBuffer = new byte[RecordSize];
            Recorder.StartRecording();
            Thread.Sleep(TimeOfRecordingMilliseconds);
            Recorder.StopRecording();
        }

        static public async Task RunAudioMessageAsync(NetworkStream message )
        {
            WaveOutEvent player = new WaveOutEvent();
            player.Init(ConvertToRawSourceWaveStream(message));
            player.Play();
        } 

        static public RawSourceWaveStream ConvertToRawSourceWaveStream(NetworkStream data)
        {
            byte[] buffer = new byte[data.Length];
            data.ReadAsync(buffer, 0, buffer.Length);
            using(MemoryStream ms = new MemoryStream(buffer)) {
                RawSourceWaveStream raw = new RawSourceWaveStream(ms, Recorder.WaveFormat);
                return raw;
            }
        }
    }
}
