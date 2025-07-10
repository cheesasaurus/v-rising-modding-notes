using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.AimPreviewGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.AimPreviewTargetAoeSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnAimPreviewTargetAoeSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_702996099_0;
    EntityQuery __query_702996099_1;
    EntityQuery __query_702996099_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewTargetAoE>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.SpawnAimPreviewTargetAoeSystem.SpawnedAimPreviewTargetAoE>(),
            },
        });
        
        __query_702996099_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewTargetAoE>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.SpawnAimPreviewTargetAoeSystem.SpawnedAimPreviewTargetAoE>(),
            },
        });
        
        __query_702996099_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewsDisabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_702996099_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
