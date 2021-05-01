# EfEffortPOC

In-memory EF DB
https://entityframework-effort.net/overview


**The store type 'jsonb' could not be found in the Effort provider manifest**

```
   at System.Data.Entity.Utilities.DbProviderManifestExtensions.GetStoreTypeFromName(DbProviderManifest providerManifest, String name)
   at System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration.ConfigureColumn(EdmProperty column, EntityType table, DbProviderManifest providerManifest)
   at System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration.<>c__DisplayClass4.<Configure>b__3(Tuple`2 pm)
   at System.Data.Entity.Utilities.IEnumerableExtensions.Each[T](IEnumerable`1 ts, Action`1 action)
   at System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration.ConfigurePropertyMappings(IList`1 propertyMappings, DbProviderManifest providerManifest, Boolean allowOverride)
   at System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration.ConfigurePropertyMappings(DbDatabaseMapping databaseMapping, EntityType entityType, DbProviderManifest providerManifest, Boolean allowOverride)
   at System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration.Configure(EntityType entityType, DbDatabaseMapping databaseMapping, DbProviderManifest providerManifest)
   at System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.ConfigureEntityTypes(DbDatabaseMapping databaseMapping, ICollection`1 entitySets, DbProviderManifest providerManifest)
   at System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.Configure(DbDatabaseMapping databaseMapping, DbProviderManifest providerManifest)
   at System.Data.Entity.DbModelBuilder.Build(DbProviderManifest providerManifest, DbProviderInfo providerInfo)
   at System.Data.Entity.DbModelBuilder.Build(DbConnection providerConnection)
   at System.Data.Entity.Internal.LazyInternalContext.CreateModel(LazyInternalContext internalContext)
   at System.Data.Entity.Internal.RetryLazy`2.GetValue(TInput input)
   at System.Data.Entity.Internal.LazyInternalContext.InitializeContext()
   at System.Data.Entity.Internal.InternalContext.Initialize()
   at System.Data.Entity.Internal.InternalContext.ForceOSpaceLoadingForKnownEntityTypes()
   at System.Data.Entity.DbContext.System.Data.Entity.Infrastructure.IObjectContextAdapter.get_ObjectContext()
   at My.Infrastructure.Persistence.MyDbContext.get_ObjectContext() in C:\repo\MyMain\Infrastructure\My.Infrastructure.Persistence\MyDbContext.cs:line 512
```
