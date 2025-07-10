using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class JewelCraftingSubMenuMapper : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_654366442_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.JewelCraftingSubMenu>(),
            },
        });
        
        __query_654366442_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.JewelCraftingSubMenu>(),
            },
        });
        
    }
    

}
