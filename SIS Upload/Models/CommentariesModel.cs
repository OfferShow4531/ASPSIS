using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIS_Upload.Models
{
    public class CommentariesModel
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Comment { get; set; }
        public string NickName { get; set; }
        public decimal Reputation { get; set; }
    }
}
