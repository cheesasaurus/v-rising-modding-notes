using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class JewelCraftingUpdateSystem : SystemBase
{
    EntityQuery __query_1259428393_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1259428393_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.JewelCraftingStation>(),
                ComponentType.ReadOnly<ProjectM.EditableTileModel>(),
                ComponentType.ReadOnly<ProjectM.CastleWorkstation>(),
                ComponentType.ReadWrite<ProjectM.JewelCraftingProcessingRequiredItem>(),
                ComponentType.ReadOnly<ProjectM.WorkstationRecipesBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
