## How to reproduce

Install spacetimedb: https://spacetimedb.com/install

Start spacetimedb:

```bash
spacetime start
```

Compile and publish the module:

```bash
spacetime publish --project-path ./Module box2d-net-in-spacetime
```

Observe error:

```
Error: System.NullReferenceException: Arg_NullReferenceException
   at Box2D.NET.B2World.Clear()
   at Box2D.NET.B2Worlds.b2CreateWorld(B2WorldDef& )
   at StdbModule.ExampleModule.CreateWorld()
   at StdbModule.ExampleModule.Init(ReducerContext )
   at ModuleRegistration.Init.Invoke(BinaryReader , IReducerContext )
   at SpacetimeDB.Internal.Module.__call_reducer__(UInt32 id, UInt64 sender_0, UInt64 sender_1, UInt64 sender_2, UInt64 sender_3, UInt64 conn_id_0, UInt64 conn_id_1, Timestamp timestamp, BytesSource args, BytesSink error)
```
