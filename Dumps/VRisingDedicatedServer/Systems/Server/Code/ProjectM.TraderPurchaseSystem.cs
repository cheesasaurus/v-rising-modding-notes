using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TraderPurchaseSystem : SystemBase
{
    EntityQuery _TraderPurchaseEventQuery;
    EntityQuery __query_178718498_0;
    EntityQuery __query_178718498_1;
    EntityQuery __query_178718498_2;
    EntityQuery __query_178718498_3;
    EntityQuery __query_178718498_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _TraderPurchaseEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.TraderPurchaseEvent>(),
            },
        });
        
        __query_178718498_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.TraderPurchaseEvent>(),
            },
        });
        
        __query_178718498_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_178718498_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CurveCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_178718498_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.JewelSpawnSystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_178718498_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
