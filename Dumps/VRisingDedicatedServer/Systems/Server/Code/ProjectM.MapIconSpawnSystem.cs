using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MapIconSpawnSystem : SystemBase
{
    EntityQuery __query_1050583545_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1050583545_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.MapIconPosition>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
