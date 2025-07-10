using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TravelBuffSequenceSystem : SystemBase
{
    EntityQuery __query_824381064_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_824381064_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
                ComponentType.ReadOnly<ProjectM.TravelBuff>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadWrite<ProjectM.TravelBuffSequence>(),
            },
        });
        
    }
    

}
