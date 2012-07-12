using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace FSTLogViewer
{
    public partial class FormLogViewer : Form
    {
        private ConfigFile _configFile;
        private LogReader.LogReader _reader;

        public FormLogViewer()
        {
            InitializeComponent();

            ManageConfigs();
            SetLogViewer();
        }

        private void ManageConfigs()
        {
            _configFile = new ConfigFile
                              {
                                  LogsPath = Environment.CurrentDirectory,
                                  RefreshTime = int.Parse(tbxRefreshInterval.Text)
                              };
            _configFile.ReadConfigFile();
            tbxRefreshInterval.Text = _configFile.RefreshTime.ToString(CultureInfo.InvariantCulture);
        }

        private void SetLogViewer()
        {
            int interval = int.Parse(tbxRefreshInterval.Text);
            string path = _configFile.LogsPath;

            _reader = new LogReader.LogReader(path, interval)
                          {
                              TbxAccount = tbxAccount,
                              TbxPositions = tbxPositions,
                              TbxOrders = tbxOrders,
                              TsUpdated = lblStatusUpdatedTime
                          };

            lblStatusPath.Text = "Logs folder: " + path;
        }

        private void BtnRefreshLogsClick(object sender, EventArgs e)
        {
            _reader.ReadLogFiles();
        }

        private void TbxRefreshIntervalKeyUp(object sender, KeyEventArgs e)
        {
            var box = sender as ToolStripTextBox;
            if (box == null) return;

            int interval;
            if (!int.TryParse(box.Text, out interval))
            {
                box.ForeColor = Color.Red;
                return;
            }

            if (interval < 5 || interval > 60)
            {
                box.ForeColor = Color.Red;
                return;
            }

            box.ForeColor = Color.Black;
            _reader.SetRefreshInterval(interval);

            _configFile.RefreshTime = int.Parse(tbxRefreshInterval.Text);
            _configFile.WriteConfigFile();
        }

        private void BtnSetFolderClick(object sender, EventArgs e)
        {
            var fd = new FolderBrowserDialog
                         {
                             SelectedPath = _configFile.LogsPath,
                             Description = "Please navigate to the FST Logs folder."
                         };

            if (fd.ShowDialog() != DialogResult.OK) return;
            string path = fd.SelectedPath;
            _reader.SetFolder(path);

            _configFile.LogsPath = path;
            _configFile.WriteConfigFile();

            lblStatusPath.Text = "Logs folder: " + path;
        }

        private void BtnAboutClick(object sender, EventArgs e)
        {
            var box = new AboutBox();
            box.ShowDialog();
        }
    }
}