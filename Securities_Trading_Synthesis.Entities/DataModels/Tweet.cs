using System;
using System.Collections.Generic;
using System.Text;

namespace Securities_Trading_Synthesis.Entities.DataModels
{
    public class Tweet
    {
        public int ID { get; set; }
        public DateTime Post_Date { get; set; }
        public string Keywords { get; set; }
        public string User_Name { get; set; }
        public string Tags { get; set; }
        public string Security_Sym { get; set; }
        public string Body { get; set; }
    }
}
