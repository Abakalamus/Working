﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFOMS_Zab_Kray.Classes
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar2"), StringLength(40)]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public Position()
        {
            Employees = new List<Employee>();
        }
    }
}
