using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BloodAltarSystem_StopTrackVBloodUnit_System : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_717034166_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.StopTrackVBloodUnitEvent>(),
            },
        });
        
        __query_717034166_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Script_BloodAltar_TrackVBloodUnit_Shared>(),
            },
        });
        
    }
    

}
