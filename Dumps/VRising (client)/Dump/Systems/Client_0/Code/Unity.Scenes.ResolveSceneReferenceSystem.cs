using Unity.Entities;

namespace Unity.Scenes;


[UpdateInGroup(typeof(Unity.Scenes.SceneSystemGroup))]
[UpdateAfter(typeof(Unity.Scenes.SceneSystem))]
public class ResolveSceneReferenceSystem : SystemBase
{
    EntityQuery __query_102603020_0;
    EntityQuery __query_102603020_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_102603020_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.RequestSceneLoaded>(),
                ComponentType.ReadWrite<Unity.Entities.SceneReference>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Scenes.RequestSceneHeader>(),
                ComponentType.ReadOnly<Unity.Scenes.ResolvedSectionEntity>(),
                ComponentType.ReadOnly<Unity.Scenes.DisableSceneResolveAndLoad>(),
            },
        });
        
        __query_102603020_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.RequestSceneLoaded>(),
                ComponentType.ReadWrite<Unity.Scenes.ResolvedSceneHash>(),
                ComponentType.ReadWrite<Unity.Entities.SceneReference>(),
                ComponentType.ReadWrite<Unity.Scenes.RequestSceneHeader>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Scenes.ResolvedSectionEntity>(),
                ComponentType.ReadOnly<Unity.Scenes.DisableSceneResolveAndLoad>(),
            },
        });
        
    }
    

}
