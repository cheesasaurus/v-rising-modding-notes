using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TrophySystem_Events_Client : SystemBase
{
    EntityQuery _UnlockQuery;
    EntityQuery _ResetQuery;
    EntityQuery __query_1256893479_0;
    EntityQuery __query_1256893479_1;
    EntityQuery __query_1256893479_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _UnlockQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UnlockTrophyEvent>(),
            },
        });
        
        _ResetQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TrophyRequests.Reset>(),
            },
        });
        
        __query_1256893479_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UnlockTrophyEvent>(),
            },
        });
        
        __query_1256893479_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TrophyRequests.Reset>(),
            },
        });
        
        __query_1256893479_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.CurrentWorldRegionChangedEvent>(),
            },
        });
        
    }
    

}
