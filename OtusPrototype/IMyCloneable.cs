
using System.Runtime.InteropServices;

namespace OtusPrototype
{
    //1. Пользовательский интерфейс: IMyCloneable
    //я создал универсальный интерфейс IMyCloneable, который определяет
    //метод для клонирования объектов.

    public interface IMyCloneable<T>
    {
        T Clone();
    }
}
