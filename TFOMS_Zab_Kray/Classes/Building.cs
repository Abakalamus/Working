using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс зданий ТФОМС
    /// </summary>
    [Table("BUILDINGS")]
    class Building : BaseObject
    {
        #region Fields
        /// <summary>
        /// Идентификатор здания
        /// </summary>
        public override int Id { get; }

        /// <summary>
        /// Комплексное название здания, состоящее из улицы и номера дома
        /// </summary>
        [NotMapped]
        public override string Name { get { return $"улица {Street}, дом {Number.ToString()}"; } set { } }
        /// <summary>
        /// Название улицы
        /// </summary>
        [MaxLength(80)]
        [Required]
        public string Street;

        /// <summary>
        /// Номер дома
        /// </summary>
        [Required]
        public byte Number;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        private Building() { }

        /// <summary>
        /// Конструктор содержащий название улицы и номер здания. Идентификатор здания будет получен автоматически
        /// </summary>
        /// <param name="street">Название улицы</param>
        /// <param name="number">Номер дома</param>
        public Building(string street, byte number)
        {
            Street = street;
            Number = number;
        }
        #endregion Constructors
    }
}
