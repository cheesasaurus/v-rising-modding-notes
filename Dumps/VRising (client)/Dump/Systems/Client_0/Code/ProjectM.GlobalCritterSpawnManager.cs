using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class GlobalCritterSpawnManager : SystemBase
{
    EntityQuery _LocalPlayerQuery;
    EntityQuery __query_1513795485_0;
    EntityQuery __query_1513795485_1;
    EntityQuery __query_1513795485_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _LocalPlayerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Controller>(),
                ComponentType.ReadWrite<ProjectM.Network.LocalUser>(),
            },
        });
        
        __query_1513795485_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CritterGroup>(),
            },
        });
        
        __query_1513795485_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CritterSpawn>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_1513795485_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
