using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingSystem.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
        [ForeignKey("products")]
        [Display(Name ="Uploade Image")]
        public int? ProductId { get; set; }
        public Products products { get; set; }
        [ForeignKey("user")]
        [Display(Name = "Uploade Image")]
        public int UserId { get; set; }
        public User user { get; set; }

    }
}
