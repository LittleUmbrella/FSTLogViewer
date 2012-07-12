using System;

namespace FSTLogViewer.LogReader
{
    public class AccountInfo
    {
        public AccountInfo()
        {
            Time = DateTime.MinValue;
            Text = string.Empty;
        }

        public DateTime Time { get; private set; }
        public string Text { get; private set; }

        public void SetInfo(DateTime time, string text)
        {
            if (Time > time) return;
            Time = time;
            Text = text;
        }

        public void SetInfo(AccountInfo accountInfo)
        {
            if (Time > accountInfo.Time) return;
            Time = accountInfo.Time;
            Text = accountInfo.Text;
        }
    }
}