using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class JointConversionFinalizationSystem : SystemBase
{
    EntityQuery __query_1825084357_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1825084357_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.LinkToJointOwner>(),
                ComponentType.ReadOnly<Unity.Physics.PhysicsJoint>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
    }
    

}
