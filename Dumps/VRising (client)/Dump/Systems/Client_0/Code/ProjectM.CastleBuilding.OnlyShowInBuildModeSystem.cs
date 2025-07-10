using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class OnlyShowInBuildModeSystem : SystemBase
{
    EntityQuery _HiddenObjects;
    EntityQuery _ShownObjects;
    EntityQuery __query_1079888882_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _HiddenObjects = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.OnlyShowInBuildModeTag>(),
                ComponentType.ReadOnly<Unity.Rendering.DisableRendering>(),
            },
        });
        
        _ShownObjects = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.OnlyShowInBuildModeTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DisableRendering>(),
            },
        });
        
        __query_1079888882_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
