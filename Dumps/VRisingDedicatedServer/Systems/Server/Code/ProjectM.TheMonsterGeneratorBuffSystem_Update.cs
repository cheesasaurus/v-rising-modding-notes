using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TheMonsterGeneratorBuffSystem_Update : SystemBase
{
    EntityQuery __query_666345431_0;
    EntityQuery __query_666345431_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_666345431_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TheMonsterGeneratorActiveBuff>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
            },
        });
        
        __query_666345431_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TheMonsterGeneratorActiveBuff>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.MonsterGeneratorBindingInitialized>(),
            },
        });
        
    }
    

}
