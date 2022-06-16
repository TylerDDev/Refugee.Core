﻿// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO DELIVER HUMANITARIAN AID, HOPE AND LOVE
// -------------------------------------------------------

// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RefugeeLand.Core.Api.Brokers.Storages;

#nullable disable

namespace RefugeeLand.Core.Api.Migrations
{
    [DbContext(typeof(StorageBroker))]
    partial class StorageBrokerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.AllowedPets.AllowedPet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ShelterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShelterId");

                    b.ToTable("AllowedPet");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Hosts.Host", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Hosts");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Languages.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FluencyLevel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.MedicalConditions.MedicalCondition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicalConditions");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Nationalities.Nationality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.PetMedicalConditions.PetMedicalCondition", b =>
                {
                    b.Property<Guid>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MedicalConditionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PetId", "MedicalConditionId");

                    b.HasIndex("MedicalConditionId");

                    b.ToTable("PetMedicalConditions");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Pets.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeeGroupMemberships.RefugeeGroupMembership", b =>
                {
                    b.Property<Guid>("RefugeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RefugeeGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDecisionMaker")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRefugeeGroupRepresentative")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("RefugeeId", "RefugeeGroupId");

                    b.HasIndex("RefugeeGroupId");

                    b.ToTable("RefugeeGroupMemberships");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeeGroups.RefugeeGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RefugeeGroupMainRepresentativeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("RefugeeGroupMainRepresentativeId");

                    b.ToTable("RefugeeGroups");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeePets.RefugeePet", b =>
                {
                    b.Property<Guid>("RefugeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RefugeeId", "PetId");

                    b.HasIndex("PetId");

                    b.ToTable("RefugeePets");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Refugees.Refugee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CurrentLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsOpenToWork")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Refugees");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.ShelterOffers.ShelterOffer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ShelterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.HasIndex("ShelterId");

                    b.ToTable("ShelterOffers");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.ShelterRefugeeOccupants.ShelterRefugeeOccupant", b =>
                {
                    b.Property<Guid>("ShelterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RefugeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("InhabitationStatus")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("ShelterId", "RefugeeId");

                    b.HasIndex("RefugeeId");

                    b.ToTable("ShelterRefugeeOccupants");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Shelters.Shelter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BabyBedNumber")
                        .HasColumnType("int");

                    b.Property<int>("BedroomNumber")
                        .HasColumnType("int");

                    b.Property<int>("ChildBedNumber")
                        .HasColumnType("int");

                    b.Property<int>("DoubleBedNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("HostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsHandicappedAccessible")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPetAllowed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSmokingAllowed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaximumCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.Property<int>("SingleBedNumber")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.ToTable("Shelters");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.AllowedPets.AllowedPet", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.Shelters.Shelter", null)
                        .WithMany("AllowedPets")
                        .HasForeignKey("ShelterId");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.PetMedicalConditions.PetMedicalCondition", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.MedicalConditions.MedicalCondition", "MedicalCondition")
                        .WithMany("PetMedicalConditions")
                        .HasForeignKey("MedicalConditionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RefugeeLand.Core.Api.Models.Pets.Pet", "Pet")
                        .WithMany("PetMedicalConditions")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("MedicalCondition");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeeGroupMemberships.RefugeeGroupMembership", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.RefugeeGroups.RefugeeGroup", "RefugeeGroup")
                        .WithMany("RefugeeGroupMemberships")
                        .HasForeignKey("RefugeeGroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RefugeeLand.Core.Api.Models.Refugees.Refugee", "Refugee")
                        .WithMany("RefugeeGroupMemberships")
                        .HasForeignKey("RefugeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Refugee");

                    b.Navigation("RefugeeGroup");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeeGroups.RefugeeGroup", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.Refugees.Refugee", "RefugeeGroupMainRepresentative")
                        .WithMany()
                        .HasForeignKey("RefugeeGroupMainRepresentativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RefugeeGroupMainRepresentative");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeePets.RefugeePet", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.Pets.Pet", "Pet")
                        .WithMany("RefugeePets")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RefugeeLand.Core.Api.Models.Refugees.Refugee", "Refugee")
                        .WithMany("RefugeePets")
                        .HasForeignKey("RefugeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("Refugee");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.ShelterOffers.ShelterOffer", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.Hosts.Host", "Host")
                        .WithMany("ShelterOffers")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RefugeeLand.Core.Api.Models.Shelters.Shelter", "Shelter")
                        .WithMany("ShelterOffers")
                        .HasForeignKey("ShelterId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Host");

                    b.Navigation("Shelter");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.ShelterRefugeeOccupants.ShelterRefugeeOccupant", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.Refugees.Refugee", "Refugee")
                        .WithMany("ShelterRefugeeOccupants")
                        .HasForeignKey("RefugeeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RefugeeLand.Core.Api.Models.Shelters.Shelter", "Shelter")
                        .WithMany("ShelterRefugeeOccupants")
                        .HasForeignKey("ShelterId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Refugee");

                    b.Navigation("Shelter");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Shelters.Shelter", b =>
                {
                    b.HasOne("RefugeeLand.Core.Api.Models.Hosts.Host", "Host")
                        .WithMany("Shelters")
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Host");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Hosts.Host", b =>
                {
                    b.Navigation("ShelterOffers");

                    b.Navigation("Shelters");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.MedicalConditions.MedicalCondition", b =>
                {
                    b.Navigation("PetMedicalConditions");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Pets.Pet", b =>
                {
                    b.Navigation("PetMedicalConditions");

                    b.Navigation("RefugeePets");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.RefugeeGroups.RefugeeGroup", b =>
                {
                    b.Navigation("RefugeeGroupMemberships");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Refugees.Refugee", b =>
                {
                    b.Navigation("RefugeeGroupMemberships");

                    b.Navigation("RefugeePets");

                    b.Navigation("ShelterRefugeeOccupants");
                });

            modelBuilder.Entity("RefugeeLand.Core.Api.Models.Shelters.Shelter", b =>
                {
                    b.Navigation("AllowedPets");

                    b.Navigation("ShelterOffers");

                    b.Navigation("ShelterRefugeeOccupants");
                });
#pragma warning restore 612, 618
        }
    }
}
