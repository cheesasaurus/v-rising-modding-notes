using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MusicPlayerStationSystem_UnlockTracksSystem : SystemBase
{
    EntityQuery _RegionChangedEventQuery;
    EntityQuery __query_186082986_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RegionChangedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.CurrentWorldRegionChangedEvent>(),
            },
        });
        
        __query_186082986_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationTrack_Shared>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.OutdatedPrefab>(),
            },
        });
        
    }
    

}
