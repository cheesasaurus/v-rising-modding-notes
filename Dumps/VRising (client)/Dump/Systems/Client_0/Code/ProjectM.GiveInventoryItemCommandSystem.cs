using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ConsoleCommandGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GiveInventoryItemCommandSystem : ProjectM.GameplayConsoleCommandSystem
{
    EntityQuery __query_1301506736_0;
    EntityQuery __query_1301506736_1;
    EntityQuery __query_1301506736_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1301506736_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityGroupState>(),
                ComponentType.ReadOnly<ProjectM.Shared.AbilitySpellModItem>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1301506736_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.LegendaryItemInstance>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1301506736_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.VampireCombatPreset>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
