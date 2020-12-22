using System;
using System.Windows.Forms;

namespace TEST
{
    public partial class TEST : Form
    {
        public TEST()
        {
            // Backup the log files in this location after 30 days (Put here any location else EasyLogger.LogFile is default)
            EasyLogger.BackupLogs(EasyLogger.LogFile, 30);

            // Backup the log files in this location (Put here any location else EasyLogger.LogFile is default)
            //EasyLogger.BackupLogs(EasyLogger.LogFile);

            // Add listener so we can start logging
            EasyLogger.AddListener(EasyLogger.LogFile);

            // Log something
            EasyLogger.Info("TEST: The log file path is: " + EasyLogger.LogFile);

            InitializeComponent();
        }

        private void Custom_Click(object sender, EventArgs e)
        {
            // Backup the log files in this location
            EasyLogger.BackupLogs(EasyLogger.LogDirectory + "TEST_CUSTOM.log");

            // Need to dispose so that we can set our new log location
            EasyLogger.RemoveListener();

            // Need to add a listener again
            EasyLogger.AddListener(EasyLogger.LogFile);

            // Log something
            EasyLogger.Info("TEST: The log file path is: " + EasyLogger.LogFile);
        }

        private void Log_Click(object sender, EventArgs e)
        {
            // Used to isolate errors
            EasyLogger.Error("The log file path is: " + EasyLogger.LogFile);

            // Used to isolate warnings
            EasyLogger.Warning("The log file path is: " + EasyLogger.LogFile);

            // Used to isolate information
            EasyLogger.Info("The log file path is: " + EasyLogger.LogFile);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Final log entry
            EasyLogger.Info("Closing down...");

            // Dispose EasyLogger
            EasyLogger.RemoveListener();
        }
    }
}
