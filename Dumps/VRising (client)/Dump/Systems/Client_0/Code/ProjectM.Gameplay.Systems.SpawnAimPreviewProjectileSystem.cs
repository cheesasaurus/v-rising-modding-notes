using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.AimPreviewGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.AimPreviewProjectileSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnAimPreviewProjectileSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_367403009_0;
    EntityQuery __query_367403009_1;
    EntityQuery __query_367403009_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewProjectile>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.SpawnAimPreviewProjectileSystem.SpawnedAimPreviewProjectile>(),
            },
        });
        
        __query_367403009_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewProjectile>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.SpawnAimPreviewProjectileSystem.SpawnedAimPreviewProjectile>(),
            },
        });
        
        __query_367403009_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewsDisabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_367403009_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
