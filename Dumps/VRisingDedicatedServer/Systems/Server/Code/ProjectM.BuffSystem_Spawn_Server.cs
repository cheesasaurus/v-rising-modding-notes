using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BuffSystem_Spawn_Server : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_401358634_0;
    EntityQuery __query_401358634_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_401358634_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_401358634_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
