using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TextureMipStreamingSystem : SystemBase
{
    EntityQuery _NewSubSceneTextures;
    EntityQuery _UnloadedSubSceneTextures;
    EntityQuery __query_1820907041_0;
    EntityQuery __query_1820907041_1;
    EntityQuery __query_1820907041_2;
    EntityQuery __query_1820907041_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _NewSubSceneTextures = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.TextureStreamingList>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.SubSceneStreamingTextureIndices>(),
            },
        });
        
        _UnloadedSubSceneTextures = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.SubSceneStreamingTextureIndices>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.TextureStreamingList>(),
            },
        });
        
        __query_1820907041_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.TextureStreamingList>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.SubSceneStreamingTextureIndices>(),
            },
        });
        
        __query_1820907041_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.SubSceneStreamingTextureIndices>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.TextureStreamingList>(),
            },
        });
        
        __query_1820907041_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.SubSceneStreamingTextureIndices>(),
            },
        });
        
        __query_1820907041_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.PrefabStreamingTextureIndices>(),
            },
        });
        
    }
    

}
