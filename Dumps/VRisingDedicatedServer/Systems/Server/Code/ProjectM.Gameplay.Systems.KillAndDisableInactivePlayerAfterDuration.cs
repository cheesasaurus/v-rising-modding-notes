using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class KillAndDisableInactivePlayerAfterDuration : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1915096620_0;
    EntityQuery __query_1915096620_1;
    EntityQuery __query_1915096620_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadWrite<ProjectM.Network.DisconnectedTimer>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_1915096620_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadWrite<ProjectM.Network.DisconnectedTimer>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_1915096620_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1915096620_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
