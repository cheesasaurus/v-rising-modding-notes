using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class NetworkInterpolationSystem_SpawnClient : SystemBase
{
    EntityQuery __query_1748990267_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1748990267_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntityInput>(),
                ComponentType.ReadOnly<ProjectM.Height>(),
                ComponentType.ReadOnly<ProjectM.Network.NetworkInterpolated_Shared>(),
                ComponentType.ReadWrite<ProjectM.LastTranslation>(),
                ComponentType.ReadWrite<ProjectM.Velocity>(),
                ComponentType.ReadWrite<ProjectM.MoveVelocity>(),
                ComponentType.ReadWrite<Unity.Transforms.Rotation>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
