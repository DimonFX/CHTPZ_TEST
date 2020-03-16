using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace CHTPZ_TEST_TASK_App.EF
{
    [Table("FIRM")]
    public partial class FIRM
    {
        [Key]
        public int FIRM_ID { get; set; }
        [MaxLength(120), Required]
        public string NAME { get; set; }
        public int? POST_CITY_ID { get; set; }
        [ForeignKey("POST_CITY_ID")]
        public CITY POST_CITY { get; set; }
        public int JUR_CITY_ID { get; set; }
        [ForeignKey("JUR_CITY_ID")]
        public CITY JUR_CITY { get; set; }
        public ICollection<DOCUMENT> DOCUMENTs { get; set; }
        public FIRM()
        {
            DOCUMENTs = new HashSet<DOCUMENT>();
        }
    }
    public class FIRM_Configuration : EntityTypeConfiguration<FIRM>
    {
        public FIRM_Configuration()
        {
            //HasKey(i => i.FIRM_ID);
            //HasOptional(i => i.POST_CITY).WithMany().HasForeignKey(i => i.POST_CITY_ID).WillCascadeOnDelete(false);
            //HasRequired(i => i.JUR_CITY).WithMany().HasForeignKey(i => i.JUR_CITY_ID).WillCascadeOnDelete(false);
        }
    }
}
