using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(PresentationSystemGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class RevealMapPresentationSystem : SystemBase
{
    EntityQuery __query_478346340_0;
    EntityQuery __query_478346340_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_478346340_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldZoneId>(),
            },
        });
        
        __query_478346340_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
