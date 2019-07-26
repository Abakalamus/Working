namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    ///Базовый абстрактный класс объектов фонда  
    /// </summary>
    public abstract class BaseObject
    {
        /// <summary>
        /// Внутренний идентификатор объекта
        /// </summary>
        public abstract int Id { get; set; }
        /// <summary>
        /// Наименование объекта
        /// </summary>
        public abstract string Name { get; set; }

        //public abstract int GetID();
    }
}
