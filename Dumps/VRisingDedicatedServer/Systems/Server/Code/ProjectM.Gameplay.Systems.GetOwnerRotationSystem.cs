using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.AbilityGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class GetOwnerRotationSystem : SystemBase
{
    EntityQuery __query_1724439169_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1724439169_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GetOwnerRotation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GetOwnerRotationOnlyOnSpawnTag>(),
            },
        });
        
    }
    

}
