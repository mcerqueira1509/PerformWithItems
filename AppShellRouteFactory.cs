
namespace PerformWithItems;

public class AppShellRouteFactory<T> : RouteFactory
    where T : Element
{
    public T Instance { get; set; }
    public override Element GetOrCreate()
    {
        Instance ??= (T)Activator.CreateInstance(typeof(T));
        return Instance;
    }

    public override Element GetOrCreate(IServiceProvider services)
        => GetOrCreate();
}
