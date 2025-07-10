using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.BeforeTransformSystemGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class UserTranslationCopySystem : SystemBase
{
    EntityQuery __query_844125951_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_844125951_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
