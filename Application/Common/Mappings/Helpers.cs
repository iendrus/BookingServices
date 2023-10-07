using AutoMapper;
using BookingServices.Domain.Common;


namespace BookingServices.Application.Common.Mappings
{
    public static class Helpers
    {
        public static IMappingExpression<TSource, TDestination> IgnoreAuditableAndTypeOfClassMembers<TSource, 
            TDestination>(this IMappingExpression<TSource, TDestination> expr)
        {
            var destinationType = typeof(TDestination);

            foreach (var property in destinationType.GetProperties())
            {
                if (property.DeclaringType == typeof(AuditableEntity) || property.PropertyType.IsSubclassOf(typeof(AuditableEntity)))
                {
                    expr.ForMember(property.Name, opt => opt.Ignore());
                }
            }
            return expr;
        }
    }
}
