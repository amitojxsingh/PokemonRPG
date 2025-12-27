using System;
using PokemonRPG.Models;

namespace PokemonRPG.Repositories;

public abstract class BaseRepository<T> : IRepository<T> where T : class, IIdentifiable
{
    protected abstract List<T> _items { get; }
    public T? Get(int id)
    {
        return _items.Where(m => m.Id == id).FirstOrDefault();
    }
    public IList<T> GetAll()
    {
        return _items;
    }
    public int Save(T item, bool allowUpdate = true)
    {
        var existingMove = Get(item.Id);
        if(item.Id > 0 && existingMove != null)
        {   // items exists
            if(allowUpdate)
            {   
                // update existing
                _items[_items.IndexOf(existingMove)] = item;
                return item.Id;
            }
            return -1;
        }
        // add new item
        var newID = _items.OrderBy(m => m.Id).Last().Id + 1;
        _items.Add(item);
        return newID;
    }

}
