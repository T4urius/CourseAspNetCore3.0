﻿using System.Collections.Generic;

namespace Courses.API.Services
{
    public interface IPropertyMappingService
    {
        Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>();
    }
}