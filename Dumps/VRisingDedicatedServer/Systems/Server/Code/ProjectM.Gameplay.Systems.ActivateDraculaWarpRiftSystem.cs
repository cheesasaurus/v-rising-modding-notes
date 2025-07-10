using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ActivateDraculaWarpRiftSystem : SystemBase
{
    EntityQuery _DraculaSpawnChainsQuery;
    EntityQuery _DraculaSpawnerQuery;
    EntityQuery _ActivateWarpRiftQuery;
    EntityQuery __query_62796406_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DraculaSpawnChainsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnChainData.SpawnChainInstance>(),
                ComponentType.ReadOnly<ProjectM.StaticTransformIndex>(),
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.DraculaSpawnChain>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        _DraculaSpawnerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Gameplay.Scripting.Script_Dracula_SpawnerData>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        _ActivateWarpRiftQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.ActivateDraculaWarpRift>(),
            },
        });
        
        __query_62796406_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.ActivateDraculaWarpRift>(),
            },
        });
        
    }
    

}
