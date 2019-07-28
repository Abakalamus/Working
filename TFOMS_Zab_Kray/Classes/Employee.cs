using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс сотрудников ТФОМС
    /// </summary>
    [Table("EMPLOYEES")]
    public class Employee : BaseObject<string>
    {
        #region Fields
        /// <summary>
        /// Идентификатор работника
        /// </summary>
        [Key]
        public override int Id { get; }

        /// <summary>
        /// Инициалы работника (в виде Фамилия И.О.)
        /// </summary>
        [Column("FIO")]
        public override string Value { get; set; }

        public int DepartmentId { get; set; }
        /// <summary>
        /// Отдел, в котором работает сотрудник
        /// </summary>       
        public Department Department { get; set; }

        /// <summary>
        /// Рабочий телефон сотрудника
        /// </summary>
        public short? Phone { get; set; }
        #endregion Fields
    }
}
