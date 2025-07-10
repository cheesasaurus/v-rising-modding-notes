using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class VisualizeMapMarkerGuidanceSystem : SystemBase
{
    EntityQuery _MarkerQuery;
    EntityQuery __query_1342852481_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MarkerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.PlayerCustomMarker>(),
            },
        });
        
        __query_1342852481_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MarkerGuidanceSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
