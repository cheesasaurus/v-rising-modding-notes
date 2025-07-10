using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AfterDeserializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DiscoveredMapZonesClientSystem : SystemBase
{
    EntityQuery __query_1760820144_0;
    EntityQuery __query_1760820144_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1760820144_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.MapZoneDiscoveredEvent>(),
            },
        });
        
        __query_1760820144_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DiscoveredMapZonesEvent>(),
            },
        });
        
    }
    

}
