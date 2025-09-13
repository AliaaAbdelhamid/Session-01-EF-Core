using Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ModelConfigurations
{
	internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
	{
		public void Configure(EntityTypeBuilder<Department> D)
		{
			D.ToTable("Departments", "Sales");

			D.HasKey(D => D.DeptId);
			
			D.Property(D => D.DeptId).UseIdentityColumn(10, 10);
			
			D.Property(D => D.DeptName)
			.HasColumnName("DepartmentName")
			.HasColumnType("varchar")
			.HasMaxLength(50)
			.IsRequired(false)
			.HasDefaultValue("HR");
			
			D.Property(D => D.DateOfCreation)
			 .HasAnnotation("DataType", "DateTime")
			 .HasDefaultValueSql("GetDate()");
			
			D.Ignore(D => D.Serial);
		}
	}
}
