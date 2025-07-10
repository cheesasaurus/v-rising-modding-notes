using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SharedInventorySystem_Syncing : SystemBase
{
    EntityQuery __query_614111106_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_614111106_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SharedCastleInventoryInstance>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SharedCastleInventoryItems>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
