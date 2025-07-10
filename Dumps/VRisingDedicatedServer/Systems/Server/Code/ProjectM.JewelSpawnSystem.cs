using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
public class JewelSpawnSystem : SystemBase, ProjectM.IPersistentSystemSerializer
{
    EntityQuery _JewelSpawnQuery;
    EntityQuery _LegendaryItemSpawnQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _JewelSpawnQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.JewelInstance>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        _LegendaryItemSpawnQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.LegendaryItemInstance>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.JewelSpawnSystem.ManuallyGeneratedLegendaryItem>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
