using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(InitializationSystemGroup))]
public class ServerScriptMapper : SystemBase
{
    EntityQuery __query_884424475_0;
    EntityQuery __query_884424475_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_884424475_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_884424475_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Physics.DebugShowPhysicsCasts>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
