using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.HeightCorrectionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ShowHeightSystem_Server : SystemBase
{
    EntityQuery __query_763784856_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_763784856_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Height>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
