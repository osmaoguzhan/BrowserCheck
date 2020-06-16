using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserCheck.Model
{
    public class Chrome
    {
        public string Path { get; set; }
    }

    public class KeywordSearchChrome : Chrome
    {
        public string Terms { get; set; }
    }

    public class HistoryChrome : Chrome
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public int VisitCount { get; set; }

        public DateTime LastVisitTime { get; set; }

        public long VisitDuration { get; set; }
    }

    public class DownloadsChrome : Chrome
    {
        public string TargetPath { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Referer { get; set; }

        public string MimeType { get; set; }

        public string OriginalMimeType { get; set; }

    }

    public class AutoFillChrome : Chrome
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateLastUsed { get; set; }

        public int Count { get; set; }
    }
    public class CookiesChrome : Chrome
    {
        public DateTime Creation { get; set; }

        public string HostKey { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string CookiePath { get; set; }

        public DateTime Expires { get; set; }

    }

    public class TopSitesChrome : Chrome
    {
        public string Url { get; set; }

        public int UrlRank { get; set; }

        public string Title { get; set; }
    }
}
