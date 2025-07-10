using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CloseAllMenuSpawnSystem : SystemBase
{
    EntityQuery __query_1067256927_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1067256927_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Shared.Systems.CloseAllMenu>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
