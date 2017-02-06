using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace e46VideoConverter {
    public partial class Converting : UserControl {
        private static Converting _instance;
        internal static Converting Instance {
            get {
                if (_instance == null) _instance = new Converting();
                return _instance;
            }
        }

        public Converting() {
            InitializeComponent();
            saveFileDialog1.Filter = "MP4 Video Files | *.mp4";
            saveFileDialog1.DefaultExt = "mp4";
        }

        private void button1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                textBox1.Text = openFileDialog1.FileName;
                button2.Enabled = true;
            }
            else {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (File.Exists(openFileDialog1.FileName))
                StartConvert();
            else
                MessageBox.Show("Ton fichier n'existe plus fieu.");
        }

        private void button3_Click(object sender, EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                textBox2.Text = saveFileDialog1.FileName;
                button3.Enabled = true;
            }
            else button3.Enabled = false;
        }

        private void StartConvert() {
            if (File.Exists(openFileDialog1.FileName)) {
                string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg64.exe");

                Cursor = Cursors.WaitCursor;
                button3.Enabled = false;

                ProcessStartInfo startInfo = new ProcessStartInfo {
                    FileName = ffmpegPath,
                    Arguments = string.Join(" ", new[] { "-i", $"\"{openFileDialog1.FileName}\"", "-r", "25", $"\"{saveFileDialog1.FileName}\"", "-loglevel debug" }),
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                try {
                    using (Process process = new Process { StartInfo = startInfo })
                    using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                    using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false)) {
                        process.OutputDataReceived += (sender, e) => {
                            if (e.Data == null)
                                outputWaitHandle.Set();
                            else {
                                Progress(e.Data);
                            }
                        };
                        process.ErrorDataReceived += (sender, e) => {
                            if (e.Data == null)
                                errorWaitHandle.Set();
                            else if (e.Data.Contains("SoundHandler")) {
                                int test = 2;
                            }
                            else if (e.Data.Contains("frame="))
                                Progress(e.Data);
                        };

                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        process.WaitForExit();

                        bool result = outputWaitHandle.WaitOne() && errorWaitHandle.WaitOne();

                        Cursor = Cursors.Default;

                        if (result) {
                            if (!process.HasExited)
                                MessageBox.Show($"process ({Path.GetFileName(ffmpegPath)}) hasn't exited", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show("Video converted !");

                            Console.WriteLine($"Exit Code {process.ExitCode} for {Path.GetFileName(ffmpegPath)}");
                        }
                        else MessageBox.Show($"No more signal received from {Path.GetFileName(ffmpegPath)} process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) {
                    Cursor = Cursors.Default;
                    MessageBox.Show($"An error occured : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show($"Path : {ffmpegPath}");
                }
            }
            else MessageBox.Show("Input file doesn't exist.");
        }

        private void Progress(string progressString) {
            Console.WriteLine(progressString);
        }
    }
}