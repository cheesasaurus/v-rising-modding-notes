using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[UpdateBefore(typeof(ProjectM.SpellModSpawnSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CopySpellmodFromAbilitySystem : SystemBase
{
    EntityQuery __query_2002907942_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2002907942_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.CopySpellModSetFromAbilitySlot>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
