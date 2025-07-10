using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class StablesSystem_MountItemGain : SystemBase, ProjectM.IPersistentSystemSerializer
{
    EntityQuery _Query;
    EntityQuery __query_1751579315_0;
    EntityQuery __query_1751579315_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Stables_Shared>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1751579315_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UtcTicksSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1751579315_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDatas>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
