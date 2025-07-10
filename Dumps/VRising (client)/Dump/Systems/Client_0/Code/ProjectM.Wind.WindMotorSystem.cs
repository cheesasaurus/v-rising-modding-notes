using Unity.Entities;

namespace ProjectM.Wind;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.Wind.WindSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class WindMotorSystem : SystemBase
{
    EntityQuery __query_2127118923_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2127118923_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadWrite<ProjectM.Wind.WindMotor>(),
            },
        });
        
    }
    

}
