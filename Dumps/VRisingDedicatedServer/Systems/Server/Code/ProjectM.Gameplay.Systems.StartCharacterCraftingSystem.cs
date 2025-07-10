using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class StartCharacterCraftingSystem : SystemBase
{
    EntityQuery _StartCharacterCraftItemEventQuery;
    EntityQuery __query_970757445_0;
    EntityQuery __query_970757445_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _StartCharacterCraftItemEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.StartCharacterCraftItemEvent>(),
            },
        });
        
        __query_970757445_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.StartCharacterCraftItemEvent>(),
            },
        });
        
        __query_970757445_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
