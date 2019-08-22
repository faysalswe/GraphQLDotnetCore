﻿// <auto-generated />
using System;
using DemoGraphQL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoGraphQL.Migrations
{
    [DbContext(typeof(DemoAppContext))]
    [Migration("20190822055047_initial migration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoGraphQL.Model.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DemoGraphQL.Model.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DemoGraphQL.Model.Enrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Semester");

                    b.Property<Guid>("StudentId");

                    b.Property<short>("Year");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("DemoGraphQL.Model.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("Age");

                    b.Property<Guid>("DepartmentId");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DemoGraphQL.Model.StudentCourse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CourseId");

                    b.Property<Guid>("EnrollmentId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("EnrollmentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("DemoGraphQL.Model.Enrollment", b =>
                {
                    b.HasOne("DemoGraphQL.Model.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoGraphQL.Model.Student", b =>
                {
                    b.HasOne("DemoGraphQL.Model.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoGraphQL.Model.StudentCourse", b =>
                {
                    b.HasOne("DemoGraphQL.Model.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoGraphQL.Model.Enrollment", "Enrollment")
                        .WithMany()
                        .HasForeignKey("EnrollmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
