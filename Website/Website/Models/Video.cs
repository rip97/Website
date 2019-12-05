using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Website.Models
{  
    /// <summary>
    /// Class defines youtube video information
    /// </summary>
    public class Video
    {
        public int VideoID { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}
