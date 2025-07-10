using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
public class PacketBookkeeperSystem : SystemBase
{
    EntityQuery __query_429629665_0;
    EntityQuery __query_429629665_1;
    EntityQuery __query_429629665_2;
    EntityQuery __query_429629665_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_429629665_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_429629665_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.PacketBookkeeperSystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_429629665_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.WorldFrame>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_429629665_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.PacketBookkeeperSystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
