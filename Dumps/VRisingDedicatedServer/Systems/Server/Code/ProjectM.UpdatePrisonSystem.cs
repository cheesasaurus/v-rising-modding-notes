using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdatePrisonSystem : SystemBase
{
    EntityQuery __query_1044980191_0;
    EntityQuery __query_1044980191_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1044980191_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleWorkstation>(),
                ComponentType.ReadOnly<ProjectM.InventoryOwner>(),
                ComponentType.ReadOnly<ProjectM.Prisonstation>(),
                ComponentType.ReadOnly<ProjectM.QueuedWorkstationCraftAction>(),
                ComponentType.ReadOnly<ProjectM.WorkstationRecipesBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1044980191_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserActivityGrid>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
