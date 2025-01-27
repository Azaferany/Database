﻿using EasyMicroservices.Database.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMicroservices.Database.MongoDB.Providers
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class MongoReadableQueryableProvider<TEntity> : IEasyReadableQueryableAsync<TEntity>
        where TEntity : class
    {
        private readonly IQueryable<TEntity> _queryable;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryable"></param>
        public MongoReadableQueryableProvider(IQueryable<TEntity> queryable)
        {
            _queryable = queryable;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type ElementType => _queryable.ElementType;
        /// <summary>
        /// 
        /// </summary>
        public Expression Expression => _queryable.Expression;
        /// <summary>
        /// 
        /// </summary>
        public IQueryProvider Provider => _queryable.Provider;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> AllAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(_queryable.All(predicate));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> AnyAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(_queryable.Any());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(_queryable.Any(predicate));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IAsyncEnumerable<TEntity> AsAsyncEnumerable()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<decimal> AverageAsync(Expression<Func<TEntity, decimal>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<decimal?> AverageAsync(Expression<Func<TEntity, decimal?>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<double> AverageAsync(Expression<Func<TEntity, int>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<double?> AverageAsync(Expression<Func<TEntity, int?>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<double> AverageAsync(Expression<Func<TEntity, long>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<double?> AverageAsync(Expression<Func<TEntity, long?>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<double> AverageAsync(Expression<Func<TEntity, double>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<double?> AverageAsync(Expression<Func<TEntity, double?>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<float> AverageAsync(Expression<Func<TEntity, float>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<float?> AverageAsync(Expression<Func<TEntity, float?>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<bool> ContainsAsync(TEntity item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> FirstAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> FirstOrDefaultAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerator<TEntity> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> LastAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> LastAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> LastOrDefaultAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> LastOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task LoadAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<long> LongCountAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> MaxAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TResult> MaxAsync<TResult>(Expression<Func<TEntity, TResult>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> MinAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TResult> MinAsync<TResult>(Expression<Func<TEntity, TResult>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> SingleAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> SingleOrDefaultAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<decimal> SumAsync(Expression<Func<TEntity, decimal>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<decimal?> SumAsync(Expression<Func<TEntity, decimal?>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<int> SumAsync(Expression<Func<TEntity, int>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<int?> SumAsync(Expression<Func<TEntity, int?>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<long> SumAsync(Expression<Func<TEntity, long>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<long?> SumAsync(Expression<Func<TEntity, long?>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<double> SumAsync(Expression<Func<TEntity, double>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<double?> SumAsync(Expression<Func<TEntity, double?>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<float> SumAsync(Expression<Func<TEntity, float>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<float?> SumAsync(Expression<Func<TEntity, float?>> selector, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TEntity[]> ToArrayAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<List<TEntity>> ToListAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string ToQueryString()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
