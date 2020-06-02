using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFOMS_Zab_Kray.Classes
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string NAME { get; set; }

        public ICollection<Cabinet> Cabinets { get; set; }

        public Department()
        {
            Cabinets = new List<Cabinet>();
        }
    }
}
