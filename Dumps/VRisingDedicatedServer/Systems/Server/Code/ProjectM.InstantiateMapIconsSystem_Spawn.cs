using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InstantiateMapIconsSystem_Spawn : SystemBase
{
    EntityQuery __query_1050583619_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1050583619_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AttachMapIconsToEntity>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
