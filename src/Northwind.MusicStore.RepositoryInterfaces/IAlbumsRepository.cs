﻿using System.Collections.Generic;
using Northwind.MusicStore.Domain;

namespace Northwind.MusicStore.RepositoryInterfaces
{
    public interface IAlbumsRepository : IRepository<Album>
    {
        IEnumerable<Album> GetTopSellingAlbums(int count);
    }
}