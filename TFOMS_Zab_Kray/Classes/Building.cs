using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFOMS_Zab_Kray.Classes
{
    public class Building
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string Street { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string Number { get; set; }
    }
}
