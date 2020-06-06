using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserCheck.Model
{
    public class Chrome
    {
        private string path; public string Path { get { return path; } set { this.path = value; } }
    }

    public class KeywordSearchChrome : Chrome
    {
        private string terms; public string Terms { get { return terms; } set { this.terms = value; } }
    }

    public class HistoryChrome : Chrome
    {
        private string title; public string Title { get { return title; } set { this.title = value; } }
        private int visitCount; public int VisitCount { get { return visitCount; } set { this.visitCount = value; } }
        private DateTime lastVisitTime; public DateTime LastVisitTime { get { return lastVisitTime; } set { this.lastVisitTime = value; } }
        private long visitDuration; public long VisitDuration { get { return visitDuration; } set { this.visitDuration = value; } }
    }

    public class DownloadsChrome : Chrome
    {
        private string targetPath; public string TargetPath { get { return targetPath; } set { this.targetPath = value; } }
        private DateTime startTime; public DateTime StartTime { get { return startTime; } set { this.startTime = value; } }
        private DateTime endTime; public DateTime EndTime { get { return endTime; } set { this.endTime = value; } }
        private string referer; public string Referer { get { return referer; } set { this.referer = value; } }
        private string mimeType; public string MimeType { get { return mimeType; } set { this.mimeType = value; } }
        private string originalMimeType; public string OriginalMimeType { get { return originalMimeType; } set { this.originalMimeType = value; } }

    }

    public class AutoFillChrome : Chrome
    {
        private string name; public string Name { get { return name; } set { this.name = value; } }
        private string value; public string Value { get { return value; } set { this.value = value; } }
        private DateTime dateCreated; public DateTime DateCreated { get { return dateCreated; } set { this.dateCreated = value; } }
        private DateTime dateLastUsed; public DateTime DateLastUsed { get { return dateLastUsed; } set { this.dateLastUsed = value; } }
        private int count; public int Count { get { return count; } set { this.count = value; } }
    }
    public class CookiesChrome : Chrome
    {
        private DateTime creation; public DateTime Creation { get { return creation; } set { this.creation = value; } }
        private string hostKey; public string HostKey { get { return hostKey; } set { this.hostKey = value; } }
        private string name; public string Name { get { return name; } set { this.name = value; } }
        private string value; public string Value { get { return value; } set { this.value = value; } }
        private string cookiePath; public string CookiePath { get { return cookiePath; } set { this.cookiePath = value; } }
        private DateTime expires; public DateTime Expires { get { return expires; } set { this.expires = value; } }
       
    }

    public class TopSitesChrome : Chrome
    {
        private string url; public string Url { get { return url; } set { this.url = value; } }
        private int urlRank; public int UrlRank { get { return urlRank; } set { this.urlRank = value; } }
        private string title; public string Title { get { return title; } set { this.title = value; } }
    }
}
