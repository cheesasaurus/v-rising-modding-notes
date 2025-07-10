using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.CameraPresentationGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.ZoomModifierSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ZoomModifierAreaSystem : SystemBase
{
    EntityQuery __query_993758049_0;
    EntityQuery __query_993758049_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_993758049_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ZoomModifierArea>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_993758049_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
