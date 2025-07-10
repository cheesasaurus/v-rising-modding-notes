using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.EquipItemSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class TransmogEventsSystem : SystemBase
{
    EntityQuery _TransmogColorEventQuery;
    EntityQuery _TransmogInvisibleEventQuery;
    EntityQuery __query_823775846_0;
    EntityQuery __query_823775846_1;
    EntityQuery __query_823775846_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _TransmogColorEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ChangeTransmogColorEvent>(),
            },
        });
        
        _TransmogInvisibleEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.SetInvisibleTransmogModelEvent>(),
            },
        });
        
        __query_823775846_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ChangeTransmogColorEvent>(),
            },
        });
        
        __query_823775846_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.SetInvisibleTransmogModelEvent>(),
            },
        });
        
        __query_823775846_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
