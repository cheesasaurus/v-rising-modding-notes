using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ActiveResearchstationSequenceSystem : SystemBase
{
    EntityQuery __query_726818285_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_726818285_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ResearchStation>(),
                ComponentType.ReadOnly<ProjectM.EditableTileModel>(),
                ComponentType.ReadOnly<ProjectM.HaveUnlocksInStation>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
