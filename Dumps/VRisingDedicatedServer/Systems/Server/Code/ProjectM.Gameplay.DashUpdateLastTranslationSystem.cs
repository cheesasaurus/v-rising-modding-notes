using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DashUpdateLastTranslationSystem : SystemBase
{
    EntityQuery __query_691853163_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_691853163_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dash>(),
                ComponentType.ReadWrite<ProjectM.LastTranslation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
