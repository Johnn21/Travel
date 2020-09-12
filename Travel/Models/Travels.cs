using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Travel.Models
{
    public class Travels
    {
        [Key]
        public int idTravel { get; set; }
        public string locationTravel { get; set; }
        public string descriptionTravel { get; set; }

        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public virtual User User { get; set; }


    }
}