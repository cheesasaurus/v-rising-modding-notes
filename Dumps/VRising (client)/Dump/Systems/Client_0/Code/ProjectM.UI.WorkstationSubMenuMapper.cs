using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class WorkstationSubMenuMapper : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1615533893_0;
    EntityQuery __query_1615533893_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.WorkstationSubMenu>(),
            },
        });
        
        __query_1615533893_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.WorkstationSubMenu>(),
            },
        });
        
        __query_1615533893_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
