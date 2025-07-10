using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BloodMixerSystem_Update : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1093555727_0;
    EntityQuery __query_1093555727_1;
    EntityQuery __query_1093555727_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.BloodMixer_Shared>(),
                ComponentType.ReadOnly<ProjectM.CastleWorkstation>(),
                ComponentType.ReadOnly<ProjectM.StationBonusBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1093555727_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.BloodMixer_Shared>(),
                ComponentType.ReadOnly<ProjectM.CastleWorkstation>(),
                ComponentType.ReadOnly<ProjectM.StationBonusBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1093555727_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1093555727_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDatas>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
