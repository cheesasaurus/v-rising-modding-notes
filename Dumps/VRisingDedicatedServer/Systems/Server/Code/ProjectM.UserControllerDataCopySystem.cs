using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.BeforeTransformSystemGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class UserControllerDataCopySystem : SystemBase
{
    EntityQuery __query_844126117_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_844126117_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadWrite<ProjectM.Network.UserControllerData>(),
            },
        });
        
    }
    

}
