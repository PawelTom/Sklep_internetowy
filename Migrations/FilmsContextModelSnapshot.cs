﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sklep_internetowy.DAL;

#nullable disable

namespace Sklep_internetowy.Migrations
{
    [DbContext(typeof(FilmsContext))]
    partial class FilmsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Sklep_internetowy.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Straszne filmy",
                            Name = "Horror"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Filmy oparte na faktach",
                            Name = "Dokumentalne"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Dreszczowce",
                            Name = "Thriller"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Filmy z akcją",
                            Name = "Sensacyjne"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "Filmy z elementami magi",
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("Sklep_internetowy.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"), 1L, 1);

                    b.Property<DateTime?>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            AddDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 1,
                            Desc = "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.",
                            Director = "Marcus Nispel",
                            Poster = "teksanska-masakra-pila-mechaniczna.jpg",
                            Price = 10.0,
                            Title = "Teksańska Masakra Piłą Mechaniczną"
                        },
                        new
                        {
                            FilmId = 2,
                            AddDate = new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 3,
                            Desc = "Mężczyzna dostaje obsesji na punkcie książki, która według niego opisuje i przewiduje jego życie i przyszłość.",
                            Director = "Joel Schumacher",
                            Poster = "numer-23.jpg",
                            Price = 14.0,
                            Title = "Numer 23"
                        },
                        new
                        {
                            FilmId = 3,
                            AddDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 3,
                            Desc = "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.",
                            Director = "David Koepp",
                            Poster = "sekretne-okno.jpg",
                            Price = 12.0,
                            Title = "Sekretne Okno"
                        },
                        new
                        {
                            FilmId = 4,
                            AddDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 5,
                            Desc = "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.",
                            Director = "Peter Jackson",
                            Poster = "wladca-pierscieni-druzyna-pierscienia.jpg",
                            Price = 20.0,
                            Title = "Władca Pierścieni: Drużyna Pierścienia"
                        },
                        new
                        {
                            FilmId = 5,
                            AddDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 4,
                            Desc = "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.",
                            Director = "Robert Schwentke",
                            Poster = "red.jpg",
                            Price = 11.0,
                            Title = "Red"
                        },
                        new
                        {
                            FilmId = 6,
                            AddDate = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 2,
                            Desc = "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.",
                            Director = "Tomasz Sekielski",
                            Poster = "tylko-nie-mow-nikomu.jpg",
                            Price = 0.0,
                            Title = "Tylko nie mów nikomu"
                        },
                        new
                        {
                            FilmId = 7,
                            AddDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 5,
                            Desc = "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.",
                            Director = "Neil Burger",
                            Poster = "iluzjonista.jpg",
                            Price = 13.0,
                            Title = "Iluzjonista"
                        },
                        new
                        {
                            FilmId = 8,
                            AddDate = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 3,
                            Desc = "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.",
                            Director = "Vincenzo Natali",
                            Poster = "cube.jpg",
                            Price = 15.0,
                            Title = "Cube"
                        },
                        new
                        {
                            FilmId = 9,
                            AddDate = new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 1,
                            Desc = "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.",
                            Director = "Clive Barker",
                            Poster = "hellriser.jpg",
                            Price = 16.0,
                            Title = "Hellraiser: Wysłannik Piekieł"
                        },
                        new
                        {
                            FilmId = 10,
                            AddDate = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 3,
                            Desc = "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.",
                            Director = "Jonathan Demme",
                            Poster = "milczenie-owiec.jpg",
                            Price = 17.0,
                            Title = "Milczenie Owiec"
                        },
                        new
                        {
                            FilmId = 21,
                            AddDate = new DateTime(2010, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 4,
                            Desc = "Zespół specjalistów wkracza w umysł biznesmena, aby zaimplantować tam myśl.",
                            Director = "Christopher Nolan",
                            Price = 15.0,
                            Title = "Inception"
                        },
                        new
                        {
                            FilmId = 22,
                            AddDate = new DateTime(2012, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 3,
                            Desc = "Kiedy zaginie żona, mąż staje się głównym podejrzanym, ale sytuacja jest bardziej skomplikowana niż się wydaje.",
                            Director = "David Fincher",
                            Price = 35.0,
                            Title = "Gone Girl"
                        },
                        new
                        {
                            FilmId = 23,
                            AddDate = new DateTime(2010, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CategoryId = 1,
                            Desc = "Kiedy młoda dziewczyna zostaje opętana przez złego ducha, ksiądz próbuje jej pomóc.",
                            Director = "William Friedkin",
                            Price = 5.0,
                            Title = "The Exorcist"
                        },
                        new
                        {
                            FilmId = 24,
                            CategoryId = 2,
                            Desc = "Dokumentalny opis życia pingwinów cesarskich w Antarktyce.",
                            Director = "Luc Jacquet",
                            Title = "March of the Penguins"
                        },
                        new
                        {
                            FilmId = 25,
                            CategoryId = 5,
                            Desc = "Młody hobbit wyrusza w podróż, aby zniszczyć pierścień, który może zniszczyć świat.",
                            Director = "Peter Jackson",
                            Title = "The Lord of the Rings: The Fellowship of the Ring"
                        },
                        new
                        {
                            FilmId = 26,
                            CategoryId = 3,
                            Desc = "Dwóch detektywów tropi seryjnego mordercę, który działa według siedmiu grzechów głównych.",
                            Director = "David Fincher",
                            Title = "Se7en"
                        },
                        new
                        {
                            FilmId = 27,
                            CategoryId = 4,
                            Desc = "Policyjny porucznik staje w obronie budynku, który został przejęty przez terrorystów.",
                            Director = "John McTiernan",
                            Title = "Die Hard"
                        },
                        new
                        {
                            FilmId = 28,
                            CategoryId = 1,
                            Desc = "Grupa nastolatków odkrywa, że śmiercionośny morderca grasuje we śniech.",
                            Director = "Wes Craven",
                            Title = "A Nightmare on Elm Street"
                        },
                        new
                        {
                            FilmId = 29,
                            CategoryId = 2,
                            Desc = "Kontrowersyjny dokument o światach orków i ich warunkach życia w niewoli.",
                            Director = "Gabriela Cowperthwaite",
                            Title = "Blackfish"
                        },
                        new
                        {
                            FilmId = 30,
                            CategoryId = 5,
                            Desc = "W Hiszpanii podczas wojny domowej dziewczynka odkrywa magiczny labirynt w lesie.",
                            Director = "Guillermo del Toro",
                            Title = "Pan's Labyrinth"
                        },
                        new
                        {
                            FilmId = 11,
                            CategoryId = 1,
                            Desc = "Rodzina zamieszkuje opuszczony hotel, gdzie ojciec zaczyna stopniowo tracić zmysły.",
                            Director = "Stanley Kubrick",
                            Title = "The Shining"
                        },
                        new
                        {
                            FilmId = 12,
                            CategoryId = 1,
                            Desc = "Kobieta trafia do odległego motelu, gdzie właściciel ma mroczne sekrety.",
                            Director = "Alfred Hitchcock",
                            Title = "Psycho"
                        },
                        new
                        {
                            FilmId = 13,
                            CategoryId = 2,
                            Desc = "Seria dokumentalna przedstawiająca niesamowite zjawiska przyrody na całym świecie.",
                            Director = "David Attenborough",
                            Title = "Planet Earth II"
                        },
                        new
                        {
                            FilmId = 20,
                            CategoryId = 5,
                            Desc = "Młody czarodziej Harry Potter odkrywa swoje magiczne dziedzictwo, gdy zostaje zaproszony do Hogwartu.",
                            Director = "Chris Columbus",
                            Title = "Harry Potter and the Philosopher's Stone"
                        });
                });

            modelBuilder.Entity("Sklep_internetowy.Models.Film", b =>
                {
                    b.HasOne("Sklep_internetowy.Models.Category", "Category")
                        .WithMany("Films")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Sklep_internetowy.Models.Category", b =>
                {
                    b.Navigation("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
