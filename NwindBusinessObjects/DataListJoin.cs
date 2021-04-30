using System;
using System.Reflection;
using System.Data.SqlClient;

namespace NwindBusinessObjects {
    using Builder;
    using Schema;

    public abstract class DataListJoin<T> : DataList<T> where T : ItemJoin, new() {
        protected readonly string pkJoinColumn;
        protected readonly PropertyInfo pkJoinColumnProperty;

        public DataListJoin() : base() {
            var tableAttribute = typeof(T).GetCustomAttribute<TableAttribute>();

            this.pkJoinColumn = tableAttribute.PkJoinColumn;
            this.pkJoinColumnProperty = typeof(T).GetProperty(this.pkJoinColumn);
        }

        protected override string whereItemClause(SqlCommand command, T item) {
            command.Parameters.AddWithValue(this.pkJoinColumn, this.pkJoinColumnProperty.GetValue(item));

            return $"{base.whereItemClause(command, item)} AND [{this.pkJoinColumn}] = @{this.pkJoinColumn}";
        }

        public override void Update(T item) {
            using (var command = base.connection.CreateCommand())
            using (var set = new SetClause(base.schema)) {
                set.Add(item, itemProperties, new[] { base.pkColumn, this.pkJoinColumn });

                if (set.HasAny) {
                    base.Update(item, command, set);
                }
            }
        }
    }
}
