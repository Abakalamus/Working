using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс сотрудников ТФОМС
    /// </summary>
    [Table("EMPLOYEES")]
    class Employee : BaseObject<string>
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

        /// <summary>
        /// Отдел, в котором работает сотрудник
        /// </summary>
        public Department DepartmentID { get; set; }

        /// <summary>
        /// Рабочий телефон сотрудника
        /// </summary>
        public short? Phone { get; set; }
        #endregion Fields

        #region Constructors

        /// <summary>
        /// Базовый конструктор
        /// </summary>
        private Employee() { }

        /// <summary>
        /// Конструктор, содержищий ФИО сотрудника, отдел и рабочий телефон. Идентификатор отдела будет получен автоматически
        /// </summary>
        /// <param name="fio">ФИО (Фамилия И.О.)</param>
        /// <param name="department">Отдел</param>
        /// <param name="phone">Рабочий телефон</param>
        public Employee(string fio, Department department, short? phone)
        {
            Value = fio;
            DepartmentID = department;
            Phone = phone;
        }

        #endregion Constructors
    }
}
