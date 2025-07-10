using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class KickBanSystem_Server : SystemBase
{
    EntityQuery _KickQuery;
    EntityQuery _BanQuery;
    EntityQuery _BannedQuery;
    EntityQuery __query_1201276332_0;
    EntityQuery __query_1201276332_1;
    EntityQuery __query_1201276332_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _KickQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.KickEvent>(),
            },
        });
        
        _BanQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.BanEvent>(),
            },
        });
        
        _BannedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BannedEvent.Request0>(),
            },
        });
        
        __query_1201276332_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BannedEvent.Request0>(),
            },
        });
        
        __query_1201276332_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.KickEvent>(),
            },
        });
        
        __query_1201276332_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.BanEvent>(),
            },
        });
        
    }
    

}
