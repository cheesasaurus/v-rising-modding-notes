using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.Sequencer.SequencerEarlyUpdateGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.HybridModelSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridEquipmentSystem : SystemBase
{
    EntityQuery _HybridEquipmentToDestroyQuery;
    EntityQuery __query_2092691472_0;
    EntityQuery __query_2092691472_1;
    EntityQuery __query_2092691472_2;
    EntityQuery __query_2092691472_3;
    EntityQuery __query_2092691472_4;
    EntityQuery __query_2092691472_5;
    EntityQuery __query_2092691472_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _HybridEquipmentToDestroyQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.HybridCurrentEquipment>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridEquipmentUser>(),
            },
        });
        
        __query_2092691472_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridDefaultEquipment>(),
                ComponentType.ReadWrite<ProjectM.HybridCurrentEquipment>(),
            },
        });
        
        __query_2092691472_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadWrite<ProjectM.HybridCurrentCustomization>(),
                ComponentType.ReadWrite<ProjectM.HybridCurrentEquipment>(),
            },
        });
        
        __query_2092691472_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.HybridCurrentEquipment>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridEquipmentUser>(),
            },
        });
        
        __query_2092691472_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2092691472_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridEquipmentStreamingHandler.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2092691472_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2092691472_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
