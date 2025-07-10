using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ScheduleGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RandomizedSpawnChainUpdateSystem : SystemBase
{
    EntityQuery _MainQuery;
    EntityQuery _ConvertOnDemandQuery;
    EntityQuery __query_192736846_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RandomizedSpawnChain>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.StaticTransformIndex>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        // Error processing _ConvertOnDemandQuery
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
        
        
        __query_192736846_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RandomizedSpawnChain>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.StaticTransformIndex>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
    }
    

}
