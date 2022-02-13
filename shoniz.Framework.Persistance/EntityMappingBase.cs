using shoniz.Framework.Domain;
using System.Data;
using System.Data.Entity.ModelConfiguration;

namespace shoniz.Framework.Persistance
{
    public abstract class EntityMappingBase<TEntity> : 
        EntityTypeConfiguration<TEntity>,
        IEntityMapping
        where TEntity : EntityBase
    {
        protected EntityMappingBase()
        {
            Property(c => c.Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString())
                .IsRequired();
            HasKey(c => c.Id);

            var schemaName = typeof(TEntity).Namespace.Split(new[] { '.' })[2];
            ToTable(typeof(TEntity).Name, schemaName);
        }
    }
}
