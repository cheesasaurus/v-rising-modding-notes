using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class JewelNetworkEventsSystem : SystemBase
{
    EntityQuery _EquipEventQuery;
    EntityQuery _UnequipEventQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EquipEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.EquipJewelEvent>(),
            },
        });
        
        _UnequipEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.UnequipJewelEvent>(),
            },
        });
        
    }
    

}
