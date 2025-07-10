using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup))]
public class ServerGameSettingsSystem : SystemBase
{
    EntityQuery __query_677022946_0;
    EntityQuery __query_677022946_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_677022946_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
        __query_677022946_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
