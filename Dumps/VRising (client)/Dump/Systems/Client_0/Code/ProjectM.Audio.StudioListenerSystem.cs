using Unity.Entities;

namespace ProjectM.Audio;


[UpdateInGroup(typeof(ProjectM.AudioGroup))]
[UpdateBefore(typeof(ProjectM.Audio.StudioManagerSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class StudioListenerSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_342836104_0;
    EntityQuery __query_342836104_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioListener>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_342836104_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioListener>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_342836104_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.FakeTurnOffStudioListener>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
