using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFOMS_Zab_Kray.Classes
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string FAM { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string IM { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string OT { get; set; }

        public int W { get; set; }

        public DateTime DR { get; set; }

        public virtual int DEPARTMENT_ID { get; set; }

        [ForeignKey("DEPARTMENT_ID")]
        public virtual Department Department { get; set; }

        public ICollection<Position> Position { get; set; }

        public virtual int CABINET_ID { get; set; }

        [ForeignKey("CABINET_ID")]
        public virtual Cabinet Cabinet { get; set; }

        public int? PHONE_WORK { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string PHONE_MOBILE { get; set; }

        public Employee()
        {
            Position = new List<Position>();
        }
    }
}
