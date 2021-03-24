using System;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace Oqtane.Migrations.Extensions
{
    public static class ColumnsBuilderExtensions
    {
        public static OperationBuilder<AddColumnOperation> AddAutoIncrementColumn(this ColumnsBuilder table, string name)
        {
            return table.Column<int>(name: name, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("Sqlite:Autoincrement", true)
                        .Annotation("MySql:ValueGeneratedOnAdd", true);
        }

        public static OperationBuilder<AddColumnOperation> AddBooleanColumn(this ColumnsBuilder table, string name, bool nullable = false)
        {
            return table.Column<bool>(name: name, nullable: nullable);
        }

        public static OperationBuilder<AddColumnOperation> AddDateTimeColumn(this ColumnsBuilder table, string name, bool nullable = false)
        {
            return table.Column<DateTime>(name: name, nullable: nullable);
        }

        public static OperationBuilder<AddColumnOperation> AddDateTimeOffsetColumn(this ColumnsBuilder table, string name, bool nullable = false)
        {
            return table.Column<DateTimeOffset>(name: name, nullable: nullable);
        }

        public static OperationBuilder<AddColumnOperation> AddIntegerColumn(this ColumnsBuilder table, string name, bool nullable = false)
        {
            return table.Column<int>(name: name, nullable: nullable);
        }

        public static OperationBuilder<AddColumnOperation> AddMaxStringColumn(this ColumnsBuilder table, string name, bool nullable = false)
        {
            return table.Column<string>(name: name, nullable: nullable);
        }

        public static OperationBuilder<AddColumnOperation> AddStringColumn(this ColumnsBuilder table, string name, int length, bool nullable = false)
        {
            return table.Column<string>(name: name, maxLength: length, nullable: nullable);
        }

    }
}
