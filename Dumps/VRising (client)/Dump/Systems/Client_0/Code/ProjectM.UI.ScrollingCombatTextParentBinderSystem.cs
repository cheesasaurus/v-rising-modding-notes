using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ScrollingCombatTextParentBinderSystem : SystemBase
{
    EntityQuery _SCTQuery;
    EntityQuery __query_451949702_0;
    EntityQuery __query_451949702_1;
    EntityQuery __query_451949702_2;
    EntityQuery __query_451949702_3;
    EntityQuery __query_451949702_4;
    EntityQuery __query_451949702_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SCTQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ScrollingCombatTextMessage>(),
                ComponentType.ReadWrite<ProjectM.UI.ScrollingCombatText>(),
            },
        });
        
        __query_451949702_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_451949702_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ScrollingCombatTextMessage>(),
                ComponentType.ReadWrite<ProjectM.UI.ScrollingCombatText>(),
            },
        });
        
        __query_451949702_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_451949702_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_451949702_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridCameraData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_451949702_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
