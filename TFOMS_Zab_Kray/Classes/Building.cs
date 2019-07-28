using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс зданий ТФОМС
    /// </summary>
    [Table("BUILDINGS")]
    public class Building : BaseObject<string>
    {
        #region Fields
        /// <summary>
        /// Идентификатор здания
        /// </summary>
        public override int Id { get; }

        /// <summary>
        /// Комплексное название здания, состоящее из улицы и номера дома
        /// </summary>
        [Column("Address")]
        [MaxLength(80)]
        [Required]
        public override string Value { get; set; }

        public virtual ICollection<Cabinet> Cabinets { get; set; }
        #region Deleted
        /*
         /// <summary>
         /// Название улицы
         /// </summary>
         [StringLength(60)]
         [NotMapped]
         private string Street;

         /// <summary>
         /// Номер дома
         /// </summary>
         [NotMapped]
         private byte Number;
         */
        #endregion Deleted
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        private Building() { Cabinets = new List<Cabinet>();  }

        /// <summary>
        /// Конструктор содержащий название улицы и номер здания. Идентификатор здания будет получен автоматически
        /// </summary>
        /// <param name="street">Название улицы</param>
        /// <param name="number">Номер дома</param>
        public Building(string street, byte number)
        {
            Value = $"улица {street}, дом {number.ToString()}";
            Cabinets = new List<Cabinet>();
        }
        #endregion Constructors
    }
}
