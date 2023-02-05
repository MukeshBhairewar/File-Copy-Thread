using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FileCopy_Thread
{
    /// <summary>
    /// Form1 Class used for operation of windows form.
    /// </summary>
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    // Variable declaration.
    public  static bool  yes;
    public static string filePath = string.Empty;
    public static string folderPath = string.Empty;
    public static string sourcePath = string.Empty;
    public static long copied;
    public static bool repeatFolderPath;
    public static int Progresspercentage = 0;
    public DateTime date_time_now;
    
        
        /// <summary>
        /// Destinationbutton Method used for Selecting the destination path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DestinationButton(object sender, EventArgs e)
        {
                using (var folderpath = new FolderBrowserDialog())
                {
                    DialogResult result = folderpath.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderpath.SelectedPath))
                    {
                        folderPath = folderpath.SelectedPath;
                        destinationtextbox.Text = folderpath.SelectedPath;
                    }
                }
        }

        /// <summary>
        /// Cancelbutton Method are used for cancel the operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            yes = false;
            InvokeThread();
            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Do you want to cancel?", "Cancel",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning,
                     MessageBoxDefaultButton.Button2);

            if (cancel == DialogResult.Yes)
            {
                if (File.Exists(Path.Combine(folderPath, sourcePath)))
                {
                    File.Delete((Path.Combine(folderPath, sourcePath)));
                    timeshow.Text ="00";
                    progressStatus.Text = "00";
                    bytesshow.Text = "00";
                    progressBar1.Value = 0;
                   Size = new Size(790, 206);
                }
            }

        }
        
        /// <summary>
        /// StartButton method used for excute the operation of file copy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StartButtonClick(object sender, EventArgs e)
        {
            if (StartButton.Text == "Start")
            {
              
                progressBar1.Visible = true;
                Size = new Size(766, 300);
                yes = true;
                InvokeThread();
            }

        }

        /// <summary>
        /// SourceButton Method are used for selecting file path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SourceButton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                sourcetextbox.Text = openFileDialog.FileName;
            }
        }

     /// <summary>
     /// DoProgress Method Used for progressbar. 
     /// </summary>
     public void DoProgress()
     {
            // If elseif block arer used to find file postion and display bytes copied
            if (copied >= Constant.OneTeraByteIntoByte)
            {
                copied = copied / Constant.OneTeraByteIntoByte;
               bytesshow.Text = string.Format("{0}mb", copied.ToString("0"));
            }
            else if (copied >= Constant.OneGigaByteIntoByte)
            {
                copied = copied / Constant.OneGigaByteIntoByte;
                bytesshow.Text = string.Format("{0}Gb", copied.ToString("0"));
            }
            else if (copied >= Constant.OneMegaByteIntoByte)
            {
                copied = copied / Constant.OneMegaByteIntoByte;
                bytesshow.Text = string.Format("{0}Mb", +copied);
            }
            else if (copied > Constant.OneKiloByteIntoByte)
            {
                copied = copied / Constant.OneKiloByteIntoByte;
                bytesshow.Text = string.Format("{0}kb", copied.ToString("0"));

            }

            progressBar1.Value=Progresspercentage;
            // ProgressStatuslabel are used for show progress in percentage
            progressStatus.Text = progressBar1.Value.ToString() + "%";

            // if block are used to find remaning time of filecopy
            if ( Progresspercentage >= 1)
            {
                DateTime date_time_Period1End = DateTime.Now;
                TimeSpan time_span = date_time_Period1End - date_time_now;
                double totalSeconds = (double)(((100 - Progresspercentage) * time_span.Seconds) / Progresspercentage);
                RemainingTimeCalculation objReminingTime = new RemainingTimeCalculation();
                double remainingDay = objReminingTime.CalculateDay(totalSeconds);
                double remainingHour = objReminingTime.CalculateHour(totalSeconds);
                double remainingMinute = objReminingTime.CalculateMinute(totalSeconds);
                double remainingSecond = objReminingTime.CalculateSeconds(totalSeconds);
                double convertedDay = Math.Floor(remainingDay);

                // For show value greater than 0.
                if (convertedDay >= 0)
                {
                    timeshow.Text = string.Format("{0}day", convertedDay.ToString("0"));
                }

                // Math.Floor Use for remove decimal percision.
                double convertedHour = Math.Floor(remainingHour);

                // For show value greater than 0.
                if (convertedHour >= 0)
                {
                    timeshow.Text = string.Format("{0}hour", convertedHour.ToString("0"));
                }

                // Math.Floor Use for remove decimal percision.
                double convertedMinute = Math.Floor(remainingMinute);

                // For show value greater than 0.

                if (convertedMinute >= 0)
                {
                    timeshow.Text = string.Format("{0}min", convertedMinute.ToString("0"));
                }

                // For show value greater than 0
                if (remainingSecond >= 0)
                {
                    timeshow.Text = string.Format("{0}sec", remainingSecond.ToString("0"));
                }

            }
            if (progressBar1.Value == 100)
            {
                // Message is display when file copy is done.
                MessageBox.Show("File Copied Sucessfully");
                progressBar1.Value = 0;
            }
     }

        /// <summary>
        /// Delegate is used to invoke the method from thread.
        /// </summary>
        public delegate void UpdateUi();
        
        /// <summary>
        /// InvokeProgressbar method is used for update progress value.
        /// </summary>
        public void InvokeProgessbar()
        {
            if(InvokeRequired)
            {
                Invoke(new UpdateUi(DoProgress));
            }
        }

        /// <summary>
        /// CopyFile Method are used to Copy file to destination folder
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="folderPath"></param>
        /// <param name="e"></param>
        public void CopyFile()
        {
            try
            {
                string source = filePath;
                string destination = folderPath;
                Form1.FileValidationMethod(source, destination);
                FileInfo fileInfo = new FileInfo(source);
                sourcePath = fileInfo.Name;
                FileStream fsOut = new FileStream(Path.Combine(destination, fileInfo.Name), FileMode.Create);
                FileStream fsIn = new FileStream(source, FileMode.Open);
                byte[] buffer = new byte[1048756];
                
                    int readByte;
                    while ((readByte = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                    { 
                    if(yes== false)
                    {
                        fsIn.Close();
                        fsOut.Close();
                        return;
                    }
                        fsOut.Write(buffer, 0, readByte);
                        Progresspercentage = (int)(fsIn.Position * 100 / fsIn.Length);
                        copied = fsIn.Position;
                        InvokeProgessbar();
                    }
                fsIn.Close();
                fsOut.Close();
            }
            catch (Exception Ex) when (Ex is ArgumentException || Ex is ArgumentNullException)
            {
                MessageBox.Show("Argument Exception");
            }
            catch (Exception Ex) when (Ex is NotSupportedException || Ex is FileNotFoundException)
            {
                MessageBox.Show("FileNotFindException");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        /// <summary>
        /// File Validation Method for Check fileexist in folder or not.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="folderpath"></param>
        public static void FileValidationMethod(string source, string folderpath)
        {
            FileInfo  SourceFileInfo = new FileInfo(source);
            FileInfo DestinationFile = new FileInfo(Path.Combine(folderpath, SourceFileInfo.Name));
           
            // Check file Exist or not.
            if (DestinationFile.Exists)
             {
                DialogResult result= MessageBox.Show($"{"The destination folder already has a file named"} {SourceFileInfo.Name}\n{"Do you want to overwrite the file?"}", "Replace or Skip file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result==DialogResult.Yes)
                {
                    return;
                }

                if(result==DialogResult.No)
                {
                  Application.Exit();
                }
            }
        }

        /// <summary>
        /// Invoke Thread Method For invoke thread.
        /// </summary>
        public void InvokeThread()
        {
            Thread copy = new Thread(CopyFile);
            if (yes == true)
            {
                copy.Start();
            }
            if (yes == false)
            {
                copy.Abort();
            }
        }
    }
}

    










