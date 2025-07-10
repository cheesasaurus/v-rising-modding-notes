using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.BuildModeGroup))]
public class BuildGridSystem : SystemBase
{
    EntityQuery _PreviewBuffQuery;
    EntityQuery _ShowBuildGridQuery;
    EntityQuery __query_1914000342_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _PreviewBuffQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PreviewPlacementBuff>(),
            },
        });
        
        _ShowBuildGridQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ShowBuildGrid>(),
            },
        });
        
        __query_1914000342_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.PreviewPlacementBuff>(),
            },
        });
        
    }
    

}
