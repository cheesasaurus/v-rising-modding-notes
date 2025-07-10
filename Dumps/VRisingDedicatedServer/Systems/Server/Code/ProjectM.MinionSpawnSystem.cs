using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[UpdateAfter(typeof(ProjectM.Shared.Systems.BloodQualitySpawnSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class MinionSpawnSystem : SystemBase
{
    EntityQuery __query_166459767_0;
    EntityQuery __query_166459767_1;
    EntityQuery __query_166459767_2;
    EntityQuery __query_166459767_3;
    EntityQuery __query_166459767_4;
    EntityQuery __query_166459767_5;
    EntityQuery __query_166459767_6;
    EntityQuery __query_166459767_7;
    EntityQuery __query_166459767_8;
    EntityQuery __query_166459767_9;
    EntityQuery __query_166459767_10;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_166459767_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Minion>(),
                ComponentType.ReadWrite<ProjectM.EntityInput>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_166459767_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AggroConsumer>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Minion>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.AggroBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_166459767_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.EntityCreator>(),
                ComponentType.ReadOnly<ProjectM.Minion>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_166459767_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Minion>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_166459767_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Minion>(),
                ComponentType.ReadWrite<ProjectM.IsMinion>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_166459767_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Health>(),
                ComponentType.ReadOnly<ProjectM.UnitLevel>(),
                ComponentType.ReadOnly<ProjectM.UnitLevelServerData>(),
                ComponentType.ReadOnly<ProjectM.UnitSpawnData>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UnitLevelChanged>(),
                ComponentType.ReadOnly<ProjectM.UnitBaseStatsTypeChanged>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_166459767_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Torture>(),
                ComponentType.ReadOnly<ProjectM.UnitSpawnData>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_166459767_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.BloodConsumeSource>(),
                ComponentType.ReadOnly<ProjectM.UnitSpawnData>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_166459767_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Minion>(),
                ComponentType.ReadWrite<ProjectM.Health>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_166459767_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UnitLevel>(),
                ComponentType.ReadOnly<ProjectM.UnitLevelServerData>(),
                ComponentType.ReadOnly<ProjectM.UnitStats>(),
                ComponentType.ReadOnly<ProjectM.UnitSpawnData>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UnitLevelChanged>(),
                ComponentType.ReadOnly<ProjectM.UnitBaseStatsTypeChanged>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_166459767_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Minion>(),
                ComponentType.ReadOnly<ProjectM.UnitStats>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
