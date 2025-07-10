using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AbilityDisableHeightCorrectionSystem_OnDestroy : SystemBase
{
    EntityQuery __query_1175309219_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1175309219_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.DisableHeightCorrectionDuringCastModificationData>(),
                ComponentType.ReadOnly<ProjectM.DisableHeightCorrectionDuringCast>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
