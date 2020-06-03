using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFOMS_Zab_Kray.Classes
{
    public class Cabinet
    {
        [Key]
        public int Id { get; set; }

        public byte Number { get; set; }

        public int BuildingId { get; set; }
        public Building Building { get; set; }

        public int FloorId { get; set; }
        public Floor Floor { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
