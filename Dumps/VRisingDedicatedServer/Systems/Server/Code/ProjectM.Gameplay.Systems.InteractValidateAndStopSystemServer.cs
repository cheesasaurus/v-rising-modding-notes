using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.InteractSystemServer))]
[RequireMatchingQueriesForUpdateAttribute]
public class InteractValidateAndStopSystemServer : SystemBase
{
    EntityQuery _StopInteractQuery;
    EntityQuery _SetInteractedUponQuery;
    EntityQuery __query_195794971_0;
    EntityQuery __query_195794971_1;
    EntityQuery __query_195794971_2;
    EntityQuery __query_195794971_3;
    EntityQuery __query_195794971_4;
    EntityQuery __query_195794971_5;
    EntityQuery __query_195794971_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _StopInteractQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.StopInteractingWithObjectEvent>(),
            },
        });
        
        // Error processing _SetInteractedUponQuery
        // 
        // Il2CppInterop.Runtime.Il2CppException: System.NullReferenceException: Object reference not set to an instance of an object.
        //  --- BEGIN IL2CPP STACK TRACE ---
        //  System.NullReferenceException: Object reference not set to an instance of an object.
        //    at Unity.Entities.EntityQuery.get_IsCacheValid () [0x00000] in <00000000000000000000000000000000>:0 
        //  --- END IL2CPP STACK TRACE ---
        //  
        //     at Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(IntPtr returnedException) in C:\Work\-\VRisingBepInExBuild\Il2CppInterop\Il2CppInterop.Runtime\Il2CppException.cs:line 36
        //     at Unity.Entities.EntityQuery.get_IsCacheValid()
        //     at cheesasaurus.VRisingMods.SystemsDumper.CodeGeneration.EcsSystemCodeGenerator.GenerateEntityQueryExampleInitializationLines(NamedEntityQuery namedQuery)
        
        
        __query_195794971_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InteractedUpon>(),
            },
        });
        
        __query_195794971_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.InteractBuff>(),
            },
        });
        
        __query_195794971_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.StopInteractingWithObjectEvent>(),
            },
        });
        
        __query_195794971_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.InteractBuff>(),
            },
        });
        
        __query_195794971_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_195794971_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_195794971_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
