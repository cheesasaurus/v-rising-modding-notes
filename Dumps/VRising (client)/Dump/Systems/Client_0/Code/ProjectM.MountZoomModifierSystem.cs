using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.CameraPresentationGroup))]
[UpdateBefore(typeof(ProjectM.ZoomModifierAreaSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.ZoomModifierSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class MountZoomModifierSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1589129708_0;
    EntityQuery __query_1589129708_1;
    EntityQuery __query_1589129708_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.MountBuff>(),
            },
        });
        
        __query_1589129708_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.MountBuff>(),
            },
        });
        
        __query_1589129708_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1589129708_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
