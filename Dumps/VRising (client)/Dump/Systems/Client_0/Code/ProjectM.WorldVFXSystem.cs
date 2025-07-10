using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class WorldVFXSystem : SystemBase
{
    EntityQuery __query_1612712158_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1612712158_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridCameraData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
