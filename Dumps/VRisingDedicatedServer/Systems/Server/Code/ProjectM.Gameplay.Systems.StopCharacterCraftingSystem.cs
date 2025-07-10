using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class StopCharacterCraftingSystem : SystemBase
{
    EntityQuery _StopCharacterCraftItemEventQuery;
    EntityQuery __query_970757628_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _StopCharacterCraftItemEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.StopCharacterCraftItemEvent>(),
            },
        });
        
        __query_970757628_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.StopCharacterCraftItemEvent>(),
            },
        });
        
    }
    

}
