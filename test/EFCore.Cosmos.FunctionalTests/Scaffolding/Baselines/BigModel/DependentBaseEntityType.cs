// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Cosmos.Storage.Internal;
using Microsoft.EntityFrameworkCore.Cosmos.ValueGeneration.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Newtonsoft.Json.Linq;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class DependentBaseEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentBase<byte?>",
                typeof(CompiledModelTestBase.DependentBase<byte?>),
                baseEntityType,
                discriminatorProperty: "EnumDiscriminator",
                discriminatorValue: CompiledModelTestBase.Enum1.One,
                derivedTypesCount: 1,
                propertyCount: 6,
                navigationCount: 1,
                foreignKeyCount: 2,
                keyCount: 1);

            var principalId = runtimeEntityType.AddProperty(
                "PrincipalId",
                typeof(long),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            principalId.SetAccessors(
                long (InternalEntityEntry entry) => (entry.FlaggedAsStoreGenerated(0) ? entry.ReadStoreGeneratedValue<long>(0) : (entry.FlaggedAsTemporary(0) && entry.ReadShadowValue<long>(0) == 0L ? entry.ReadTemporaryValue<long>(0) : entry.ReadShadowValue<long>(0))),
                long (InternalEntityEntry entry) => entry.ReadShadowValue<long>(0),
                long (InternalEntityEntry entry) => entry.ReadOriginalValue<long>(principalId, 0),
                long (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<long>(principalId, 0),
                object (ValueBuffer valueBuffer) => valueBuffer[0]);
            principalId.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: 0,
                relationshipIndex: 0,
                storeGenerationIndex: 0);
            principalId.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<long>(
                    bool (long v1, long v2) => v1 == v2,
                    int (long v) => ((object)v).GetHashCode(),
                    long (long v) => v),
                keyComparer: new ValueComparer<long>(
                    bool (long v1, long v2) => v1 == v2,
                    int (long v) => ((object)v).GetHashCode(),
                    long (long v) => v),
                providerValueComparer: new ValueComparer<long>(
                    bool (long v1, long v2) => v1 == v2,
                    int (long v) => ((object)v).GetHashCode(),
                    long (long v) => v),
                clrType: typeof(long),
                jsonValueReaderWriter: JsonInt64ReaderWriter.Instance);
            principalId.SetCurrentValueComparer(new EntryCurrentValueComparer<long>(principalId));

            var principalAlternateId = runtimeEntityType.AddProperty(
                "PrincipalAlternateId",
                typeof(Guid),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            principalAlternateId.SetAccessors(
                Guid (InternalEntityEntry entry) => (entry.FlaggedAsStoreGenerated(1) ? entry.ReadStoreGeneratedValue<Guid>(1) : (entry.FlaggedAsTemporary(1) && entry.ReadShadowValue<Guid>(1) == new Guid("00000000-0000-0000-0000-000000000000") ? entry.ReadTemporaryValue<Guid>(1) : entry.ReadShadowValue<Guid>(1))),
                Guid (InternalEntityEntry entry) => entry.ReadShadowValue<Guid>(1),
                Guid (InternalEntityEntry entry) => entry.ReadOriginalValue<Guid>(principalAlternateId, 1),
                Guid (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<Guid>(principalAlternateId, 1),
                object (ValueBuffer valueBuffer) => valueBuffer[1]);
            principalAlternateId.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: 1,
                relationshipIndex: 1,
                storeGenerationIndex: 1);
            principalAlternateId.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<Guid>(
                    bool (Guid v1, Guid v2) => v1 == v2,
                    int (Guid v) => ((object)v).GetHashCode(),
                    Guid (Guid v) => v),
                keyComparer: new ValueComparer<Guid>(
                    bool (Guid v1, Guid v2) => v1 == v2,
                    int (Guid v) => ((object)v).GetHashCode(),
                    Guid (Guid v) => v),
                providerValueComparer: new ValueComparer<string>(
                    bool (string v1, string v2) => v1 == v2,
                    int (string v) => ((object)v).GetHashCode(),
                    string (string v) => v),
                converter: new ValueConverter<Guid, string>(
                    string (Guid v) => v.ToString("D"),
                    Guid (string v) => new Guid(v)),
                jsonValueReaderWriter: new JsonConvertedValueReaderWriter<Guid, string>(
                    JsonStringReaderWriter.Instance,
                    new ValueConverter<Guid, string>(
                        string (Guid v) => v.ToString("D"),
                        Guid (string v) => new Guid(v))));
            principalAlternateId.SetCurrentValueComparer(new EntryCurrentValueComparer<Guid>(principalAlternateId));
            principalAlternateId.SetSentinelFromProviderValue("00000000-0000-0000-0000-000000000000");

            var enumDiscriminator = runtimeEntityType.AddProperty(
                "EnumDiscriminator",
                typeof(CompiledModelTestBase.Enum1),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                valueGeneratorFactory: new DiscriminatorValueGeneratorFactory().Create);
            enumDiscriminator.SetAccessors(
                CompiledModelTestBase.Enum1 (InternalEntityEntry entry) => entry.ReadShadowValue<CompiledModelTestBase.Enum1>(2),
                CompiledModelTestBase.Enum1 (InternalEntityEntry entry) => entry.ReadShadowValue<CompiledModelTestBase.Enum1>(2),
                CompiledModelTestBase.Enum1 (InternalEntityEntry entry) => entry.ReadOriginalValue<CompiledModelTestBase.Enum1>(enumDiscriminator, 2),
                CompiledModelTestBase.Enum1 (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelTestBase.Enum1>(enumDiscriminator),
                object (ValueBuffer valueBuffer) => valueBuffer[2]);
            enumDiscriminator.SetPropertyIndexes(
                index: 2,
                originalValueIndex: 2,
                shadowIndex: 2,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            enumDiscriminator.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<CompiledModelTestBase.Enum1>(
                    bool (CompiledModelTestBase.Enum1 v1, CompiledModelTestBase.Enum1 v2) => object.Equals(((object)(v1)), ((object)(v2))),
                    int (CompiledModelTestBase.Enum1 v) => ((object)v).GetHashCode(),
                    CompiledModelTestBase.Enum1 (CompiledModelTestBase.Enum1 v) => v),
                keyComparer: new ValueComparer<CompiledModelTestBase.Enum1>(
                    bool (CompiledModelTestBase.Enum1 v1, CompiledModelTestBase.Enum1 v2) => object.Equals(((object)(v1)), ((object)(v2))),
                    int (CompiledModelTestBase.Enum1 v) => ((object)v).GetHashCode(),
                    CompiledModelTestBase.Enum1 (CompiledModelTestBase.Enum1 v) => v),
                providerValueComparer: new ValueComparer<int>(
                    bool (int v1, int v2) => v1 == v2,
                    int (int v) => v,
                    int (int v) => v),
                converter: new ValueConverter<CompiledModelTestBase.Enum1, int>(
                    int (CompiledModelTestBase.Enum1 value) => ((int)(value)),
                    CompiledModelTestBase.Enum1 (int value) => ((CompiledModelTestBase.Enum1)(value))),
                jsonValueReaderWriter: new JsonConvertedValueReaderWriter<CompiledModelTestBase.Enum1, int>(
                    JsonInt32ReaderWriter.Instance,
                    new ValueConverter<CompiledModelTestBase.Enum1, int>(
                        int (CompiledModelTestBase.Enum1 value) => ((int)(value)),
                        CompiledModelTestBase.Enum1 (int value) => ((CompiledModelTestBase.Enum1)(value)))));
            enumDiscriminator.SetSentinelFromProviderValue(0);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(byte?),
                propertyInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            id.SetGetter(
                byte? (CompiledModelTestBase.DependentBase<byte?> entity) => DependentBaseUnsafeAccessors<byte?>.Id(entity),
                bool (CompiledModelTestBase.DependentBase<byte?> entity) => !(DependentBaseUnsafeAccessors<byte?>.Id(entity).HasValue),
                byte? (CompiledModelTestBase.DependentBase<byte?> instance) => DependentBaseUnsafeAccessors<byte?>.Id(instance),
                bool (CompiledModelTestBase.DependentBase<byte?> instance) => !(DependentBaseUnsafeAccessors<byte?>.Id(instance).HasValue));
            id.SetSetter(
                (CompiledModelTestBase.DependentBase<byte?> entity, byte? value) => DependentBaseUnsafeAccessors<byte?>.Id(entity) = value);
            id.SetMaterializationSetter(
                (CompiledModelTestBase.DependentBase<byte?> entity, byte? value) => DependentBaseUnsafeAccessors<byte?>.Id(entity) = value);
            id.SetAccessors(
                byte? (InternalEntityEntry entry) => DependentBaseUnsafeAccessors<byte?>.Id(((CompiledModelTestBase.DependentBase<byte?>)(entry.Entity))),
                byte? (InternalEntityEntry entry) => DependentBaseUnsafeAccessors<byte?>.Id(((CompiledModelTestBase.DependentBase<byte?>)(entry.Entity))),
                byte? (InternalEntityEntry entry) => entry.ReadOriginalValue<byte?>(id, 3),
                byte? (InternalEntityEntry entry) => entry.GetCurrentValue<byte?>(id),
                object (ValueBuffer valueBuffer) => valueBuffer[3]);
            id.SetPropertyIndexes(
                index: 3,
                originalValueIndex: 3,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            id.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<byte>(
                    bool (byte v1, byte v2) => v1 == v2,
                    int (byte v) => ((int)(v)),
                    byte (byte v) => v),
                keyComparer: new ValueComparer<byte>(
                    bool (byte v1, byte v2) => v1 == v2,
                    int (byte v) => ((int)(v)),
                    byte (byte v) => v),
                providerValueComparer: new ValueComparer<byte>(
                    bool (byte v1, byte v2) => v1 == v2,
                    int (byte v) => ((int)(v)),
                    byte (byte v) => v),
                clrType: typeof(byte),
                jsonValueReaderWriter: JsonByteReaderWriter.Instance);
            id.SetComparer(new NullableValueComparer<byte>(id.TypeMapping.Comparer));
            id.SetKeyComparer(new NullableValueComparer<byte>(id.TypeMapping.KeyComparer));

            var __id = runtimeEntityType.AddProperty(
                "__id",
                typeof(string),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                valueGeneratorFactory: new IdValueGeneratorFactory().Create);
            __id.SetAccessors(
                string (InternalEntityEntry entry) => entry.ReadShadowValue<string>(3),
                string (InternalEntityEntry entry) => entry.ReadShadowValue<string>(3),
                string (InternalEntityEntry entry) => entry.ReadOriginalValue<string>(__id, 4),
                string (InternalEntityEntry entry) => entry.GetCurrentValue<string>(__id),
                object (ValueBuffer valueBuffer) => valueBuffer[4]);
            __id.SetPropertyIndexes(
                index: 4,
                originalValueIndex: 4,
                shadowIndex: 3,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            __id.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<string>(
                    bool (string v1, string v2) => v1 == v2,
                    int (string v) => ((object)v).GetHashCode(),
                    string (string v) => v),
                keyComparer: new ValueComparer<string>(
                    bool (string v1, string v2) => v1 == v2,
                    int (string v) => ((object)v).GetHashCode(),
                    string (string v) => v),
                providerValueComparer: new ValueComparer<string>(
                    bool (string v1, string v2) => v1 == v2,
                    int (string v) => ((object)v).GetHashCode(),
                    string (string v) => v),
                clrType: typeof(string),
                jsonValueReaderWriter: JsonStringReaderWriter.Instance);
            __id.AddAnnotation("Cosmos:PropertyName", "id");

            var __jObject = runtimeEntityType.AddProperty(
                "__jObject",
                typeof(JObject),
                nullable: true);
            __jObject.SetAccessors(
                JObject (InternalEntityEntry entry) => entry.ReadShadowValue<JObject>(4),
                JObject (InternalEntityEntry entry) => entry.ReadShadowValue<JObject>(4),
                JObject (InternalEntityEntry entry) => entry.ReadOriginalValue<JObject>(__jObject, 5),
                JObject (InternalEntityEntry entry) => entry.GetCurrentValue<JObject>(__jObject),
                object (ValueBuffer valueBuffer) => valueBuffer[5]);
            __jObject.SetPropertyIndexes(
                index: 5,
                originalValueIndex: 5,
                shadowIndex: 4,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            __jObject.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<JObject>(
                    bool (JObject v1, JObject v2) => object.Equals(v1, v2),
                    int (JObject v) => ((object)v).GetHashCode(),
                    JObject (JObject v) => v),
                keyComparer: new ValueComparer<JObject>(
                    bool (JObject v1, JObject v2) => object.Equals(v1, v2),
                    int (JObject v) => ((object)v).GetHashCode(),
                    JObject (JObject v) => v),
                providerValueComparer: new ValueComparer<JObject>(
                    bool (JObject v1, JObject v2) => object.Equals(v1, v2),
                    int (JObject v) => ((object)v).GetHashCode(),
                    JObject (JObject v) => v),
                clrType: typeof(JObject));
            __jObject.AddAnnotation("Cosmos:PropertyName", "");

            var key = runtimeEntityType.AddKey(
                new[] { principalId, principalAlternateId });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                unique: true,
                required: true);

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalId"), declaringEntityType.FindProperty("PrincipalAlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.ClientNoAction,
                unique: true,
                required: true);

            var principal = declaringEntityType.AddNavigation("Principal",
                runtimeForeignKey,
                onDependent: true,
                typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>),
                propertyInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetProperty("Principal", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetField("<Principal>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            principal.SetGetter(
                CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> (CompiledModelTestBase.DependentBase<byte?> entity) => DependentBaseUnsafeAccessors<byte?>.Principal(entity),
                bool (CompiledModelTestBase.DependentBase<byte?> entity) => DependentBaseUnsafeAccessors<byte?>.Principal(entity) == null,
                CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> (CompiledModelTestBase.DependentBase<byte?> instance) => DependentBaseUnsafeAccessors<byte?>.Principal(instance),
                bool (CompiledModelTestBase.DependentBase<byte?> instance) => DependentBaseUnsafeAccessors<byte?>.Principal(instance) == null);
            principal.SetSetter(
                (CompiledModelTestBase.DependentBase<byte?> entity, CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> value) => DependentBaseUnsafeAccessors<byte?>.Principal(entity) = value);
            principal.SetMaterializationSetter(
                (CompiledModelTestBase.DependentBase<byte?> entity, CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> value) => DependentBaseUnsafeAccessors<byte?>.Principal(entity) = value);
            principal.SetAccessors(
                CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> (InternalEntityEntry entry) => DependentBaseUnsafeAccessors<byte?>.Principal(((CompiledModelTestBase.DependentBase<byte?>)(entry.Entity))),
                CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> (InternalEntityEntry entry) => DependentBaseUnsafeAccessors<byte?>.Principal(((CompiledModelTestBase.DependentBase<byte?>)(entry.Entity))),
                null,
                CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>>(principal),
                null);
            principal.SetPropertyIndexes(
                index: 0,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 2,
                storeGenerationIndex: -1);
            var dependent = principalEntityType.AddNavigation("Dependent",
                runtimeForeignKey,
                onDependent: false,
                typeof(CompiledModelTestBase.DependentBase<byte?>),
                propertyInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetProperty("Dependent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetField("<Dependent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                eagerLoaded: true,
                lazyLoadingEnabled: false);

            dependent.SetGetter(
                CompiledModelTestBase.DependentBase<byte?> (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Dependent(entity),
                bool (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Dependent(entity) == null,
                CompiledModelTestBase.DependentBase<byte?> (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> instance) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Dependent(instance),
                bool (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> instance) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Dependent(instance) == null);
            dependent.SetSetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity, CompiledModelTestBase.DependentBase<byte?> value) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Dependent(entity) = value);
            dependent.SetMaterializationSetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> entity, CompiledModelTestBase.DependentBase<byte?> value) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Dependent(entity) = value);
            dependent.SetAccessors(
                CompiledModelTestBase.DependentBase<byte?> (InternalEntityEntry entry) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Dependent(((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>)(entry.Entity))),
                CompiledModelTestBase.DependentBase<byte?> (InternalEntityEntry entry) => PrincipalDerivedUnsafeAccessors<CompiledModelTestBase.DependentBase<byte?>>.Dependent(((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>)(entry.Entity))),
                null,
                CompiledModelTestBase.DependentBase<byte?> (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelTestBase.DependentBase<byte?>>(dependent),
                null);
            dependent.SetPropertyIndexes(
                index: 2,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 4,
                storeGenerationIndex: -1);
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var principalId = runtimeEntityType.FindProperty("PrincipalId");
            var principalAlternateId = runtimeEntityType.FindProperty("PrincipalAlternateId");
            var enumDiscriminator = runtimeEntityType.FindProperty("EnumDiscriminator");
            var id = runtimeEntityType.FindProperty("Id");
            var __id = runtimeEntityType.FindProperty("__id");
            var __jObject = runtimeEntityType.FindProperty("__jObject");
            var key = runtimeEntityType.FindKey(new[] { principalId, principalAlternateId });
            key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.CreateCompositeFactory(key));
            key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<IReadOnlyList<object>>(key));
            var principal = runtimeEntityType.FindNavigation("Principal");
            runtimeEntityType.SetOriginalValuesFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((CompiledModelTestBase.DependentBase<byte?>)(source.Entity));
                    return ((ISnapshot)(new Snapshot<long, Guid, CompiledModelTestBase.Enum1, byte?, string, JObject>(((ValueComparer<long>)(((IProperty)principalId).GetValueComparer())).Snapshot(source.GetCurrentValue<long>(principalId)), ((ValueComparer<Guid>)(((IProperty)principalAlternateId).GetValueComparer())).Snapshot(source.GetCurrentValue<Guid>(principalAlternateId)), ((ValueComparer<CompiledModelTestBase.Enum1>)(((IProperty)enumDiscriminator).GetValueComparer())).Snapshot(source.GetCurrentValue<CompiledModelTestBase.Enum1>(enumDiscriminator)), (source.GetCurrentValue<byte?>(id) == null ? null : ((ValueComparer<byte?>)(((IProperty)id).GetValueComparer())).Snapshot(source.GetCurrentValue<byte?>(id))), (source.GetCurrentValue<string>(__id) == null ? null : ((ValueComparer<string>)(((IProperty)__id).GetValueComparer())).Snapshot(source.GetCurrentValue<string>(__id))), (source.GetCurrentValue<JObject>(__jObject) == null ? null : ((ValueComparer<JObject>)(((IProperty)__jObject).GetValueComparer())).Snapshot(source.GetCurrentValue<JObject>(__jObject))))));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<long, Guid>(((ValueComparer<long>)(((IProperty)principalId).GetValueComparer())).Snapshot(default(long)), ((ValueComparer<Guid>)(((IProperty)principalAlternateId).GetValueComparer())).Snapshot(default(Guid))))));
            runtimeEntityType.SetTemporaryValuesFactory(
                ISnapshot (InternalEntityEntry source) => ((ISnapshot)(new Snapshot<long, Guid>(default(long), default(Guid)))));
            runtimeEntityType.SetShadowValuesFactory(
                ISnapshot (IDictionary<string, object> source) => ((ISnapshot)(new Snapshot<long, Guid, CompiledModelTestBase.Enum1, string, JObject>((source.ContainsKey("PrincipalId") ? ((long)(source["PrincipalId"])) : 0L), (source.ContainsKey("PrincipalAlternateId") ? ((Guid)(source["PrincipalAlternateId"])) : new Guid("00000000-0000-0000-0000-000000000000")), (source.ContainsKey("EnumDiscriminator") ? ((CompiledModelTestBase.Enum1)(source["EnumDiscriminator"])) : CompiledModelTestBase.Enum1.Default), (source.ContainsKey("__id") ? ((string)(source["__id"])) : null), (source.ContainsKey("__jObject") ? ((JObject)(source["__jObject"])) : null)))));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                ISnapshot () => ((ISnapshot)(new Snapshot<long, Guid, CompiledModelTestBase.Enum1, string, JObject>(default(long), default(Guid), default(CompiledModelTestBase.Enum1), default(string), default(JObject)))));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                ISnapshot (InternalEntityEntry source) =>
                {
                    var entity = ((CompiledModelTestBase.DependentBase<byte?>)(source.Entity));
                    return ((ISnapshot)(new Snapshot<long, Guid, object>(((ValueComparer<long>)(((IProperty)principalId).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<long>(principalId)), ((ValueComparer<Guid>)(((IProperty)principalAlternateId).GetKeyValueComparer())).Snapshot(source.GetCurrentValue<Guid>(principalAlternateId)), DependentBaseUnsafeAccessors<byte?>.Principal(entity))));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 6,
                navigationCount: 1,
                complexPropertyCount: 0,
                originalValueCount: 6,
                shadowCount: 5,
                relationshipCount: 3,
                storeGeneratedCount: 2);
            runtimeEntityType.AddAnnotation("Cosmos:ContainerName", "Dependents");
            runtimeEntityType.AddAnnotation("DiscriminatorMappingComplete", false);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
