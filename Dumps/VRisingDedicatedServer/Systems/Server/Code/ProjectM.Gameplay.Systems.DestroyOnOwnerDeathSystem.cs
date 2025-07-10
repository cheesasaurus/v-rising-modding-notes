using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyOnOwnerDeathSystem : SystemBase
{
    EntityQuery _EntityQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EntityQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.DestroyOnOwnerDeath>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
