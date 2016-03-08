using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.Wave;  //part of the framework NAudio which makes audio projects easier; for more =>http://naudio.codeplex.com/
using System.Timers;

namespace LockInAmp
{
    public partial class Form1 : Form
    {
        WaveOutEvent waveOut = new WaveOutEvent();//class which outputs audio using a background thread 
        WaveInEvent recorder= new WaveInEvent();//same as above for audio input
        SineWaveProvider32 sineWaveProvider = new SineWaveProvider32();//custom class to write buffers with sine waves
        int frequency1 = 0, frequency2 = 0, phaseshift = 0, index1 = 0, index2 = 0, delta1 = 0, delta2 = 0;

        const int PLOT_SIZE = 8820;//defines number of plot points in the GUI chart
        float[] LUT = new float[PLOT_SIZE];//sine wave lookup table for the GUI thread
        
        float[] buffer_in = new float[PLOT_SIZE];//this buffer takes the microphone input everytime there is data
        float[] buffer_in2 = new float[PLOT_SIZE];//this buffer is a copy from the first to pass onto the GUI thread in a threadsafe way
        System.Windows.Forms.Timer plot_update_input;//a timer that updates the chart for the microphone input
        private static int bufferindex;        

        public Form1()
        {
            InitializeComponent();
            plot_update_input = new System.Windows.Forms.Timer();
            plot_update_input.Interval = 200;//timer elapses every 200ms
            plot_update_input.Tick += new EventHandler(plot_input_refresh);//plot_input_refresh gets called everytime the timer elapses (eventhandler)

            //set up lookup table for sine waves
            for (int i = 0; i < PLOT_SIZE; i++)
            {
                LUT[i] = (float)Math.Sin((2 * Math.PI * i) / PLOT_SIZE);
            }
        }

        private void StartButton(object sender, MouseEventArgs e)
        {                    
            // set up the recorder
            recorder.WaveFormat = new WaveFormat(44100, 16, 1);
            recorder.BufferMilliseconds = 300;
            recorder.DataAvailable += RecorderOnDataAvailable;

            //start playing and recording
            sineWaveProvider.Frequency1 = frequency1;
            sineWaveProvider.Frequency2 = frequency2;
            if (waveOut.PlaybackState != NAudio.Wave.PlaybackState.Playing)
            {
                waveOut.Init(sineWaveProvider);
                waveOut.Play();
                recorder.StartRecording();
                plot_update_input.Start();
            }           
        }

        private void StopButton(object sender, EventArgs e)
        {
            if (waveOut.PlaybackState == NAudio.Wave.PlaybackState.Playing)//checks if signals are running
            {
                waveOut.Stop();
                waveOut.Dispose();
                recorder.StopRecording();
                recorder.Dispose();
            }
        }

        private void RecorderOnDataAvailable(object sender, WaveInEventArgs waveInEventArgs)//gets called everytime a buffer has been filled by the microphone
        {
            byte[] buffer = waveInEventArgs.Buffer;
            float sample32 = 0;

            for (int index = 0; index < waveInEventArgs.BytesRecorded; index += 2)
            {
                short sample = (short)((buffer[index + 1] << 8) |//since microphone data comes in a pair of bytes, we have to bitshift in order to convert to short
                                           buffer[index]);
                if (sample == 0) sample32 = 0;
                if (sample > 0) sample32 = sample / 32767f;//data is converted to float and is guaranteed to be between 1 and -1
                if (sample < 0) sample32 = sample / 32768f;
                lock (buffer_in2)//buffer_in2 is also used to update the GUI chart, so it has to be locked to ensure thread-safety
                {
                    if (bufferindex == 0)
                    {
                        Array.Clear(buffer_in2, 0, buffer_in2.Length);
                        buffer_in2 = (float[])buffer_in.Clone();
                        Array.Clear(buffer_in,0,buffer_in.Length);
                        plot_update_input.Enabled = true;//timer is reset to start again                      
                    } 
                }
                buffer_in[bufferindex] = sample32;
                bufferindex=(bufferindex+1)%PLOT_SIZE;//bufferindex is limited to PLOT_SIZE
            }
        }

        private void FrequencySlider1_ValueChanged(object sender, EventArgs e)//updates frequency for stereo left
        {
            frequency1 = (int)FrequencySlider1.Value;
            frequency_num1.Text = FrequencySlider1.Value.ToString();
            sineWaveProvider.Frequency1 = frequency1;
            refresh_plot_output();
        }

        private void FrequencySlider2_ValueChanged(object sender, EventArgs e)//updates frequency for stereo right
        {
            frequency2 = (int)FrequencySlider2.Value;
            frequency_num2.Text = FrequencySlider2.Value.ToString();
            sineWaveProvider.Frequency2 = frequency2;
            refresh_plot_output();
        }

