using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetPreCombatPositionSystem_Spawn : SystemBase
{
    EntityQuery _BossCenterPositionQuery;
    EntityQuery __query_689776906_0;
    EntityQuery __query_689776906_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _BossCenterPositionQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.AiPointOfInterest_BossCenterPosition>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_689776906_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AggroConsumer>(),
                ComponentType.ReadWrite<ProjectM.UseBossCenterPositionAsPreCombatPosition>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Minion>(),
            },
        });
        
        __query_689776906_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AggroConsumer>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Minion>(),
                ComponentType.ReadOnly<ProjectM.UseBossCenterPositionAsPreCombatPosition>(),
            },
        });
        
    }
    

}
