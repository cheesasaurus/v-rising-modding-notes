using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.DestroyGroup))]
[UpdateAfter(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DetachSystem : SystemBase
{
    EntityQuery _ReturnIdQuery;
    EntityQuery __query_1229206336_0;
    EntityQuery __query_1229206336_1;
    EntityQuery __query_1229206336_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ReturnIdQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AttachParentId>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AttachedBuffer>(),
            },
        });
        
        __query_1229206336_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Attached>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Attach>(),
            },
        });
        
        __query_1229206336_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Attached>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_1229206336_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AttachParentId>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AttachedBuffer>(),
            },
        });
        
    }
    

}
