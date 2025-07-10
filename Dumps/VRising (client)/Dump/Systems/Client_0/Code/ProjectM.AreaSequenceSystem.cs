using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AreaSequenceSystem : SystemBase
{
    EntityQuery __query_496561001_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_496561001_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadWrite<ProjectM.AreaSequence>(),
            },
        });
        
    }
    

}
