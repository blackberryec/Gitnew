using HaiShop.Model.Abtract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace HaiShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessenge { set; get; }

        [Required]
        [MaxLength(256)]
        public string PaymentMethod { set; get; }

        [Required]
        public string PaymentStatus { set; get; } //có vấn đề
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public bool Status { set; get; }
    }
}