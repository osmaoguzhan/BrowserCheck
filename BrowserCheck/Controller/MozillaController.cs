using BrowserCheck.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace BrowserCheck.Controller
{
    public class MozillaController
    {
        
        private Mozilla mozilla = new Mozilla();
        private static string version = "Version=3;";
        private SQLiteConnection conn;
        public void setPath(string path)
        {
            mozilla.Path = path;
        }
        public List<FormHistoryMozilla> getFormHistory()
        {
            List<FormHistoryMozilla> formList;
            bool check = Validator.BrowserValidator.Instance.checkFile(mozilla.Path + "\\formhistory.sqlite");
            if (check)
            {
                formList = new List<FormHistoryMozilla>();
                conn = new SQLiteConnection("Data Source=" + mozilla.Path + "\\formhistory.sqlite;" + version);
                using (conn)
                {
                    try
                    {
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT fieldname,value,timesUsed,firstUsed,lastUsed FROM moz_formhistory ORDER BY timesUsed DESC";
                            cmd.Prepare();

                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    formList.Add(new FormHistoryMozilla()
                                    {
                                        FieldName = rdr.GetValue(0).ToString() ?? "-",
                                        Value = rdr.GetValue(1).ToString() ?? "-",
                                        TimeUsed = Convert.ToInt32(rdr.GetValue(2) ?? 0),
                                        FirstDate = Common.Common.Instance.FromUnixTime(Convert.ToInt64(rdr.GetValue(3) ?? 0)),
                                        LastDate = Common.Common.Instance.FromUnixTime(Convert.ToInt64(rdr.GetValue(4) ?? 0))
                                    });
                                }
                            }

                        }
                    }
                    catch
                    {
                        formList = null;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }else
            {
                formList = null;
            }

            return formList;
        }

        public List<WebHistoryMozilla> getWebHistory()
        {
            bool check = Validator.BrowserValidator.Instance.checkFile(mozilla.Path + "\\places.sqlite");
            List<WebHistoryMozilla> webList;
            if (check)
            {
                webList = new List<WebHistoryMozilla>();
                conn = new SQLiteConnection("Data Source=" + mozilla.Path + "\\places.sqlite;" + version);
                using (conn)
                {
                    try
                    {    
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT url,title,visit_count,last_visit_date,description FROM moz_places ORDER BY visit_count DESC";
                            cmd.Prepare();

                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    long temp = 0;
                                    if (rdr.GetValue(3) != DBNull.Value) temp = Convert.ToInt64(rdr.GetValue(3));

                                    webList.Add(new WebHistoryMozilla()
                                    {
                                        Url = rdr.GetValue(0).ToString() ?? "-",
                                        Title = rdr.GetValue(1).ToString() ?? "-",
                                        VisitCount = Convert.ToInt32(rdr.GetValue(2) ?? 0),
                                        LastVisitDate = Common.Common.Instance.FromUnixTime(temp),
                                        Description = rdr.GetValue(4).ToString() ?? "-"
                                    });
                                }
                            }

                        }
                    }
                    catch
                    {
                        webList = null;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                webList = null;
            }
            return webList;
        }
        public List<InputHistoryMozilla> getInputHistory()
        {
            bool check = Validator.BrowserValidator.Instance.checkFile(mozilla.Path + "\\places.sqlite");
            List<InputHistoryMozilla> inputList;
            if (check)
            {
                inputList = new List<InputHistoryMozilla>();
                conn = new SQLiteConnection("Data Source=" + mozilla.Path + "\\places.sqlite;" + version);
                using (conn)
                {
                    try
                    {             
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT input,use_count FROM moz_inputhistory ORDER BY use_count DESC";
                            cmd.Prepare();
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    inputList.Add(new InputHistoryMozilla()
                                    {
                                        Input = rdr.GetValue(0).ToString() ?? "-",
                                        Use_count = rdr.GetDouble(1)
                                    });
                                }
                            }

                        }                  
                    }
                    catch
                    {
                        inputList = null;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                inputList = null;
            }
            
            return inputList;
        }
        public List<BookmarksMozilla> getBookmarks()
        {
            bool check = Validator.BrowserValidator.Instance.checkFile(mozilla.Path + "\\places.sqlite");
            List<BookmarksMozilla> bookmarkList;
            if (check)
            {
                conn = new SQLiteConnection("Data Source=" + mozilla.Path + "\\places.sqlite;" + version);
                bookmarkList = new List<BookmarksMozilla>();
                using (conn)
                {
                    try
                    {
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT moz_places.url,moz_bookmarks.title,moz_bookmarks.dateAdded,moz_bookmarks.lastModified FROM moz_bookmarks INNER JOIN moz_places ON moz_bookmarks.parent = moz_places.id ORDER BY position ASC";
                            cmd.Prepare();
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    long added = 0;
                                    long last = 0;
                                    if (rdr.GetValue(2) != DBNull.Value) added = Convert.ToInt64(rdr.GetValue(2));
                                    if (rdr.GetValue(3) != DBNull.Value) last = Convert.ToInt64(rdr.GetValue(3));
                                    bookmarkList.Add(new BookmarksMozilla()
                                    {
                                        Url = rdr.GetValue(0).ToString() ?? "-",
                                        Title = rdr.GetValue(1).ToString() ?? "-",
                                        DateAdded = Common.Common.Instance.FromUnixTime(added),
                                        LastModified = Common.Common.Instance.FromUnixTime(last)

                                    });
                                }
                            }

                        }
                    }
                    catch
                    {
                    bookmarkList = null;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                bookmarkList = null;
            }
            
            return bookmarkList;
        }

        public List<CookiesMozilla> getCookies()
        {
            bool check = Validator.BrowserValidator.Instance.checkFile(mozilla.Path + "\\cookies.sqlite");
            List<CookiesMozilla> cookiesList;
            if (check)
            {
                conn = new SQLiteConnection("Data Source=" + mozilla.Path + "\\cookies.sqlite;" + version);
                cookiesList = new List<CookiesMozilla>();
                using (conn)
                {
                    try
                    {
                        conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT name,value,host,path,expiry,lastAccessed,creationTime from moz_cookies";
                            cmd.Prepare();
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                long expiry, lastAccessed, creationTime;
                                while (rdr.Read())
                                {
                                    expiry = 0;
                                    lastAccessed = 0;
                                    creationTime=0;                                  
                                    if (rdr.GetValue(4) != DBNull.Value) expiry = Convert.ToInt64(rdr.GetValue(4));
                                    if (rdr.GetValue(5) != DBNull.Value) lastAccessed = Convert.ToInt64(rdr.GetValue(5));
                                    if (rdr.GetValue(6) != DBNull.Value) creationTime = Convert.ToInt64(rdr.GetValue(6));
                                    cookiesList.Add(new CookiesMozilla()
                                    {
                                        Name = rdr.GetValue(0).ToString() ?? "-",
                                        Value = rdr.GetValue(1).ToString() ?? "-",
                                        Host = rdr.GetValue(2).ToString() ?? "-",
                                        CookiePath = rdr.GetValue(3).ToString() ?? "-",
                                        Expiry = Common.Common.Instance.UnixTime(expiry),
                                        LastAccessed = Common.Common.Instance.FromUnixTime(lastAccessed),
                                        CreationTime = Common.Common.Instance.FromUnixTime(creationTime)

                                    });
                                }
                            }

                        }
                    }
                    catch
                    {
                    cookiesList = null;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                cookiesList = null;
            }
            
            return cookiesList;
        }
        public List<AnnosMozilla> getAnnos()
        {
            bool check = Validator.BrowserValidator.Instance.checkFile(mozilla.Path + "\\places.sqlite");
            List<AnnosMozilla> annosList;
            if (check)
            {
                conn = new SQLiteConnection("Data Source=" + mozilla.Path + "\\places.sqlite;" + version);
                annosList = new List<AnnosMozilla>();

                using (conn) 
                {
                    try
                    {
                       conn.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.CommandText = "SELECT content, dateAdded, lastModified FROM moz_annos where content LIKE 'file:%'"; 
                            cmd.Prepare();
                            using (SQLiteDataReader rdr = cmd.ExecuteReader())
                            {
                                long dateAdded, lastModified;
                                while (rdr.Read())
                                {
                                    dateAdded = 0;
                                    lastModified = 0;
                                    if (rdr.GetValue(1) != DBNull.Value) dateAdded = Convert.ToInt64(rdr.GetValue(1));
                                    if (rdr.GetValue(2) != DBNull.Value) lastModified = Convert.ToInt64(rdr.GetValue(2));
                                    annosList.Add(new AnnosMozilla()
                                    {
                                        Content= rdr.GetValue(0).ToString() ?? "-",
                                        DateAdded = Common.Common.Instance.FromUnixTime(dateAdded),
                                        LastModified = Common.Common.Instance.FromUnixTime(lastModified)

                                    });
                                }
                            }

                        }                      
                    }
                    catch
                    {
                        annosList = null;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                annosList = null;
            }

            return annosList;
        }
    }
}
