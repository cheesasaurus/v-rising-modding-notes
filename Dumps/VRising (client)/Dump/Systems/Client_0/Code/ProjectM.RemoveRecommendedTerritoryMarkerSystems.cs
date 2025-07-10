using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RemoveRecommendedTerritoryMarkerSystems : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_482434383_0;
    EntityQuery __query_482434383_1;
    EntityQuery __query_482434383_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TutorialMarker>(),
            },
        });
        
        __query_482434383_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TutorialMarker>(),
            },
        });
        
        __query_482434383_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_482434383_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
