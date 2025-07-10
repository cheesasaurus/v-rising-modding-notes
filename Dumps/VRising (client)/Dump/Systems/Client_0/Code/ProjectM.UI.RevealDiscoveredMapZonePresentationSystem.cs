using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.UI.AnnouncementHUDSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class RevealDiscoveredMapZonePresentationSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_478346222_0;
    EntityQuery __query_478346222_1;
    EntityQuery __query_478346222_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.MapZoneDiscoveredEvent>(),
            },
        });
        
        __query_478346222_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneData>(),
                ComponentType.ReadOnly<ProjectM.Terrain.MapZonePolygonVertexElement>(),
            },
        });
        
        __query_478346222_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.MapZoneDiscoveredEvent>(),
            },
        });
        
        __query_478346222_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
