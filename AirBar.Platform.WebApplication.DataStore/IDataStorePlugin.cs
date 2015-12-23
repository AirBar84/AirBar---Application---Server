using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBar.Platform.WebApplication.DataStore
{
    /// <summary>
    /// Base interface for Data-Store Provider Plugins. This should give us an increased level of flexibility in 
    /// terms of our choices of Data Persistence Providers.
    /// </summary>
    public interface IDataStorePlugin
    {
        /// <summary>
        /// Creates a new Object within the Data-Store Provider.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        void CreateObject<T>(T obj);


        void ModifyObject<T>(T obj);

        void RemoveObject<T>(T obj);
        
        T GetObject<T>(T objId);

        IEnumerable<T> GetAllObjects<T>();

        IEnumerable<T> QueryObjects<T>(); 
    }
}
