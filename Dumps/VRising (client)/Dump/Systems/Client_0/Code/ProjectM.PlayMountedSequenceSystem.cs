using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class PlayMountedSequenceSystem : SystemBase
{
    EntityQuery __query_415563668_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_415563668_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.PlayMountedSequence>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
            },
        });
        
    }
    

}
