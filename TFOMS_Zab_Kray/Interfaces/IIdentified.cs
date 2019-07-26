namespace TFOMS_Zab_Kray.Interfaces
{
    /// <summary>
    /// Интерфейс для объектов реализующиъ систему идентификаторов
    /// </summary>
    interface IIdentified
    {
        /// <summary>
        /// Получение идентификатора объекта
        /// </summary>
        /// <returns>Идентификатор объекта</returns>
        int GetID();
    }
}
