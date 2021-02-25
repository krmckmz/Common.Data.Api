using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Adana')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Adıyaman')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Afyonkarahisar')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Ağrı')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Aksaray')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Amasya')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Ankara')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Antalya')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Ardahan')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Artvin')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Aydın')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Balıkesir')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Bartın')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Batman')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Bayburt')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Bilecik')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Bingöl')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Bitlis')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Bolu')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Burdur')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Bursa')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Çanakkale')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Çankırı')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Çorum')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Denizli')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Diyarbakır')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Düzce')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Edirne')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Elâzığ')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Erzincan')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Erzurum')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Eskişehir')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Gaziantep')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Gümüşhane')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Hakkâri')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Hatay')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Iğdır')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Isparta')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('İstanbul')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('İzmir')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Kahramanmaraş')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Karabük')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Karaman')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Kars')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Kastamonu')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Kayseri')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Kırıkkale')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Kırklareli')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Kırşehir')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Kilis')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Kocaeli')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Konya')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Kütahya')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Malatya')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Manisa')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Mardin')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Mersin')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Muğla')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Muş')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Nevşehir')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Niğde')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Ordu')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Osmaniye')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Rize')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Sakarya')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Samsun')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Siirt')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Sinop')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Sivas')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Şanlıurfa')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Şırnak')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Tekirdağ')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Tokat')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Trabzon')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Tunceli')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Uşak')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Van')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Yalova')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Yozgat')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Zonguldak')");
            migrationBuilder.Sql("INSERT INTO Cities (Name) Values ('Düzce')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
              .Sql("DELETE FROM Cities");
        }
    }
}
