using HaiShop.Model.Abtract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace HaiShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//tương ứng set identity trong SQL
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }
        public override DateTime? CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}