using System.Runtime.Serialization;

namespace Cursach.Model
{
    /// <summary>
    /// Абстрактный класс обертка для сериализации в JSON
    /// </summary>
    [DataContract]
    [KnownType(typeof(Person))]
    [KnownType(typeof(Receipt))]
    [KnownType(typeof(Service))]
    [KnownType(typeof(Household))]
    public abstract class Model
    {
    }

}
