using BLL.Entity;
using BLL.EntityList;
using DAL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace BLL.EntityManager
{
    public class TiltleManager
    {
        static DBManager manager= new DBManager();

        //select titles
        public static TitleList selectAllTitles()
        {
           
           return dtToTitleList(manager.ExecuteDataTable("SelectAllTitles"));
        }

        // delete title
        public static int deleteTitle(string titleID)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("tid", titleID);
            return manager.ExexuteNonQuery("DeleteTitle", dict);

        }
        // deleupdate  title
        public static int updateTitle(string titleID, string title , string type ,string pub_id , decimal price , decimal advance , int royalty , int ytd_sales ,string notes ,DateTime pubdate )
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("tid", titleID);
            dict.Add("title", title);
            dict.Add("type", type);
            dict.Add("price", price);
            dict.Add("advance", advance);
            dict.Add("royalty", royalty);
            dict.Add("ytd_sales", ytd_sales);
            dict.Add("notes", notes);
            dict.Add("pubdate", pubdate);

            return manager.ExexuteNonQuery("UpdateTitle", dict);

        }
        
        public static int insertTitle(string titleID, string title, string type, string pub_id, decimal price, decimal advance, int royalty, int ytd_sales, string notes, DateTime pubdate)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("tid", titleID);
            dict.Add("title", title);
            dict.Add("type", type);
            dict.Add("price", price);
            dict.Add("advance", advance);
            dict.Add("royalty", royalty);
            dict.Add("ytd_sales", ytd_sales);
            dict.Add("notes", notes);
            dict.Add("pubdate", pubdate);

            return manager.ExexuteNonQuery("spInsertTitle", dict);

        }

        internal static TitleList dtToTitleList(DataTable dt)
        {
            TitleList titleList = new TitleList();
            Debug.WriteLine("kkk" + dt.Rows.Count);

            foreach (DataRow dr in dt.Rows)
            {
                titleList.Add(dataRowToTitle(dr));
            }
            Debug.WriteLine("kkk"+ titleList.Count);

            return titleList;
        }

        internal static Title dataRowToTitle(DataRow dr)
        {
            Title title = new();

            if (int.TryParse(dr["title_id"]?.ToString()??"-1",out int intTemp))
            {
                title.Tid = intTemp;
            }
            title.Titlee = dr["title"].ToString() ?? "NA";
            title.Type = dr["type"].ToString() ?? "NA";
            title.Pub_id = dr["pub_id"].ToString() ?? "NA";

            if (decimal.TryParse(dr["price"]?.ToString() ?? "-1", out decimal tempDec))
            {
                title.Price = tempDec;
            }
            if (decimal.TryParse(dr["advance"]?.ToString() ?? "-1", out  tempDec))
            {
                title.Advance = tempDec;
            }

            if (int.TryParse(dr["royalty"]?.ToString() ?? "-1", out  intTemp))
            {
                title.Royalty = intTemp;
            }
            if (int.TryParse(dr["ytd_sales"]?.ToString() ?? "-1", out  intTemp))
            {
                title.Ytd_sales = intTemp;
            }
            title.Notes = dr["notes"].ToString() ?? "NA";

            if (DateTime.TryParse(dr["advance"]?.ToString() ?? "-1", out DateTime temp))
            {
                title.Pubdate = temp;
            }
            return title;

        }
    }




}
