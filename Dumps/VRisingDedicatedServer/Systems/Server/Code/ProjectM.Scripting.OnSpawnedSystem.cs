using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class OnSpawnedSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1603026828_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Scripting.OnSpawnedCallback>(),
            },
        });
        
        __query_1603026828_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Scripting.OnSpawnedCallback>(),
            },
        });
        
    }
    

}
