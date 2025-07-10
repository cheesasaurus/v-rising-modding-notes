using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(InitializationSystemGroup))]
public class ClientScriptMapper : SystemBase
{
    EntityQuery __query_949122275_0;
    EntityQuery __query_949122275_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_949122275_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_949122275_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Physics.DebugShowPhysicsCasts>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
