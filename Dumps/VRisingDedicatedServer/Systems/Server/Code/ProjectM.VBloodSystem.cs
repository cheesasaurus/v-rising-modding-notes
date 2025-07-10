using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class VBloodSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_871570244_0;
    EntityQuery __query_871570244_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Blood>(),
                ComponentType.ReadOnly<ProjectM.ControlledBy>(),
            },
        });
        
        __query_871570244_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Blood>(),
                ComponentType.ReadOnly<ProjectM.ControlledBy>(),
            },
        });
        
        __query_871570244_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
