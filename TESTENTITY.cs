using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCorePlus.Test
{
    public partial class TESTENTITY 
    {
        [Column("ID")]
        public  string Id { set; get; }
        public string TESTENTITY2ID { set; get; }
        public decimal COLNUMINT { set; get; }
        public string TESTENTITY2ID_NULLABLE { set; get; }
        public decimal? COLNUMINT_NULLABLE { set; get; }
        public string STRING { set; get; }
        public long ISACTIVE { set; get; }
        public string COMMENT { set; get; }
        public DateTime REGISTERTIME { set; get; }
    }

}
