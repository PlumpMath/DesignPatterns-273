using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDAL.Generic
{
    /// <summary>
    /// generic DAO interface for doing CRUD operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericDAO<T> where T : class
    {
        /// <summary>
        /// return all records from entity accordint to the link expression
        /// </summary>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetAll(string IndexName, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);



        /// <summary>
        /// add a new entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Add(T entity);

        /// <summary>
        /// delete an entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// find and delete an entity
        /// </summary>
        /// <param name="entity"></param>
        void GetSingleDelete(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// update a persistent entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// save enity state
        /// </summary>
        void Save();

        /// <summary>
        /// bulk insert
        /// </summary>
        /// <param name="items"></param>
        T[] Add(T[] items);

        /// <summary>
        /// bulk update
        /// </summary>
        /// <param name="items"></param>
        void Update(params T[] items);

        /// <summary>
        /// bulk delete
        /// </summary>
        /// <param name="items"></param>
        void Remove(params T[] items);


        /// <summary>
        /// find a row by primary key
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        T Find(object obj);
    }
}
