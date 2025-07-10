using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class NetworkInterpolationSystem_Server : SystemBase
{
    EntityQuery __query_1748990150_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1748990150_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityInput>(),
                ComponentType.ReadOnly<ProjectM.IsSpellControlled>(),
                ComponentType.ReadWrite<ProjectM.Network.NetworkInterpolated_Shared>(),
                ComponentType.ReadOnly<ProjectM.Velocity>(),
                ComponentType.ReadOnly<ProjectM.MoveVelocity>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
