
namespace Unity.Entities;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RetainBlobAssetSystem : SystemBase
{
    EntityQuery __query_975679986_0;
    EntityQuery __query_975679986_1;
    EntityQuery __query_975679986_2;
    EntityQuery __query_975679986_3;
    EntityQuery __query_975679986_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_975679986_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.RetainBlobAssets>(),
                ComponentType.ReadWrite<Unity.Entities.BlobAssetOwner>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.RetainBlobAssetBatchPtr>(),
            },
        });
        
        __query_975679986_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.RetainBlobAssets>(),
                ComponentType.ReadWrite<Unity.Entities.RetainBlobAssetBatchPtr>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.BlobAssetOwner>(),
            },
        });
        
        __query_975679986_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.RetainBlobAssets>(),
                ComponentType.ReadWrite<Unity.Entities.RetainBlobAssetPtr>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.BlobAssetOwner>(),
            },
        });
        
        __query_975679986_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.RetainBlobAssets>(),
                ComponentType.ReadWrite<Unity.Entities.RetainBlobAssetBatchPtr>(),
            },
        });
        
        __query_975679986_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.RetainBlobAssets>(),
                ComponentType.ReadWrite<Unity.Entities.RetainBlobAssetPtr>(),
            },
        });
        
    }
    

}
