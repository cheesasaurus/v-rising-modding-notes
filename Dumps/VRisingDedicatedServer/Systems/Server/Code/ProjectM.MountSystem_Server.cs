using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MountSystem_Server : SystemBase
{
    EntityQuery __query_1228665492_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1228665492_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadWrite<ProjectM.MountBuff>(),
            },
        });
        
    }
    

}
