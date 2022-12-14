using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace FamilyHubs.ServiceDirectory.Shared.Helpers;

public interface IRedisCache
{
    string? GetStringValue(string key);
    void SetStringValue(string key, string value);
    T? GetValue<T>(string key);
    void SetValue<T>(string key, T value);
    void SetValue<T>(string key, T value, int timeOutInMinutes);
    void SetStringValue(string key, string value, int timeOutInMinutes);
}

public class RedisCache : IRedisCache
{
    private readonly IDatabase _cache;

    public RedisCache(IConfiguration configuration)
    {
        var connectionMultiplexer = new Lazy<ConnectionMultiplexer>(() =>
        {
            var cacheConnection = configuration["CacheConnection"] ?? string.Empty;
            return ConnectionMultiplexer.Connect(cacheConnection);
        });

        _cache = connectionMultiplexer.Value.GetDatabase();
    }

    public void SetStringValue(string key, string value, int timeOutInMinutes)
    {
        var ts = TimeSpan.FromMinutes(timeOutInMinutes);
        _cache.StringSet(key, value, ts);
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

    public void SetValue<T>(string key, T value, int timeOutInMinutes)
    {
        var ts = TimeSpan.FromMinutes(timeOutInMinutes);
        var jsonObject = JsonConvert.SerializeObject(value);
        _cache.StringSet(key, jsonObject, ts);
    }

    //https://gist.github.com/benhysell/110deca326edda1c7b16 might be useful

    public T? GetValue<T>(string key)
    {
        try
        {
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