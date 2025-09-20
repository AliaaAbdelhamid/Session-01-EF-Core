using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddGetBooksByCategoryProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" CREATE PROCEDURE GetBooksByCategory @CatId INT
                                        AS
                                        BEGIN
                                            SELECT * FROM Book WHERE Cat_id = @CatId
                                        END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop PROCEDURE GetBooksByCategory ");
           
        }
    }
}
