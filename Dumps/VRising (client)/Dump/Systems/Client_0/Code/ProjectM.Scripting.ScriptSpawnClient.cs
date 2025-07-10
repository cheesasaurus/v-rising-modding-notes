using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateAfter(typeof(ProjectM.SetupInitialStatesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ScriptSpawnClient : SystemBase
{
    EntityQuery __query_949122841_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_949122841_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.Scripting.ScriptSpawn>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
