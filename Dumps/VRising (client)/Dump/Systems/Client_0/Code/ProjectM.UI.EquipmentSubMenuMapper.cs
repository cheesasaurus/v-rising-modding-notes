using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class EquipmentSubMenuMapper : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_430091994_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.EquipmentSubMenu>(),
            },
        });
        
        __query_430091994_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.EquipmentSubMenu>(),
            },
        });
        
    }
    

}
