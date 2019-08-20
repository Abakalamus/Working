using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс должностей ТФОМС
    /// </summary>
    [Table("POSITION")]
    public class Position : BaseObject<string>
    {
        #region Fields
        /// <summary>
        /// Идентификатор должности
        /// </summary>
        [Key]
        public override int Id { get; }

        /// <summary>
        /// Название должности
        /// </summary>
        [Column("Name")]
        public override string Value { get; set; }

        /// <summary>
        /// Сотрудники
        /// </summary>
        public virtual ICollection<Employee> Employees { get; set; }
        #endregion Fields

        #region Constructors
        public Position()
        {
            Employees = new List<Employee>();
        }
        #endregion Constructors
    }
}
