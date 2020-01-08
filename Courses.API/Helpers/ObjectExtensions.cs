using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.API.Helpers
{
    public static class ObjectExtensions
    {
        public static ExpandoObject ShapeData<TSource>(this TSource source, string fields)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var dataShapedObject = new ExpandoObject();

            if(string.IsNullOrWhiteSpace(fields))
            {
                var propertyInfos = typeof(TSource).GetProperties(System.Reflection.BindingFlags.IgnoreCase | 
                    System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

                foreach(var propertyInfo in propertyInfos)
                {

                }
            }
        }
    }
}
