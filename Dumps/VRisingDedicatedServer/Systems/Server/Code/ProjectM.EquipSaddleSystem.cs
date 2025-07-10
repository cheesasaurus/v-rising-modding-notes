using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class EquipSaddleSystem : SystemBase
{
    EntityQuery _EquipSaddleEventQuery;
    EntityQuery _UnequipSaddleEventQuery;
    EntityQuery __query_471647430_0;
    EntityQuery __query_471647430_1;
    EntityQuery __query_471647430_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EquipSaddleEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.EquipSaddleEvent>(),
            },
        });
        
        _UnequipSaddleEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.UnequipSaddleEvent>(),
            },
        });
        
        __query_471647430_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.EquipSaddleEvent>(),
            },
        });
        
        __query_471647430_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.UnequipSaddleEvent>(),
            },
        });
        
        __query_471647430_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
