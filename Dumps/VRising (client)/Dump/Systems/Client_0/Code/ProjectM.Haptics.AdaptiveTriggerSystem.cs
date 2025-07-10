using Unity.Entities;

namespace ProjectM.Haptics;


[UpdateInGroup(typeof(ProjectM.AfterDeserializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AdaptiveTriggerSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_1934787327_0;
    EntityQuery __query_1934787327_1;
    EntityQuery __query_1934787327_2;
    EntityQuery __query_1934787327_3;
    EntityQuery __query_1934787327_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1934787327_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
            },
        });
        
        __query_1934787327_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.AdaptiveTriggerCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1934787327_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.BlockedAdaptiveTriggers>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1934787327_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildMode>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1934787327_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Haptics.BlockedAdaptiveTriggers>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
