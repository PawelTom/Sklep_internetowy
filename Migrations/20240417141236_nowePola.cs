﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sklep_internetowy.Migrations
{
    public partial class nowePola : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Categories",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Films",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "Films",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Poster",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Films",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Filmy oparte na faktach", "Dokumentalne" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Dreszczowce", "Thriller" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Filmy z akcją", "Sensacyjne" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Filmy z elementami magi", "Fantasy" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1,
                columns: new[] { "AddDate", "Desc", "Director", "Poster", "Price", "Title" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.", "Marcus Nispel", "teksanska-masakra-pila-mechaniczna.jpg", 10.0, "Teksańska Masakra Piłą Mechaniczną" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2,
                columns: new[] { "AddDate", "CategoryId", "Desc", "Director", "Poster", "Price", "Title" },
                values: new object[] { new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mężczyzna dostaje obsesji na punkcie książki, która według niego opisuje i przewiduje jego życie i przyszłość.", "Joel Schumacher", "numer-23.jpg", 14.0, "Numer 23" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3,
                columns: new[] { "AddDate", "CategoryId", "Desc", "Director", "Poster", "Price", "Title" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.", "David Koepp", "sekretne-okno.jpg", 12.0, "Sekretne Okno" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 21,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2010, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 22,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2012, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 23,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2010, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "AddDate", "CategoryId", "Desc", "Director", "Poster", "Price", "Title" },
                values: new object[,]
                {
                    { 4, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.", "Peter Jackson", "wladca-pierscieni-druzyna-pierscienia.jpg", 20.0, "Władca Pierścieni: Drużyna Pierścienia" },
                    { 5, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.", "Robert Schwentke", "red.jpg", 11.0, "Red" },
                    { 6, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.", "Tomasz Sekielski", "tylko-nie-mow-nikomu.jpg", 0.0, "Tylko nie mów nikomu" },
                    { 7, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.", "Neil Burger", "iluzjonista.jpg", 13.0, "Iluzjonista" },
                    { 8, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.", "Vincenzo Natali", "cube.jpg", 15.0, "Cube" },
                    { 9, new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.", "Clive Barker", "hellriser.jpg", 16.0, "Hellraiser: Wysłannik Piekieł" },
                    { 10, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.", "Jonathan Demme", "milczenie-owiec.jpg", 17.0, "Milczenie Owiec" },
                    { 11, null, 1, "Rodzina zamieszkuje opuszczony hotel, gdzie ojciec zaczyna stopniowo tracić zmysły.", "Stanley Kubrick", null, null, "The Shining" },
                    { 12, null, 1, "Kobieta trafia do odległego motelu, gdzie właściciel ma mroczne sekrety.", "Alfred Hitchcock", null, null, "Psycho" },
                    { 13, null, 2, "Seria dokumentalna przedstawiająca niesamowite zjawiska przyrody na całym świecie.", "David Attenborough", null, null, "Planet Earth II" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Films");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "Desc");

            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Films",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "Desc", "Name" },
                values: new object[] { "Filmy fantastyczne", "Fantasy" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "Desc", "Name" },
                values: new object[] { "Filmy sensacyjne", "Sensacyjne" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "Desc", "Name" },
                values: new object[] { "Filmy dokumentalne", "Dokumentalne" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "Desc", "Name" },
                values: new object[] { "Filmy SCI-FI", "SCI-FI" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1,
                columns: new[] { "Desc", "Director", "Title" },
                values: new object[] { "Rodzina zamieszkuje opuszczony hotel, gdzie ojciec zaczyna stopniowo tracić zmysły.", "Stanley Kubrick", "The Shining" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2,
                columns: new[] { "CategoryId", "Desc", "Director", "Title" },
                values: new object[] { 1, "Kobieta trafia do odległego motelu, gdzie właściciel ma mroczne sekrety.", "Alfred Hitchcock", "Psycho" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Desc", "Director", "Title" },
                values: new object[] { 2, "Seria dokumentalna przedstawiająca niesamowite zjawiska przyrody na całym świecie.", "David Attenborough", "Planet Earth II" });
        }
    }
}
