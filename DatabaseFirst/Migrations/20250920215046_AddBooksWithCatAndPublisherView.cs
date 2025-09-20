using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddBooksWithCatAndPublisherView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create view BooksWithCatAndPublisher
                                       as
                                          select B.Title [BookTitle] , P.Name [PublisherName] , C.Cat_name [CategoryName]
                                          from Book B , Publisher P , Category C
                                          where P.Id = B.Publisher_id and C.Id = B.Cat_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop View BooksWithCatAndPublisher");

        }
    }
}
