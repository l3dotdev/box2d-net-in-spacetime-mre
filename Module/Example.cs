using Box2D.NET;
using SpacetimeDB;

namespace StdbModule;

public static partial class ExampleModule
{
    private static B2WorldId CreateWorld()
    {
        var def = new B2WorldDef
        {
            enableSleep = true,
            gravity = new B2Vec2(0, 0)
        };

        return B2Worlds.b2CreateWorld(ref def);
    }

    [Reducer(ReducerKind.Init)]
    public static void Init(ReducerContext ctx)
    {
        var world = CreateWorld();

    }
}