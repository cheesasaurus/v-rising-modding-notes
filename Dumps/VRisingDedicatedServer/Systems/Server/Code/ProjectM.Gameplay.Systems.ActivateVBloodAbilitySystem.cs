using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ActivateVBloodAbilitySystem : SystemBase
{
    EntityQuery _ActivateVBloodAbilityQuery;
    EntityQuery __query_410846147_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ActivateVBloodAbilityQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ActivateVBloodAbilityEvent>(),
            },
        });
        
        __query_410846147_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ActivateVBloodAbilityEvent>(),
            },
        });
        
    }
    

}
