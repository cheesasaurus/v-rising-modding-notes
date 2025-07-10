using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class StaticTransformUpdateSystem_ReactToSpawn_Server : SystemBase
{
    EntityQuery __query_1145212189_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1145212189_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.StaticTransformCompatible>(),
                ComponentType.ReadOnly<ProjectM.Network.Networked>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
