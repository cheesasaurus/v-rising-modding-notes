using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SpawnGroup))]
[UpdateAfter(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AttachSystem_Spawn : ProjectM.AttachSystemBase
{
    EntityQuery __query_1229206188_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1229206188_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Attach>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Attached>(),
                ComponentType.ReadOnly<ProjectM.DisabledWaitingForSync>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
