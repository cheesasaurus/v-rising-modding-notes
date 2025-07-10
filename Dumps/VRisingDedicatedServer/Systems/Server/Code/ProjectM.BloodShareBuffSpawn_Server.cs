using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BloodShareBuffSpawn_Server : SystemBase
{
    EntityQuery __query_207468152_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_207468152_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.BloodShareBuff_ResetVBlood>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
