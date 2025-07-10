using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ServantPowerSystem : SystemBase
{
    EntityQuery __query_147760816_0;
    EntityQuery __query_147760816_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_147760816_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServantEquipment>(),
                ComponentType.ReadWrite<ProjectM.ServantPower>(),
                ComponentType.ReadWrite<ProjectM.UnitLevel>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_147760816_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Health>(),
                ComponentType.ReadWrite<ProjectM.ServantPower>(),
                ComponentType.ReadOnly<ProjectM.ServantPowerConstants>(),
                ComponentType.ReadWrite<ProjectM.UnitStats>(),
            },
        });
        
    }
    

}
