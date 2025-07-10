using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BloodMixerSystem_Events : SystemBase
{
    EntityQuery _InsertPotionEventQuery;
    EntityQuery _SwapPotionEventQuery;
    EntityQuery _RemovePotionEventQuery;
    EntityQuery _StartMixEventQuery;
    EntityQuery _CancelMixEventQuery;
    EntityQuery __query_1093555822_0;
    EntityQuery __query_1093555822_1;
    EntityQuery __query_1093555822_2;
    EntityQuery __query_1093555822_3;
    EntityQuery __query_1093555822_4;
    EntityQuery __query_1093555822_5;
    EntityQuery __query_1093555822_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _InsertPotionEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BloodMixerEvents.InsertPotion>(),
            },
        });
        
        _SwapPotionEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BloodMixerEvents.SwapPotions>(),
            },
        });
        
        _RemovePotionEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BloodMixerEvents.RemovePotion>(),
            },
        });
        
        _StartMixEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BloodMixerEvents.StartMix>(),
            },
        });
        
        _CancelMixEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BloodMixerEvents.CancelMix>(),
            },
        });
        
        __query_1093555822_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BloodMixerEvents.InsertPotion>(),
            },
        });
        
        __query_1093555822_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BloodMixerEvents.SwapPotions>(),
            },
        });
        
        __query_1093555822_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BloodMixerEvents.RemovePotion>(),
            },
        });
        
        __query_1093555822_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BloodMixerEvents.StartMix>(),
            },
        });
        
        __query_1093555822_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BloodMixerEvents.CancelMix>(),
            },
        });
        
        __query_1093555822_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1093555822_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
