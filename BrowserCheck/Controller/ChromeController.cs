using BrowserCheck.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace BrowserCheck.Controller
{
    public class ChromeController
    {

        private readonly Chrome chrome = new Chrome();
        private static readonly string version = "Version=3;";
        private SQLiteConnection conn;

        public void SetPath(string path)
        {
            chrome.Path = path;
        }

        public List<KeywordSearchChrome> GetKeywords()
        {
            List<KeywordSearchChrome> keywordList;
            bool check = Validator.BrowserValidator.Instance.checkFile(chrome.Path+"\\History");
            if (check)
            {
                keywordList = new List<KeywordSearchChrome>();
                conn = new SQLiteConnection("Data Source=" + chrome.Path + "\\History;" + version);
                try
                {
                    using (conn)
                    {
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT term FROM keyword_search_terms";
                            cmd.Prepare();
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    keywordList.Add(new KeywordSearchChrome()
                                    {
                                        Terms = rdr.GetValue(0).ToString() ?? "-"
                                    });
                                }
                            }

                        }
                        conn.Close();
                    }
                }
                catch
                {
                   ;
                }
            }
            else
            {
                keywordList = null;
            }

            return keywordList;
        }
        public List<HistoryChrome> GetHistory()
        {
            List<HistoryChrome> historyList;
            bool check = Validator.BrowserValidator.Instance.checkFile(chrome.Path+ "\\History");
            if (check)
            {
                historyList = new List<HistoryChrome>();
                conn = new SQLiteConnection("Data Source=" + chrome.Path + "\\History;" + version);
                try
                {
                    using (conn)
                    {
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT urls.url,urls.title,urls.last_visit_time,urls.visit_count,visits.visit_duration FROM urls INNER JOIN visits ON urls.id = visits.url ORDER BY visit_duration DESC";
                            cmd.Prepare();
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    long temp = 0;
                                    if (rdr.GetValue(2) != DBNull.Value) temp = Convert.ToInt64(rdr.GetValue(2));
                                    historyList.Add(new HistoryChrome()
                                    {
                                        Url = rdr.GetValue(0).ToString() ?? "-",
                                        Title = rdr.GetValue(1).ToString() ?? "-",
                                        LastVisitTime = Common.Common.Instance.FromUnixTime(temp).AddYears(-369),
                                        VisitCount = Convert.ToInt32(rdr.GetValue(3) ?? 0), 
                                        VisitDuration = Convert.ToInt64(rdr.GetValue(4) ?? 0) 
                                    });
                                }
                            }

                        }
                        conn.Close();
                    }
                }
                catch
                {
                   ;
                }
            }
            else
            {
                historyList = null;
            }
            return historyList;
        }
        public List<DownloadsChrome> GetDownloads()
        {
            List<DownloadsChrome> downloadList;
            bool check = Validator.BrowserValidator.Instance.checkFile(chrome.Path+ "\\History");
            if (check)
            {
                downloadList = new List<DownloadsChrome>();
                conn = new SQLiteConnection("Data Source=" + chrome.Path + "\\History;" + version);
                try
                {
                    using (conn)
                    {
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "select target_path,start_time,end_time,referrer,mime_type,original_mime_type FROM downloads";
                            cmd.Prepare();
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    long start = 0,end=0;
                                    if (rdr.GetValue(1) != DBNull.Value) start = Convert.ToInt64(rdr.GetValue(1));
                                    if (rdr.GetValue(2) != DBNull.Value) end = Convert.ToInt64(rdr.GetValue(2));
                                    downloadList.Add(new DownloadsChrome()
                                    {
                                        TargetPath = rdr.GetValue(0).ToString() ?? "-",
                                        StartTime = Common.Common.Instance.FromUnixTime(start).AddYears(-369),
                                        EndTime = Common.Common.Instance.FromUnixTime(end).AddYears(-369),
                                        Referer = rdr.GetValue(3).ToString() ?? "-",
                                        MimeType = rdr.GetValue(4).ToString() ?? "-",
                                        OriginalMimeType = rdr.GetValue(5).ToString() ?? "-"
                                    });
                                }
                            }

                        }
                        conn.Close();
                    }
                }
                catch
                {
                    
                  ;
                }
            }
            else
            {
                downloadList = null;
            }
            return downloadList;
        }
        public List<AutoFillChrome> GetAutofill()
        {
            List<AutoFillChrome> autofillList;
            bool check = Validator.BrowserValidator.Instance.checkFile(chrome.Path+"\\Web Data");
            if (check)
            {
                autofillList = new List<AutoFillChrome>();
                conn = new SQLiteConnection("Data Source=" + chrome.Path + "\\Web Data;" + version);
                try
                {
                    using (conn)
                    {
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT name,value,count,date_created,date_last_used FROM autofill";
                            cmd.Prepare();
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    long created = 0, last = 0;
                                    if (rdr.GetValue(3) != DBNull.Value) created = Convert.ToInt64(rdr.GetValue(3));
                                    if (rdr.GetValue(4) != DBNull.Value) last = Convert.ToInt64(rdr.GetValue(4));
                                    autofillList.Add(new AutoFillChrome()
                                    {
                                        Name= rdr.GetValue(0).ToString() ?? "-",
                                        Value = rdr.GetValue(1).ToString() ?? "-",
                                        Count = Convert.ToInt32(rdr.GetValue(2) ?? 0),
                                        DateCreated = Common.Common.Instance.FromUnixTime(created).AddYears(-369),
                                        DateLastUsed = Common.Common.Instance.FromUnixTime(last).AddYears(-369)
                                    });
                                }
                            }

                        }
                        conn.Close();
                    }
                }
                catch
                {

                   ;
                }
            }
            else
            {
                autofillList = null;
            }
            return autofillList;
        }
        public List<CookiesChrome> GetCookies()
        {
            List<CookiesChrome> cookieList;
            bool check = Validator.BrowserValidator.Instance.checkFile(chrome.Path + "\\Cookies");
            if (check)
            {
                cookieList = new List<CookiesChrome>();
                conn = new SQLiteConnection("Data Source=" + chrome.Path + "\\Cookies;" + version);
                try
                {
                    using (conn)
                    {
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT creation_utc,host_key,name,value,path,expires_utc FROM cookies";
                            cmd.Prepare();
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    long creation = 0, expires = 0;
                                    if (rdr.GetValue(0) != DBNull.Value) creation = Convert.ToInt64(rdr.GetValue(0));
                                    if (rdr.GetValue(5) != DBNull.Value) expires = Convert.ToInt64(rdr.GetValue(5));
                                    cookieList.Add(new CookiesChrome()
                                    {
                                        Creation = Common.Common.Instance.FromUnixTime(creation).AddYears(-369),
                                        HostKey = rdr.GetValue(1).ToString() ?? "",
                                        Name = rdr.GetValue(2).ToString() ?? "",
                                        Value = rdr.GetValue(3).ToString() ?? "",
                                        CookiePath = rdr.GetValue(4).ToString() ?? "-",
                                        Expires = Common.Common.Instance.FromUnixTime(expires).AddYears(-369)
                                    });
                                }
                            }
                        }
                        conn.Close();                       
                    }
                }
                catch
                {
                     ;
                }
            }
            else
            {
                cookieList = null;
            }
            return cookieList;
        }
        public List<TopSitesChrome> GetTopSites()
        {
            List<TopSitesChrome> topSitesList;
            bool check = Validator.BrowserValidator.Instance.checkFile(chrome.Path + "\\Top Sites");
            if (check)
            {
                topSitesList = new List<TopSitesChrome>();
                conn = new SQLiteConnection("Data Source=" + chrome.Path + "\\Top Sites;" + version);
                try
                {
                    using (conn)
                    {
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT url,url_rank,title FROM top_sites ORDER BY url_rank ASC";
                            cmd.Prepare();
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                               
                                while (rdr.Read())
                                {
                                    topSitesList.Add(new TopSitesChrome()
                                    {
                                        Url = rdr.GetValue(0).ToString() ?? "-",
                                        UrlRank = Convert.ToInt32(rdr.GetValue(1) ?? 0),
                                        Title = rdr.GetValue(2).ToString() ?? "-"
                                    });
                                }
                            }

                        }
                        conn.Close();
                    }
                }
                catch
                {

                    ;
                }
            }
            else
            {
                topSitesList = null;
            }
            return topSitesList;
        }
    }
}
