using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс отделов ТФОМС
    /// </summary>
    [Table("OTDELS")]
    public class Department : BaseObject<string>
    {
        #region Fields
        /// <summary>
        /// Идентификатор отдела
        /// </summary>
        [Key]
        [Column("Department_Id")]
        public override int Id { get; set; }
        /// <summary>
        /// Название отдела
        /// </summary>
        [Column("Title")]
        [MaxLength(80)]
        [Required]
        public override string Value { get; set; }

        /// <summary>
        /// Кабинеты отдела
        /// </summary>
        public virtual ICollection<Cabinet> Cabinets { get; set; }
        /// <summary>
        /// Сотрудники отдела
        /// </summary>
        public virtual ICollection<Employee> Employees { get; set; }
        #endregion Fields

        #region Constructors
        public Department()
        {
            Cabinets = new List<Cabinet>();
            Employees = new List<Employee>();
        }
        #endregion Constructors
    }
}
