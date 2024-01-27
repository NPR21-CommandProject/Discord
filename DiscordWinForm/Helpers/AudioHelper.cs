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
        static ushort timeOfRecording;

        static AudioHelper()
        {
            Recorder = new WaveInEvent();
            Recorder.WaveFormat = new WaveFormat(44100, 16, 1);
            Recorder.DataAvailable += (object sender, WaveInEventArgs e) =>
                Buffer.BlockCopy(e.Buffer, 0, AudioBuffer, 0, e.BytesRecorded);
            ChangeTimings(500);
        }


        static public async Task Record(ushort TimeOfRecordingMilliseconds = 0)
        {
            if(TimeOfRecordingMilliseconds != 0 && TimeOfRecordingMilliseconds != timeOfRecording)
            {
                ChangeTimings(TimeOfRecordingMilliseconds);
            }
            
            AudioBuffer = new byte[RecordSize];
            Recorder.StartRecording();
            await Task.Delay(timeOfRecording);
            Recorder.StopRecording();
        }

        static public async Task RunAudioMessageAsync(NetworkStream message)
        {
            WaveOutEvent player = new WaveOutEvent();
            player.Init(ConvertToRawSourceWaveStream(message));
            player.Volume = 1;
            player.Play();
            while(player.PlaybackState == PlaybackState.Playing) { await Task.Delay(timeOfRecording); }
        }

        public static void ChangeTimings(ushort TimeOfRecordingMilliseconds)
        {
            if (TimeOfRecordingMilliseconds != timeOfRecording)
            {
                timeOfRecording = TimeOfRecordingMilliseconds;
                Recorder.BufferMilliseconds = timeOfRecording;
                RecordSize = Recorder.WaveFormat.AverageBytesPerSecond * 1;
            }
             
        }

        static public RawSourceWaveStream ConvertToRawSourceWaveStream(NetworkStream data)
        {
            byte[] buffer = new byte[RecordSize];
            data.Read(buffer, 0, buffer.Length);
            RawSourceWaveStream raw = new RawSourceWaveStream(buffer, 0, buffer.Length, Recorder.WaveFormat);
            return raw;
        }
    }
}