using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step2))]
[RequireMatchingQueriesForUpdateAttribute]
public class Spawn_TravelBuffSystem : SystemBase
{
    EntityQuery __query_615926983_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_615926983_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.LifeTime>(),
                ComponentType.ReadWrite<ProjectM.TravelBuff>(),
                ComponentType.ReadOnly<ProjectM.TravelBuffSpawn>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
