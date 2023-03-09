using BLL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity
{
    public class Title:EntityBase
    {
        int tid;
        public int Tid { get=>tid; set
            {
                if (value != tid) {
                    this.state=EntityState.Unchanged; this.tid = value;
                }
            } }
        string title;
        public string Titlee { get=>title; set
            {
                if (value != title)
                {
                    this.state=EntityState.Unchanged;this.title = value;
                }
            }
        }
        string type;
        public string Type
        {
            get => type; set
            {
                if (value != type)
                {
                    this.state = EntityState.Unchanged; this.type = value;
                }
            }
        }
        string? pub_id;
        public string? Pub_id { get=>pub_id; set
            {
                if (value != pub_id)
                {
                    this.state=EntityState.Unchanged;
                    this.pub_id = value;
                }
            }
        }
        decimal? price;
        public decimal? Price { get=>price; set { 
                if (value != price)
                {
                    this.state=EntityState.Unchanged;
                    this.price = value;
                }
            } }
        decimal? advance;
        public decimal? Advance { get=> advance; set { 
                if(value!=advance)
                {
                    this.state=EntityState.Unchanged;
                    this.advance = value;
                }
            } }
        int? royalty;
        public int? Royalty { get=>royalty; set
            {
                if (value != royalty)
                {
                    this.state=EntityState.Unchanged;
                    this.royalty = value;
                }
            }
        }
        int? ytd_sales;
        public int? Ytd_sales { get=>ytd_sales; set { 
                if(value!= ytd_sales)
                {
                    this.state=EntityState.Unchanged;
                    this.ytd_sales = value;
                }
            
            } }
        string? notes;
        public string? Notes { get=>notes; set
            {
                if(value!=notes)
                {
                    this.state=EntityState.Unchanged; this.notes = value;
                }
            }
        }
        DateTime pubdate;
        public DateTime Pubdate { get=>pubdate; set
            {
                if (value != pubdate)
                {
                    this.state=EntityState.Unchanged;this.pubdate = value;
                }
            } }



    }
}
//CREATE TABLE[dbo].[titles] (

//    [title_id][dbo].[tid] NOT NULL,

//    [title] [varchar] (80) NOT NULL,

//    [type] [char] (12) NOT NULL,

//    [pub_id] [char] (4) NULL,
//	[price][money] NULL,
//	[advance][money] NULL,
//	[royalty][int] NULL,
//	[ytd_sales][int] NULL,
//	[notes][varchar] (200) NULL,
//	[pubdate][datetime] NOT NULL,
// CONSTRAINT[UPKCL_titleidind] PRIMARY KEY CLUSTERED 
//(

//    [title_id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY]
//GO