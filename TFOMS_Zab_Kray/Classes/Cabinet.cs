using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс кабинетов ТФОМС
    /// </summary>
    [Table("CABINETS")]
    public class Cabinet : BaseObject<byte>
    {
        #region Fields
        /// <summary>
        /// Идентификатор кабинета
        /// </summary>
        [Key]
        public override int Id { get; }

        /// <summary>
        /// Номер кабинета
        /// </summary>
        [Column("Number")]
        [Required]
        public override byte Value { get; set; }

        /// <summary>
        /// Отдел, работающий в кабинете
        /// </summary>
        [ForeignKey("Otdel_id")]
        public Department Department { get; set; }

        /// <summary>
        /// Идентификатор здания, где расположен кабинет
        /// </summary>
        public Building BuildingID { get; set; }

        /// <summary>
        /// Идентификатор этажа, где расположен кабинет
        /// </summary>
        public Floor FloorID { get; set; }

        #endregion Fields

        #region Constructors
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        private Cabinet() { }

        /// <summary>
        /// Конструктор содержащий номер кабинета. Идентификатор кабинета будет получен автоматически
        /// </summary>
        /// <param name="number">Номер</param>
        /// <param name="building">Здание</param>
        /// <param name="floor">Этаж</param>
        public Cabinet(byte number, Building building, Floor floor)
        {
            Value = number;
            BuildingID = building;
            FloorID = floor;
        }
        #endregion Constructors

        #region Methods
        #endregion Methods
    }
}
