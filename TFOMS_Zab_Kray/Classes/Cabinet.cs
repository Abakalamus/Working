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

        public int? DepartmentId { get; set; }
        /// <summary>
        /// Отдел, работающий в кабинете
        /// </summary>       
        public Department Department { get; set; }

        public int BuildingID { get; set; }
        /// <summary>
        /// Идентификатор здания, где расположен кабинет
        /// </summary>
        public Building Building { get; set; }

        public int FloorID { get; set; }
        /// <summary>
        /// Идентификатор этажа, где расположен кабинет
        /// </summary>
        public Floor Floor { get; set; }

        #endregion Fields


    }
}
