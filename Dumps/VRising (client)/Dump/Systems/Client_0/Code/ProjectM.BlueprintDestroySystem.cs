using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BlueprintDestroySystem : SystemBase
{
    EntityQuery _DismantleSequenceQuery;
    EntityQuery _BlueprintDestroyTagQuery;
    EntityQuery __query_565706678_0;
    EntityQuery __query_565706678_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DismantleSequenceQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DismantleDestroyData>(),
                ComponentType.ReadOnly<ProjectM.BlueprintData>(),
            },
        });
        
        _BlueprintDestroyTagQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DismantleDestroyData>(),
                ComponentType.ReadOnly<ProjectM.BlueprintData>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_565706678_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DismantleDestroyData>(),
                ComponentType.ReadOnly<ProjectM.BlueprintData>(),
            },
        });
        
        __query_565706678_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DismantleDestroyData>(),
                ComponentType.ReadOnly<ProjectM.BlueprintData>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
