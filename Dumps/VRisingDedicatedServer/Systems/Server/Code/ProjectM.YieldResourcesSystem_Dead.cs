using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class YieldResourcesSystem_Dead : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1400280656_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.YieldResourcesOnDamageTaken>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Handled>(),
            },
        });
        
        __query_1400280656_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.YieldResourcesOnDamageTaken>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Handled>(),
            },
        });
        
    }
    

}
