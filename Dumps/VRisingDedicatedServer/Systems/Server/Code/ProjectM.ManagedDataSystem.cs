using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
public class ManagedDataSystem : Stunlock.Core.ManagedDataSystem_Base
{
    EntityQuery _RegisterManagedDataWithoutBlobAssetOwnerQuery;
    EntityQuery _RegisterManagedDataWithBlobAssetOwnerQuery;
    EntityQuery __query_1604019850_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RegisterManagedDataWithoutBlobAssetOwnerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterManagedDataEvent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.BlobAssetOwner>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        _RegisterManagedDataWithBlobAssetOwnerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterManagedDataEvent>(),
                ComponentType.ReadOnly<Unity.Entities.BlobAssetOwner>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1604019850_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterManagedDataEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
