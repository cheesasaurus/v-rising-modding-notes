using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SmartMergeItemsBetweenInventoriesSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_133601682_0;
    EntityQuery __query_133601682_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.SmartMergeItemsBetweenInventoriesEvent>(),
            },
        });
        
        __query_133601682_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.SmartMergeItemsBetweenInventoriesEvent>(),
            },
        });
        
        __query_133601682_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
