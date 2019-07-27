using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс кабинетов ТФОМС
    /// </summary>
    [Table("CABINETS")]
    public class Cabinet : BaseObject
    {
        #region Fields
        /// <summary>
        /// Идентификатор кабинета
        /// </summary>
        public override int Id { get; }

        /// <summary>
        /// Номер кабинета
        /// </summary>
        [Column("Number")]
        [Required]
        [MaxLength(4)]
        public override string Name { get; set; }

        /// <summary>
        /// Отдел, работающий в кабинете
        /// </summary>
        [ForeignKey("Otdel_id")]
        public Department Department { get; set; }

        #endregion Fields

        #region Constructors
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        private Cabinet() { }

        /// <summary>
        /// Конструктор содержащий номер кабинета. Идентификатор кабинета будет получен автоматически
        /// </summary>
        /// <param name="number">Номер кабинета</param>
        public Cabinet(byte number)
        {
            Name = number.ToString();
        }
        #endregion Constructors

        #region Methods
        #endregion Methods
    }
}
