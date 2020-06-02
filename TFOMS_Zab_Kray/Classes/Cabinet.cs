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
        public int ID { get; set; }

        public byte NUMBER { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        //Здание

        //Этаж
    }
}
