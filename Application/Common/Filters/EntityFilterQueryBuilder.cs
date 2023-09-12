using BookingServices.Application.Common.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;



namespace BookingServices.Application.Common.Filters
{
    public class EntityFilterQueryBuilder<TEntity> 
    {
        private IQueryable<TEntity> _query;

        public EntityFilterQueryBuilder(IQueryable<TEntity> query)
        {
            _query = query;
        }

        public EntityFilterQueryBuilder<TEntity> FilterByField(string field, string key, string value)
        {
            PropertyInfo property = typeof(TEntity).GetProperty(field);

            if (property == null)
            {
                throw new InvalidQueryBuilderException();
            }

            ParameterExpression parameter = Expression.Parameter(typeof(TEntity));
            Expression propertyExpression = Expression.Property(parameter, property);
            Expression compareExpression = Expression.Equal(propertyExpression, Expression.Constant(value));

            switch (key)
            {
                case "eq":
                    compareExpression = Expression.Equal(propertyExpression, Expression.Constant(value));
                    break;
                case "neq":
                    compareExpression = Expression.NotEqual(propertyExpression, Expression.Constant(value));
                    break;
            }

            Expression<Func<TEntity, bool>> lambda = Expression.Lambda<Func<TEntity, bool>>(compareExpression, parameter);

            _query = _query.Where(lambda);

            return this;
        }

        public EntityFilterQueryBuilder<TEntity> SortByField(string field, string sortOrder)
        {
            PropertyInfo property = typeof(TEntity).GetProperty(field);

            if (property == null)
            {
                throw new InvalidQueryBuilderException();
            }

            ParameterExpression parameter = Expression.Parameter(typeof(TEntity));
            Expression propertyExpression = Expression.Property(parameter, property);
            LambdaExpression lambda = Expression.Lambda(propertyExpression, parameter);

            string methodName = sortOrder == "desc" ? "OrderByDescending" : "OrderBy";
            Type[] types = { typeof(TEntity), property.PropertyType };

            MethodInfo method = typeof(Queryable).GetMethods()
                .Where(m => m.Name == methodName && m.GetParameters().Length == 2)
                .Single()
                .MakeGenericMethod(types);

            _query = (IQueryable<TEntity>)method.Invoke(null, new object[] { _query, lambda });

            return this;
        }

        public async Task<List<TEntity>> ExecuteAsync(CancellationToken cancellationToken)
        {
            return await _query.ToListAsync(cancellationToken);
        }

    }
}
