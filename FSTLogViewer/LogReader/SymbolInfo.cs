using System;

namespace FSTLogViewer.LogReader
{
    public class SymbolInfo
    {
        public SymbolInfo()
        {
            Time = DateTime.MinValue;
            Text = string.Empty;
            Symbol = string.Empty;
        }

        public string Symbol { get; private set; }
        public DateTime Time { get; private set; }
        public string Text { get; private set; }

        public void SetInfo(string symbol, DateTime time, string text)
        {
            if (Time > time) return;
            Symbol = symbol;
            Time = time;
            Text = text;
        }

        public void SetInfo(SymbolInfo symbolInfo)
        {
            if (Time > symbolInfo.Time) return;
            Symbol = symbolInfo.Symbol;
            Time = symbolInfo.Time;
            Text = symbolInfo.Text;
        }

    }
}
