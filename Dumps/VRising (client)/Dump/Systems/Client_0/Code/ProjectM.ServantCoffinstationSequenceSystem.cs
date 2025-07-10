using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ServantCoffinstationSequenceSystem : SystemBase
{
    EntityQuery __query_12364802_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_12364802_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServantCoffinstation>(),
                ComponentType.ReadOnly<ProjectM.ServantCoffinEffects>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
