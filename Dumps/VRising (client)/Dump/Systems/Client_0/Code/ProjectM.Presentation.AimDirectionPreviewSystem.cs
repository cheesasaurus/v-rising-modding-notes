using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.AimPreviewGroup))]
public class AimDirectionPreviewSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_1508757058_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1508757058_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildMode>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
