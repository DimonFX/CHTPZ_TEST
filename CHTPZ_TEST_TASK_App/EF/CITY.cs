using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CHTPZ_TEST_TASK_App.EF
{
    [Table("CITY")]
    public partial class CITY
    {
        //[MaxLength(10)]
        [Key]
        public int CITY_ID { get; set; }
        [MaxLength(20),Required]
        public string NAME { get; set; }
        [InverseProperty("POST_CITY")]
        public ICollection<FIRM> POST_FIRMs { get; set; }
        [InverseProperty("JUR_CITY")]
        public ICollection<FIRM> JUR_FIRMs { get; set; }
        public CITY() { }
        public CITY(string cityName)
        {
            this.NAME = cityName;
            POST_FIRMs = new HashSet<FIRM>();
            JUR_FIRMs = new HashSet<FIRM>();
        }
    }
}
