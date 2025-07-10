using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TraderSyncSystem : SystemBase
{
    EntityQuery __query_178718819_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_178718819_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TraderSpawnData>(),
                ComponentType.ReadOnly<ProjectM.UnitCompositionActiveUnit>(),
                ComponentType.ReadWrite<ProjectM.TraderEntry>(),
                ComponentType.ReadWrite<ProjectM.TradeCost>(),
                ComponentType.ReadWrite<ProjectM.TradeOutput>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
