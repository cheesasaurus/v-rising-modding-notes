using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CharacterCraftingSubMenuMapper : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1415343308_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.CharacterCraftingSubMenu>(),
            },
        });
        
        __query_1415343308_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.CharacterCraftingSubMenu>(),
            },
        });
        
    }
    

}
