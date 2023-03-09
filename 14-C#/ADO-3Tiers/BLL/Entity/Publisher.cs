using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity
{

    public class Publisher:EntityBase
    {
        public int pubId { get; set; }
        public  string? pubName { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? country { get; set; }

        public Publisher() { }
        public Publisher(int pubId, string? pubName, string? city, string? state, string? country)
        {
            this.pubId = pubId;
            this.pubName = pubName;
            this.city = city;
            this.state = state;
            this.country = country;
        }


        /*
        CREATE TABLE[dbo].[publishers]
        (

    [pub_id][char](4) NOT NULL,

    [pub_name] [varchar] (40) NULL,
	[city][varchar] (20) NULL,
	[state][char](2) NULL,
	[country][varchar] (30) NULL,*/
    }
}
