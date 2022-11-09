﻿using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace FamilyHubs.ServiceDirectory.Shared.Helpers;

public interface IRedisCache
{
    T? GetValue<T>(string key);
    void SetValue<T>(string key, T value);
}

public class RedisCache : IRedisCache
{

    private readonly IConfiguration _configuration;
    private readonly IDatabase _cache;

    public RedisCache(IConfiguration configuration)
    {
        _configuration = configuration;
        Lazy<ConnectionMultiplexer> connectionMultiplexer = new Lazy<ConnectionMultiplexer>(() =>
        {
            string cacheConnection = _configuration["CacheConnection"] ?? string.Empty;
            return ConnectionMultiplexer.Connect(cacheConnection);
        });

        _cache = connectionMultiplexer.Value.GetDatabase();
    }

    public void SetStringValue(string key, string value)
    {
        _cache.StringSet(key, value);
    }

    public string? GetStringValue(string key)
    {
       
        try
        {
            return _cache.StringGet(key);
        }
        catch  //(RedisConnectionException ex)
        {
            throw;
        }
    }

    public void SetValue<T>(string key, T value)
    {
        var jsonObject = JsonConvert.SerializeObject(value);
        _cache.StringSet(key, jsonObject);
    }

    //https://gist.github.com/benhysell/110deca326edda1c7b16 might be useful

    public T? GetValue<T>(string key)
    {
        try
        {
            if (key == null)
                return default(T);

            var value = _cache.StringGet(key);
            if (!value.IsNull)
            {
#pragma warning disable CS8604
                return JsonConvert.DeserializeObject<T>(value);
#pragma warning restore CS8604
            }
            else
            {
                return default(T);
            }
        }
        catch //(RedisConnectionException ex)
        {
            throw;
        }
    }

}