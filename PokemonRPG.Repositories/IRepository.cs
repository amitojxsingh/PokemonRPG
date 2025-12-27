using System;
using PokemonRPG.Models;

namespace PokemonRPG.Repositories;

public interface IRepository<T> where T : class, IIdentifiable
{
    T?  Get(int id);
    IList<T> GetAll();

    /// <summary>
    /// Saves the item by create or update if allowedUpdate is true
    /// Else returns an error if the item already exists
    /// </summary>
    /// <param name="item"></param>
    /// <param name="allowUpdate"></param>
    /// <returns></returns>
    int Save(T item, bool allowUpdate = true);
}
