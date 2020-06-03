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
        public int Id { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string Fam { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string Im { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string Ot { get; set; }

        public int W { get; set; }

        public DateTime DR { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Position> Position { get; set; }

        public int CabinetId { get; set; }
        public Cabinet Cabinet { get; set; }

        public int? Phone_Work { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string Phone_Mobile { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string Email { get; set; }

        public Employee()
        {
            Position = new List<Position>();
        }
    }
}
