using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ForceCraftingStationsEventSystem : SystemBase
{
    EntityQuery _ForceCraftingEvents;
    EntityQuery __query_1583105017_0;
    EntityQuery __query_1583105017_1;
    EntityQuery __query_1583105017_2;
    EntityQuery __query_1583105017_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ForceCraftingEvents = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ForceCraftingStationsEvent>(),
            },
        });
        
        __query_1583105017_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ForceCraftingStationsEvent>(),
            },
        });
        
        __query_1583105017_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Refinementstation>(),
                ComponentType.ReadOnly<ProjectM.RefinementstationRecipesBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1583105017_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UnitSpawnerstation>(),
                ComponentType.ReadOnly<ProjectM.RefinementstationRecipesBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1583105017_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.QueuedWorkstationCraftAction>(),
                ComponentType.ReadOnly<ProjectM.WorkstationRecipesBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
