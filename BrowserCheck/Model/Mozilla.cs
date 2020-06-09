using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace BrowserCheck.Model
{
    public  class Mozilla
    {
        public string Path { get; set; }
    }

    public class FormHistoryMozilla : Mozilla
    {
        public string FieldName { get; set; }
        public string Value { get; set; }

        public int TimeUsed { get; set; }

        public DateTime FirstDate { get; set; }

        public DateTime LastDate { get; set; }
    }

    public class WebHistoryMozilla : Mozilla
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public int VisitCount { get; set; }

        public DateTime LastVisitDate { get; set; }

        public string Description { get; set; }

    }

    public class InputHistoryMozilla : Mozilla
    {
        public string Input { get; set; }

        public double Use_count { get; set; }

    }

    public class BookmarksMozilla : Mozilla
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime LastModified { get; set; }
    }

    public class CookiesMozilla : Mozilla
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public string Host { get; set; }

        public string CookiePath { get; set; }

        public DateTime Expiry { get; set; }

        public DateTime LastAccessed { get; set; }

        public DateTime CreationTime { get; set; }
    }

    public class AnnosMozilla : Mozilla
    {
        public string Content { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime LastModified { get; set; }
    }
}

