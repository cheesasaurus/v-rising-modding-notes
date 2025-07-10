using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateCharacterCraftingSystem : SystemBase
{
    EntityQuery __query_970757715_0;
    EntityQuery __query_970757715_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_970757715_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
                ComponentType.ReadOnly<ProjectM.QueuedWorkstationCraftAction>(),
                ComponentType.ReadOnly<ProjectM.QueuedWorkstationCraftActionItems>(),
            },
        });
        
        __query_970757715_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
