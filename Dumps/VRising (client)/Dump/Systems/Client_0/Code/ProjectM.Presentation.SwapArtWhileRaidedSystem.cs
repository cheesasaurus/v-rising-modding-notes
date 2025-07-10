using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SwapArtWhileRaidedSystem : SystemBase
{
    EntityQuery __query_427253174_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_427253174_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SwapArtWhileRaidedRoot>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SwapArtWhileRaidedElement>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
