using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateAfter(typeof(ProjectM.HybridModelSeed_Spawn))]
[RequireMatchingQueriesForUpdateAttribute]
public class MountBuffSpawnSystem_Server : SystemBase
{
    EntityQuery __query_1228665165_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1228665165_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadWrite<ProjectM.MountBuff>(),
                ComponentType.ReadWrite<Unity.Transforms.Rotation>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
