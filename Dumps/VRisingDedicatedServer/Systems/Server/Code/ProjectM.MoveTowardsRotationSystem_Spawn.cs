using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MoveTowardsRotationSystem_Spawn : SystemBase
{
    EntityQuery _MainQuery;
    EntityQuery __query_335314741_0;
    EntityQuery __query_335314741_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.MoveTowardsRotationBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_335314741_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.MoveTowardsRotationBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_335314741_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ModificationsRegistry>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
