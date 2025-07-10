using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.CameraPresentationGroup))]
[UpdateBefore(typeof(ProjectM.ZoomModifierAreaSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.ZoomModifierSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ZoomModifierBuffSystem : SystemBase
{
    EntityQuery __query_2086938463_0;
    EntityQuery __query_2086938463_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2086938463_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.ZoomModifierBuff>(),
            },
        });
        
        __query_2086938463_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
