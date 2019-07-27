﻿namespace TFOMS_Zab_Kray.Classes
{
    /// <summary>
    ///Базовый абстрактный класс объектов фонда  
    /// </summary>
    public abstract class BaseObject
    {
        #region Fields
        /// <summary>
        /// Внутренний идентификатор объекта
        /// </summary>
        public abstract int Id { get; }
        /// <summary>
        /// Семантическое (человекопонятное) наименование сущности объекта (имя, номер и т.д.)
        /// </summary>
        public abstract string Name { get; set; }
        #endregion Fields

        //public abstract int GetID();
    }
}
