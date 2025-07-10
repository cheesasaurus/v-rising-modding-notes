using Unity.Entities;

namespace ProjectM.HUD;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ConditionalInfoSystem : SystemBase
{
    EntityQuery __query_1864666049_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1864666049_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HUD.ConditionalInfo>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.HUD.ConditionalInfoElement>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
