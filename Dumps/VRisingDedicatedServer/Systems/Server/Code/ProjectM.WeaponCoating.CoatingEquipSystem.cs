using Unity.Entities;

namespace ProjectM.WeaponCoating;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CoatingEquipSystem : SystemBase
{
    EntityQuery _ApplyCoatingEvents;
    EntityQuery _InternalApplyCoatingEvents;
    EntityQuery __query_1145599324_0;
    EntityQuery __query_1145599324_1;
    EntityQuery __query_1145599324_2;
    EntityQuery __query_1145599324_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ApplyCoatingEvents = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ApplyCoatingEvent>(),
            },
        });
        
        _InternalApplyCoatingEvents = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ApplyCoatingEvent_Internal>(),
            },
        });
        
        __query_1145599324_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ApplyCoatingEvent>(),
            },
        });
        
        __query_1145599324_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ApplyCoatingEvent_Internal>(),
            },
        });
        
        __query_1145599324_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1145599324_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
