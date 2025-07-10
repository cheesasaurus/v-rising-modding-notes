using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.WallpaperGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class BuildMenuWallpaperOperationSequencerSystem : SystemBase
{
    EntityQuery __query_2013418422_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2013418422_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.BuildMenuWallpaperOperation>(),
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperationSequenceData>(),
            },
        });
        
    }
    

}