        private void frequency_num1_ValueChanged(object sender, EventArgs e)//updates frequency for stereo left
        {
            frequency1 = (int)frequency_num1.Value;
            FrequencySlider1.Value = (int)frequency1;
            sineWaveProvider.Frequency1 = frequency1;
            refresh_plot_output();
        }

        private void frequency_num2_ValueChanged(object sender, EventArgs e)//updates frequency for stereo right
        {
            frequency2 = (int)frequency_num2.Value;
            FrequencySlider2.Value = frequency2;
            sineWaveProvider.Frequency2 = frequency2;
            refresh_plot_output();
        }

        private void phaseshift_slider_ValueChanged(object sender, EventArgs e)//updates the phaseshift between stereo right and left
        {
            phaseshift = (int)phaseshift_slider.Value;
            phaseshift_num.Text = phaseshift_slider.Value.ToString();
            sineWaveProvider.PhaseShift = phaseshift;
            refresh_plot_output();
        }

        private void phaseshift_num_ValueChanged(object sender, EventArgs e)//updates the phaseshift between stereo right and left
        {
            phaseshift = (int)phaseshift_num.Value;
            phaseshift_slider.Value = phaseshift;
            sineWaveProvider.PhaseShift = phaseshift;
            refresh_plot_output();
        }

        public void refresh_plot_output()//plots the data for stereo left and right according to frequencies and phasehift; gets updated on changes
        {
            output_plot.Series["Stereo Left"].Points.Clear();
            output_plot.Series["Stereo Right"].Points.Clear();

            for (int i = 0; i < PLOT_SIZE; i++)
            {
                if (plot_left.Checked) output_plot.Series["Stereo Left"].Points.AddXY(i, LUT[index1]);
                if (plot_right.Checked) output_plot.Series["Stereo Right"].Points.AddXY(i, LUT[(index2 + (phaseshift * PLOT_SIZE / 360)) % PLOT_SIZE]);
                delta1 = (int)(PLOT_SIZE * frequency1 / 44100);
                index1 = (index1 + delta1) % PLOT_SIZE;
                delta2 = (int)(PLOT_SIZE * frequency2 / 44100);
                index2 = (index2 + delta2) % PLOT_SIZE;
            }
        }

        public void plot_input_refresh(object source, EventArgs e)//gets called every 200ms through the timer elapsed eventhandler
        {
            output_plot.Series["Mic Input"].Points.Clear();
            if (plot_input.Checked)
            {
                lock (buffer_in2)
                {
                    for (int i = 0; i < PLOT_SIZE; i++)
                    {
                        output_plot.Series["Mic Input"].Points.AddXY(i, buffer_in2[i]);
                    }
                }
            }
        }

        private void plot_left_CheckStateChanged(object sender, EventArgs e) //enables plotting stereo left signal
        {
            refresh_plot_output();
        }

        private void plot_right_CheckStateChanged(object sender, EventArgs e)//enables plotting stereo right signal
        {
            refresh_plot_output();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (waveOut.PlaybackState == NAudio.Wave.PlaybackState.Playing) //checks if signals are running
            {
                waveOut.Stop();
                waveOut.Dispose();
                recorder.StopRecording();
                recorder.Dispose();
            }
            plot_update_input.Stop();
            plot_update_input = null;
            recorder = null;
            waveOut = null;
        }     
    }

    public class SineWaveProvider32 : WaveProvider32
    {
        int sample;
        const int LUT_SIZE = 2205;
        float[] LUT = new float[LUT_SIZE];  // sine wave lookup table

        public SineWaveProvider32()
        {
            SetWaveFormat(44100, 2); //sets Samplerate and Number of output channels
            for (int i = 0; i < LUT_SIZE; i++)
            {
                LUT[i] = (float)Math.Sin((2 * Math.PI * i) / LUT_SIZE);
            }
        }

        public int Frequency1 { get; set; }
        public int Frequency2 { get; set; }
        public int PhaseShift { get; set; }

        public override int Read(float[] buffer, int offset, int sampleCount) //writes output buffer
        {
            int sampleRate = WaveFormat.SampleRate; //44100 Hz result in 44100 samples per second

            int index1 = 0, index2 = 0; // current index into LUT (integer + fraction)
            int delta1 = 0, delta2 = 0; ; // delta controls output frequency

            for (int n = 0; n < sampleCount; n += 2)
            {
                buffer[n + offset] = LUT[index1]; //writes output for stereo left
                buffer[n + offset + 1] = LUT[(index2+(PhaseShift*LUT_SIZE/360))%LUT_SIZE];//writes ouput for stereo right with user-defined phaseshift
                delta1 = (int)(LUT_SIZE * Frequency1 / sampleRate);
                index1 = (index1 + delta1) % LUT_SIZE;
                delta2 = (int)(LUT_SIZE * Frequency2 / sampleRate);
                index2 = (index2 + delta2) % LUT_SIZE;
                sample++;
                if (sample >= sampleRate)
                    sample = 0;
            }
            return sampleCount;
        }
    }
}
