using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс принтеров
    /// </summary>
    [Table("PRINTERS")]
    public class Printer: ItemObject
    {
        #region Fields
        /// <summary>
        /// Идентификатор принтера
        /// </summary>
        [Key]
        [Column("Printer_Id")]
        public override int Id { get; set; }

        /// <summary>
        /// Фирма-производитель
        /// </summary>
        [Column("Manufacturer")]
        [MaxLength(20)]
        [Required]
        public override string Value { get; set; }

        /// <summary>
        /// Серия принтера
        /// </summary>
        [Column("Series")]
        [MaxLength(40)]
        [Required]
        public string Series { get; set; }

        /// <summary>
        /// Закрытый ли принтер
        /// </summary>
        [Column("IsClosed")]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Ip-адрес присвоенный принтеру
        /// </summary>
        [Column("IP")]
        [MaxLength(16)]
        public string IP { get; set; }

        public int? CabinetId { get; set; }
        /// <summary>
        /// Идентификатор кабинета, где расположен принтер
        /// </summary>       
        [Column("Id_cabinet")]
        public Cabinet Cabinet { get; set; }

        /// <summary>
        /// Является ли объект расходным материалом
        /// </summary>
        //[NotMapped]
        [Column("IsConsumable")]
        public override bool IsConsumable { get; set; } = false;
        #endregion Fields
    }
}
