namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    ///Базовый абстрактный класс объектов фонда  
    /// </summary>
    public abstract class BaseObject<T>
    {
        #region Fields
        /// <summary>
        /// Внутренний идентификатор объекта
        /// </summary>
        public abstract int Id { get; set; }
        /// <summary>
        /// Семантическое (человекопонятное) наименование сущности объекта (имя, номер и т.д.)
        /// </summary>
        public abstract T Value { get; set; }
        #endregion Fields

        //public abstract int GetID();
    }
}
