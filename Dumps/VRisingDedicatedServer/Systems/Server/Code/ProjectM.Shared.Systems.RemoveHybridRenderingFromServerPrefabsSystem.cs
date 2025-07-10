using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RemoveHybridRenderingFromServerPrefabsSystem : SystemBase
{
    EntityQuery _VolumeQuery;
    EntityQuery _VolumeBoxColliderQuery;
    EntityQuery _VolumeSphereColliderQuery;
    EntityQuery _HDLightQuery;
    EntityQuery _LightQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _VolumeQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<UnityEngine.Rendering.Volume>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        _VolumeBoxColliderQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<UnityEngine.Rendering.Volume>(),
                ComponentType.ReadOnly<UnityEngine.BoxCollider>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        _VolumeSphereColliderQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<UnityEngine.Rendering.Volume>(),
                ComponentType.ReadOnly<UnityEngine.SphereCollider>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        _HDLightQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<UnityEngine.Rendering.HighDefinition.HDAdditionalLightData>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        _LightQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<UnityEngine.Light>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
    }
    

}
