using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CHTPZ_TEST_TASK_App.EF
{
    [Table("DOCUMENT")]
    public partial class DOCUMENT
    {
        [Key]
        public int DOCUMENT_ID { get; set; }
        [Column(TypeName = "date")]
        public DateTime DOC_DATE { get; set; }
        public double SUM { get; set; }

        public int FIRM_ID { get; set; }
        [ForeignKey("FIRM_ID")]
        public FIRM FIRM { get; set; }
    }
}
