using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.Presentation.FadeOutObstaclesSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class FadeOutObstaclesUploadDataSystem : SystemBase
{
    EntityQuery __query_162406219_0;
    EntityQuery __query_162406219_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_162406219_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.CurrentFadingShaderDataSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_162406219_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.CurrentFadingDataSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
