using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс этажей здания
    /// </summary>
    [Table("FLOORS")]
    public class Floor : BaseObject<string>
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
        public override string Value { get; set; }
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
            Value = description;
        }
        #endregion Constructors
    }
}
