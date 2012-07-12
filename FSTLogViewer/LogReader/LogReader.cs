using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FSTLogViewer.LogReader
{
    public class LogReader
    {
        private DirectoryInfo _dirInfo;
        private Timer _timerRefresh;
        private Timer _timerUpdated;

        private int _timeUpdate;

        private readonly AccountInfo _lastAccountInfo;
        private readonly Dictionary<string, SymbolInfo> _lastPositionsInfo;
        private readonly Dictionary<string, SymbolInfo> _lastOrdersInfo;

        public TextBox TbxAccount { private get; set; }
        public TextBox TbxPositions { private get; set; }
        public TextBox TbxOrders { private get; set; }
        public ToolStripStatusLabel TsUpdated { private get; set; }

        public LogReader(string dirPath, int interval)
        {
            _dirInfo = new DirectoryInfo(dirPath);

            if (!_dirInfo.Exists) return;

            _lastAccountInfo = new AccountInfo();
            _lastPositionsInfo = new Dictionary<string, SymbolInfo>();
            _lastOrdersInfo = new Dictionary<string, SymbolInfo>();

            StartLogReader(interval);
        }

        public void SetFolder(string dirPath)
        {
            _dirInfo = new DirectoryInfo(dirPath);
        }

        public void SetRefreshInterval(int interval)
        {
            _timerRefresh.Stop();
            _timerRefresh.Interval = interval * 1000;
            _timerRefresh.Start();
        }

        private void StartLogReader(int interval)
        {
            _timerRefresh = new Timer {Interval = interval * 1000};
            _timerRefresh.Tick += TimerRefreshTick;
            _timerRefresh.Start();

            _timerUpdated = new Timer { Interval = 1 * 1000 };
            _timerUpdated.Tick += TimerUpdateTick;
            _timerUpdated.Start();
        }

        public void ReadLogFiles()
        {
            if (!_dirInfo.Exists) return;
            FileInfo[] fileInfos = _dirInfo.GetFiles("*.log");

            foreach (var fileInfo in fileInfos)
            {
                StreamReader reader = fileInfo.OpenText();
                CultureInfo provider = CultureInfo.InvariantCulture;

                do
                {
                    string line = reader.ReadLine();
                    if (line == null) break;

                    string timeString = line.Split(',')[0];
                    var time = DateTime.ParseExact(timeString, "yyyy.MM.dd HH:mm:ss", provider);

                    if (line.Contains("Account Balance"))
                        _lastAccountInfo.SetInfo(time, line);

                    else if (line.Contains("Long") || line.Contains("Short") || line.Contains("Square"))
                    {
                        var symbol = line.Split(' ')[2];
                        if (_lastPositionsInfo.ContainsKey(symbol))
                        {
                            _lastPositionsInfo[symbol].SetInfo(symbol, time, line);
                        }
                        else
                        {
                            var positionInfo = new SymbolInfo();
                            positionInfo.SetInfo(symbol, time, line);
                            _lastPositionsInfo.Add(symbol, positionInfo);
                        }
                    }

                    else if (line.Contains("entry") || line.Contains("exit") || line.Contains("Activated"))
                    {
                        var symbol = line.Split(' ')[2];
                        if (_lastOrdersInfo.ContainsKey(symbol))
                        {
                            _lastOrdersInfo[symbol].SetInfo(symbol, time, line);
                        }
                        else
                        {
                            var orderInfo = new SymbolInfo();
                            orderInfo.SetInfo(symbol, time, line);
                            _lastOrdersInfo.Add(symbol, orderInfo);
                        }
                    }

                } while (true);

                reader.Close();
            }

            RefreshTimeUpdate();
        }

        private void RefreshAccountInfo()
        {
            SetAccountInfoText(_lastAccountInfo.Text);
        }

        private void RefreshPositionsInfo()
        {
            var stringBuilder = new StringBuilder(_lastPositionsInfo.Count);
            foreach (var symbolInfo in _lastPositionsInfo)
                stringBuilder.AppendLine(symbolInfo.Value.Text);
            SetPositionsInfoText(stringBuilder.ToString());
        }

        private void RefreshOrdersInfo()
        {
            var stringBuilder = new StringBuilder(_lastOrdersInfo.Count);
            foreach (var symbolInfo in _lastOrdersInfo)
                stringBuilder.AppendLine(symbolInfo.Value.Text);
            SetOrdersInfoText(stringBuilder.ToString());
        }

        /// <summary>
        /// Sets the TbxAccountInfo.Text
        /// </summary>
        private void SetAccountInfoText(string text)
        {
            if (TbxAccount.InvokeRequired)
            {
                TbxAccount.BeginInvoke(new SetAccountInfoCallback(SetAccountInfoText), new object[] { text });
            }
            else
            {
                TbxAccount.Text = text;
            }
        }

        /// <summary>
        /// Sets the TbxPositions.Text
        /// </summary>
        private void SetPositionsInfoText(string text)
        {
            if (TbxPositions.InvokeRequired)
            {
                TbxPositions.BeginInvoke(new SetPositionsInfoCallback(SetPositionsInfoText), new object[] { text });
            }
            else
            {
                TbxPositions.Text = text;
            }
        }

        /// <summary>
        /// Sets the TbxOrders.Text
        /// </summary>
        private void SetOrdersInfoText(string text)
        {
            if (TbxOrders.InvokeRequired)
            {
                TbxOrders.BeginInvoke(new SetOrdersInfoCallback(SetOrdersInfoText), new object[] { text });
            }
            else
            {
                TbxOrders.Text = text;
            }
        }

        private void TimerRefreshTick(object sender, EventArgs e)
        {
            ReadLogFiles();

            RefreshAccountInfo();
            RefreshPositionsInfo();
            RefreshOrdersInfo();
        }

        private void RefreshTimeUpdate()
        {
            _timeUpdate = 0;
        }

        private void TimerUpdateTick(object sender, EventArgs e)
        {
            _timeUpdate++;
            TsUpdated.Text = _timeUpdate.ToString(CultureInfo.InvariantCulture);
        }

        #region Nested types

        private delegate void SetAccountInfoCallback(string text);
        private delegate void SetPositionsInfoCallback(string text);
        private delegate void SetOrdersInfoCallback(string text);

        #endregion

    }
}
