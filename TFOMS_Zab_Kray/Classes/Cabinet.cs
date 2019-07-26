using TFOMS_Zab_Kray.Interfaces;
using System.Data.Common;

namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    /// Класс кабинетов ТФОМС
    /// </summary>
    public class Cabinet : BaseObject, IIdentified
    {
        /// <summary>
        /// Идентификатор кабинета
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// Название кабинета
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Внутренняя переменная для номера кабинета 
        /// </summary>
        private byte _number;
        /// <summary>
        /// Номер кабинета
        /// </summary>
        public byte Number { get; set; }

        /// <summary>
        /// Базовый конструктор
        /// </summary>
        public Cabinet() { }

        /// <summary>
        /// Контструктор содержащий название кабинета. Идентификатор кабинета будет получен автоматически
        /// </summary>
        /// <param name="name">Название кабинета</param>
        /// <param name="number">Номер кабинета</param>
        public Cabinet(string name, byte number)
        {
            Id = GetID();
            Name = name;
            Number = number;
        }

        /// <summary>
        /// Полный конструктор класса. Использовать рекомендуется только в тестовых целях, так как автоматическое получение идентификатора надежнее
        /// </summary>
        /// <param name="id">Внутренний идентификатор кабинета</param>
        /// <param name="name">Название кабинета</param>
        /// <param name="number">Номер кабинета</param>
        public Cabinet(byte id, string name, byte number)
        {
            Id = id;
            Name = name;
            Number = number;
        }

        public int GetID()
        {
            using (Oracle.ManagedDataAccess.Client.OracleConnection s = new Oracle.ManagedDataAccess.Client.OracleConnection())
            {

            }
            return 0;
        }
    }
}
