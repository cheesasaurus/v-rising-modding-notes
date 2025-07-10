using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ConsoleCommandGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ClientSequencerConsoleCommandSystem : ProjectM.GameplayConsoleCommandSystem
{
    EntityQuery __query_203293477_0;
    EntityQuery __query_203293477_1;
    EntityQuery __query_203293477_2;
    EntityQuery __query_203293477_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_203293477_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_203293477_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CursorPosition>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_203293477_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_203293477_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
