namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    ///Базовый абстрактный класс объектов фонда  
    /// </summary>
    public abstract class ItemObject : BaseObject<string>
    {
        #region Fields
        /// <summary>
        /// Внутренний идентификатор объекта
        /// </summary>
        public abstract override int Id { get; set; }
        /// <summary>
        /// Семантическое (человекопонятное) наименование сущности объекта (фирма, модель и т.д.)
        /// </summary>
        public abstract override string Value { get; set; }
        /// <summary>
        /// Является ли объект расходным материалом
        /// </summary>
        public abstract bool IsConsumable { get; set; }
        #endregion Fields
    }
}
