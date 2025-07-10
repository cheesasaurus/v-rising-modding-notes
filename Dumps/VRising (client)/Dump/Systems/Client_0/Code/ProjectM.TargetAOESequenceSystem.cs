using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TargetAOESequenceSystem : SystemBase
{
    EntityQuery __query_803841660_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_803841660_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
                ComponentType.ReadOnly<ProjectM.TargetAoE>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadWrite<ProjectM.TargetAOESequence>(),
            },
        });
        
    }
    

}
