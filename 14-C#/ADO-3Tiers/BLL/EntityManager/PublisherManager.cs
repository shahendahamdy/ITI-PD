using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BLL.Entity;
using BLL.EntityList;
using DAL;

namespace BLL.EntityManager
{
    public class PublisherManager
    {
        //hb3t sp ll dal
        static DBManager manager = new();
        public static PublisherList selectAllPublishers()
        {
            try
            {
                return dataTableToPubList(manager.ExecuteDataTable("SelectAllPublishers"));


            }
            catch
            {
                return new PublisherList();
            }
        }
        internal static PublisherList dataTableToPubList(DataTable dt)
        {
            PublisherList pubList = new PublisherList();
            
                foreach (DataRow dr in dt.Rows)
                {
                    
                    pubList.Add(dataRowToPub(dr));
                }
            Debug.WriteLine(pubList.Count+"     kk");
            return pubList;
        }
        internal static Publisher dataRowToPub(DataRow dr)
        {
            Publisher pub = new();
           // Debug.WriteLine("**************");
            if (int.TryParse(dr["pub_id"]?.ToString() ?? "-1", out int tempInt)){
                    pub.pubId= tempInt;
                }
                pub.pubName =dr["pub_name"]?.ToString() ?? "NA";
                pub.city = dr["city"]?.ToString() ?? "NA";
                pub.state = dr["state"]?.ToString() ?? "NA";
                pub.country = dr["country"]?.ToString() ?? "NA";
            
            
            return pub;
        }



    }
}
