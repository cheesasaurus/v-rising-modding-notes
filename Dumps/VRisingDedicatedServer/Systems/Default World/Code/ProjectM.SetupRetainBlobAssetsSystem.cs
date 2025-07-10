using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(Unity.Scenes.SceneSystemGroup), OrderLast = true)]
public class SetupRetainBlobAssetsSystem : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.BlobAssetOwner>(),
                ComponentType.ReadOnly<Unity.Entities.SceneTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.RetainBlobAssets>(),
            },
        });
        
    }
    

}
