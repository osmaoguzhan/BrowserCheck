using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace BrowserCheck.Model
{
    public  class Mozilla
    {   
        private  string path; public string Path { get { return path; } set { this.path = value; } }
    }

    public class FormHistoryMozilla : Mozilla
    {
        private string fieldName; public string FieldName { get { return fieldName; } set { this.fieldName = value; } }
        private string value; public string Value { get { return value; }  set { this.value = value; } }
        private int timeUsed; public int TimeUsed { get { return timeUsed; }  set { this.timeUsed = value; } }
        private DateTime  firstDate; public DateTime  FirstDate { get { return firstDate; }  set { this.firstDate = value; } }
        private DateTime  lastDate; public DateTime  LastDate { get { return lastDate; }  set { this.lastDate = value; } }
    }

    public class WebHistoryMozilla : Mozilla
    {
        private string url; public string Url { get { return url; } set { this.url = value; } }
        private string title; public string Title { get { return title; } set { this.title = value; } }
        private int visitCount; public int VisitCount { get { return visitCount; } set { this.visitCount = value; } }
        private DateTime lastVisitDate; public DateTime LastVisitDate { get { return lastVisitDate; } set { this.lastVisitDate = value; } }
        private string description; public string Description { get { return description; } set { this.description = value; } }

    }

    public class InputHistoryMozilla : Mozilla
    {
        private string input; public string Input { get { return input; } set { this.input = value; } }
        private double use_count; public double Use_count { get { return use_count; } set { this.use_count = value; } }

    }

    public class BookmarksMozilla : Mozilla
    {
        private string url; public string Url { get { return url; } set { this.url = value; } }
        private string title; public string Title { get { return title; } set { this.title = value; } }
        private DateTime dateAdded; public DateTime DateAdded { get { return dateAdded; } set { this.dateAdded = value; } }
        private DateTime lastModified; public DateTime LastModified { get { return lastModified; } set { this.lastModified = value; } }
    }

    public class CookiesMozilla : Mozilla
    {
        private string name; public string Name { get { return name; } set { this.name = value; } }
        private string value; public string Value { get { return value; } set { this.value = value; } }
        private string host; public string Host { get { return host; } set { this.host = value; } }
        private string cookiePath; public string CookiePath { get { return cookiePath; } set { this.cookiePath = value; } }
        private DateTime expiry; public DateTime Expiry { get { return expiry; } set { this.expiry = value; } }
        private DateTime lastAccessed; public DateTime LastAccessed { get { return lastAccessed; } set { this.lastAccessed = value; } }
        private DateTime creationTime; public DateTime CreationTime { get { return creationTime; } set { this.creationTime = value; } }
    }

    public class AnnosMozilla : Mozilla
    {
        private string content; public string Content { get { return content; } set { this.content = value; } }
        private DateTime dateAdded; public DateTime DateAdded { get { return dateAdded; } set { this.dateAdded = value; } }
        private DateTime lastModified; public DateTime LastModified{ get { return lastModified; } set { this.lastModified = value; } }
    }
}

