using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SillyRequests.Models
{
    public class Request
    {

        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Question { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OccurenceDate { get; set; }
    }
}