using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.EarlyUpdateGroup))]
public class P2PClanAutoJoinSystem : SystemBase
{
    EntityQuery _ConnectedQuery;
    EntityQuery __query_2102716145_0;
    EntityQuery __query_2102716145_1;
    EntityQuery __query_2102716145_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ConnectedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserConnectedServerEvent>(),
            },
        });
        
        __query_2102716145_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ClanInviteRequest_Shared>(),
            },
        });
        
        __query_2102716145_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserConnectedServerEvent>(),
            },
        });
        
        __query_2102716145_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MiscLocalizationKeysSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
