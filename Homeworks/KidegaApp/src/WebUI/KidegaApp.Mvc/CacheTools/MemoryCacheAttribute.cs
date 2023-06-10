using System;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;
using KidegaApp.Mvc;
using KidegaApp.DataTransferObjects.Responses;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KidegaApp.Mvc.Controllers;

public class MemoryCacheAttribute : ActionFilterAttribute
{
    private readonly string _cacheKey;
    private readonly int _cacheDurationSeconds;
    private readonly IMemoryCache _cache;

    public MemoryCacheAttribute(string cacheKey, int cacheDurationSeconds)
    {
        _cacheKey = cacheKey;
        _cacheDurationSeconds = cacheDurationSeconds;
        _cache = new MemoryCache(new MemoryCacheOptions());
    }

    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        if (_cache.TryGetValue(_cacheKey, out IEnumerable<ProductDisplayResponse> cachedData))
        {
            ((Controller)filterContext.Controller).ViewBag.ProductData = cachedData;
        }
        else
        {
            base.OnActionExecuting(filterContext);
        }
    }

    public override void OnActionExecuted(ActionExecutedContext filterContext)
    {
        if (!_cache.TryGetValue(_cacheKey, out IEnumerable<ProductDisplayResponse> cachedData))
        {
            var dataToCache = ((Controller)filterContext.Controller).ViewBag.ProductData;

            cachedData = dataToCache;

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(_cacheDurationSeconds));

            _cache.Set(_cacheKey, cachedData, cacheEntryOptions);
            
        }

        base.OnActionExecuted(filterContext);
    }
}
