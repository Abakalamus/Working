using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс этажей здания
    /// </summary>
    [Table("FLOORS")]
    class Floor : BaseObject
    {
        #region Fields
        /// <summary>
        /// Идентификатор этажа
        /// </summary>
        public override int Id { get; }

        /// <summary>
        /// Семантическое (человекопонятное) описание
        /// </summary>
        [Column("Description")]
        [MaxLength(20)]
        public override string Name { get; set; }
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        private Floor() { }

        /// <summary>
        /// Конструктор содержащий название этажа прописью. Идентификатор этажа будет получен автоматически
        /// </summary>
        /// <param name="description"></param>
        public Floor(string description)
        {
            Name = description;
        }
        #endregion Constructors
    }
}
