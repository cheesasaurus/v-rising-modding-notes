using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.StatChangeSystem))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.StatChangeMutationSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyBuffOnMoveSystem : SystemBase
{
    EntityQuery __query_922633302_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_922633302_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.DestroyBuffOnMove>(),
            },
        });
        
    }
    

}
