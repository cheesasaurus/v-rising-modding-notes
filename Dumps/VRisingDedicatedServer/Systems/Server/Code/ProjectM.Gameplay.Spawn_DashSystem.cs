using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step2))]
[RequireMatchingQueriesForUpdateAttribute]
public class Spawn_DashSystem : SystemBase
{
    EntityQuery _SpawnDashQuery;
    EntityQuery __query_691853023_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SpawnDashQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.Dash>(),
                ComponentType.ReadOnly<ProjectM.DashSpawn>(),
                ComponentType.ReadWrite<ProjectM.LifeTime>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_691853023_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.Dash>(),
                ComponentType.ReadOnly<ProjectM.DashSpawn>(),
                ComponentType.ReadWrite<ProjectM.LifeTime>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
