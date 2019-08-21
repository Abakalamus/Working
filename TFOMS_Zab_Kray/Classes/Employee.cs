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
        [Column("Employee_Id")]
        public override int Id { get; set; }

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

        public int PositionId { get; set; }
        /// <summary>
        /// Дожность, занимаемая сотрудником
        /// </summary>       
        public Position Position { get; set; }

        /// <summary>
        /// Рабочий телефон сотрудника
        /// </summary>
        public short? Phone { get; set; }
        #endregion Fields
    }
}
