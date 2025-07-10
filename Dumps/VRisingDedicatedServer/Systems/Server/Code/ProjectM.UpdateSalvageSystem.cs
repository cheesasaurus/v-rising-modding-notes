using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateSalvageSystem : SystemBase
{
    EntityQuery __query_307453300_0;
    EntityQuery __query_307453300_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_307453300_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Salvagestation>(),
                ComponentType.ReadOnly<ProjectM.CastleWorkstation>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_307453300_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserActivityGrid>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
