using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateCraftingSystem : SystemBase
{
    EntityQuery __query_1831452872_0;
    EntityQuery __query_1831452872_1;
    EntityQuery __query_1831452872_2;
    EntityQuery __query_1831452872_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1831452872_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EditableTileModel>(),
                ComponentType.ReadOnly<ProjectM.CastleWorkstation>(),
                ComponentType.ReadOnly<ProjectM.QueuedWorkstationCraftAction>(),
                ComponentType.ReadOnly<ProjectM.WorkstationRecipesBuffer>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Prisonstation>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1831452872_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserActivityGrid>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1831452872_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1831452872_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDatas>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
