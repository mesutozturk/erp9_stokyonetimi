namespace Sy.Core.Abstracts
{
    public interface IEntity2 : IEntity
    {
    }

    public interface IEntity2<TKey1, TKey2> : IEntity<TKey1>
    {
        TKey2 Id2 { get; set; }
    }
}
