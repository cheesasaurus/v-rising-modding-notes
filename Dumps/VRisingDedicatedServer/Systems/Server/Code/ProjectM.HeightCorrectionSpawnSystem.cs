using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class HeightCorrectionSpawnSystem : SystemBase
{
    EntityQuery __query_496389193_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_496389193_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Height>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
