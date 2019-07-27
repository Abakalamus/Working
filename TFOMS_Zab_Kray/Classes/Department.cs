using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс отделов ТФОМС
    /// </summary>
    [Table("OTDELS")]
    public class Department : BaseObject
    {
        #region Fields
        /// <summary>
        /// Идентификатор отдела
        /// </summary>
        public override int Id { get; }
        /// <summary>
        /// Название отдела
        /// </summary>
        [MaxLength(80)]
        [Required]
        public override string Name { get; set; }
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Базовый конструктор отдела
        /// </summary>
        private Department() { }

        /// <summary>
        /// Конструктор, содержищий название отдела. Идентификатор отдела будет получен автоматически
        /// </summary>
        /// <param name="name">Название отдела</param>
        public Department(string name)
        {
            Name = name;
        }
        #endregion Constructors
    }
}
