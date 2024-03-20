﻿// <auto-generated />
using System;
using Infracstructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infracstructures.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230306074348_updateTableUsersAddTableRole")]
    partial class updateTableUsersAddTableRole
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Attendance", b =>
                {
                    b.Property<int>("ClassUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MorningStatus")
                        .HasColumnType("int");

                    b.Property<int?>("NightStatus")
                        .HasColumnType("int");

                    b.Property<int?>("NoonStatus")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("ClassUserId", "Day");

                    b.ToTable("Attendances", (string)null);
                });

            modelBuilder.Entity("Domain.Models.AuditDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuditorId")
                        .HasColumnType("int");

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuditorId");

                    b.HasIndex("PlanId");

                    b.HasIndex("TraineeId");

                    b.ToTable("AuditDetails", (string)null);
                });

            modelBuilder.Entity("Domain.Models.AuditPlans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AuditDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlannedBy")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("SyllabusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlannedBy");

                    b.HasIndex("SyllabusId");

                    b.ToTable("AuditPlans", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ApprovedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ApprovedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AttendeeType")
                        .HasColumnType("int");

                    b.Property<int>("ClassTime")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FSU")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Location")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("TrainingProgramId")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApprovedBy");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("Class", (string)null);
                });

            modelBuilder.Entity("Domain.Models.ClassUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("UserId");

                    b.ToTable("ClassUsers", (string)null);
                });

            modelBuilder.Entity("Domain.Models.FeedbackForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("TraineeId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TraineeId");

                    b.HasIndex("TrainerId");

                    b.ToTable("FeedBackForms", (string)null);
                });

            modelBuilder.Entity("Domain.Models.GradeReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Grade")
                        .HasColumnType("real");

                    b.Property<DateTime>("GradedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LectureId");

                    b.HasIndex("TraineeId");

                    b.ToTable("GradeReports", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeliveryType")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("LessonType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("OutputStandardId")
                        .HasColumnType("int");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OutputStandardId")
                        .IsUnique()
                        .HasFilter("[OutputStandardId] IS NOT NULL");

                    b.HasIndex("UnitId");

                    b.ToTable("Lectures", (string)null);
                });

            modelBuilder.Entity("Domain.Models.OutputStandard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("OutputStandards", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("ClassPermission")
                        .HasColumnType("int");

                    b.Property<int?>("LearningMaterialPermission")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SyllabusPermission")
                        .HasColumnType("int");

                    b.Property<int?>("TrainingProgramPermission")
                        .HasColumnType("int");

                    b.Property<int?>("UserPermission")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Syllabuses.Syllabus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AssignmentCriteria")
                        .HasColumnType("real");

                    b.Property<int>("AttendeeNumber")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CourseObjectives")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<float>("FinalCriteria")
                        .HasColumnType("real");

                    b.Property<float>("FinalPracticalCriteria")
                        .HasColumnType("real");

                    b.Property<float>("FinalTheoryCriteria")
                        .HasColumnType("real");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<float>("PassingGPA")
                        .HasColumnType("real");

                    b.Property<float>("QuizCriteria")
                        .HasColumnType("real");

                    b.Property<string>("TechnicalRequirements")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainingDeliveryPrincipleId")
                        .HasColumnType("int");

                    b.Property<float>("Version")
                        .HasColumnType("real");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("LastModifiedBy");

                    b.HasIndex("TrainingDeliveryPrincipleId")
                        .IsUnique()
                        .HasFilter("[TrainingDeliveryPrincipleId] IS NOT NULL");

                    b.ToTable("Syllabus", (string)null);
                });

            modelBuilder.Entity("Domain.Models.TMS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CheckedBy")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CheckedBy");

                    b.HasIndex("TraineeId");

                    b.ToTable("TMS", (string)null);
                });

            modelBuilder.Entity("Domain.Models.TrainingDeliveryPrinciple", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Marking")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Others")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaiverCriteria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingDeliveryPrinciple", (string)null);
                });

            modelBuilder.Entity("Domain.Models.TrainingMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("EditedBy");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("EditedOn");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("LectureId");

                    b.ToTable("TrainingMaterials", (string)null);
                });

            modelBuilder.Entity("Domain.Models.TrainingProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifyBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("LastModifyBy");

                    b.ToTable("TrainingPrograms", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Session")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Units", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AvatarURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsMale")
                        .HasColumnType("bit");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("SyllabusTrainingProgram", b =>
                {
                    b.Property<int>("SyllabusesId")
                        .HasColumnType("int");

                    b.Property<int>("TrainingProgramsId")
                        .HasColumnType("int");

                    b.HasKey("SyllabusesId", "TrainingProgramsId");

                    b.HasIndex("TrainingProgramsId");

                    b.ToTable("SyllabusTrainingProgram");
                });

            modelBuilder.Entity("SyllabusUnit", b =>
                {
                    b.Property<int>("SyllabusesId")
                        .HasColumnType("int");

                    b.Property<int>("UnitsId")
                        .HasColumnType("int");

                    b.HasKey("SyllabusesId", "UnitsId");

                    b.HasIndex("UnitsId");

                    b.ToTable("SyllabusUnit");
                });

            modelBuilder.Entity("Domain.Models.Attendance", b =>
                {
                    b.HasOne("Domain.Models.ClassUsers", "ClassUser")
                        .WithMany("Attendances")
                        .HasForeignKey("ClassUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassUser");
                });

            modelBuilder.Entity("Domain.Models.AuditDetails", b =>
                {
                    b.HasOne("Domain.Models.Users.User", "Auditor")
                        .WithMany("AuditDetailsAuditor")
                        .HasForeignKey("AuditorId")
                        .IsRequired();

                    b.HasOne("Domain.Models.AuditPlans", "AuditPlans")
                        .WithMany("AuditDetails")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Users.User", "Trainee")
                        .WithMany("AuditDetailsTrainee")
                        .HasForeignKey("TraineeId")
                        .IsRequired();

                    b.Navigation("AuditPlans");

                    b.Navigation("Auditor");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("Domain.Models.AuditPlans", b =>
                {
                    b.HasOne("Domain.Models.Users.User", "User")
                        .WithMany("AuditPlans")
                        .HasForeignKey("PlannedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Syllabuses.Syllabus", "Syllabus")
                        .WithMany("AuditPlans")
                        .HasForeignKey("SyllabusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Syllabus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Class", b =>
                {
                    b.HasOne("Domain.Models.Users.User", "ApprovedAdmin")
                        .WithMany("ApprovedClass")
                        .HasForeignKey("ApprovedBy");

                    b.HasOne("Domain.Models.Users.User", "CreatedAdmin")
                        .WithMany("CreatedClass")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Domain.Models.TrainingProgram", "TrainingProgram")
                        .WithMany("Classes")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("ApprovedAdmin");

                    b.Navigation("CreatedAdmin");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("Domain.Models.ClassUsers", b =>
                {
                    b.HasOne("Domain.Models.Class", "Class")
                        .WithMany("ClassUsers")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Users.User", "User")
                        .WithMany("ClassUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.FeedbackForm", b =>
                {
                    b.HasOne("Domain.Models.Users.User", "Trainee")
                        .WithMany("FeedbackTrainee")
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.Users.User", "Trainer")
                        .WithMany("FeedbackTrainer")
                        .HasForeignKey("TrainerId");

                    b.Navigation("Trainee");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Domain.Models.GradeReport", b =>
                {
                    b.HasOne("Domain.Models.Lecture", "Lecture")
                        .WithMany("GradeReports")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Users.User", "User")
                        .WithMany("GradeReports")
                        .HasForeignKey("TraineeId")
                        .IsRequired();

                    b.Navigation("Lecture");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Lecture", b =>
                {
                    b.HasOne("Domain.Models.OutputStandard", "OutputStandard")
                        .WithOne("Lecture")
                        .HasForeignKey("Domain.Models.Lecture", "OutputStandardId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Domain.Models.Unit", "Unit")
                        .WithMany("Lectures")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("OutputStandard");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Domain.Models.Syllabuses.Syllabus", b =>
                {
                    b.HasOne("Domain.Models.Users.User", "CreatedAdmin")
                        .WithMany("CreatedSyllabus")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Domain.Models.Users.User", "ModifiedAdmin")
                        .WithMany("ModifiedSyllabus")
                        .HasForeignKey("LastModifiedBy");

                    b.HasOne("Domain.Models.TrainingDeliveryPrinciple", "TrainingDeliveryPrinciple")
                        .WithOne("Syllabus")
                        .HasForeignKey("Domain.Models.Syllabuses.Syllabus", "TrainingDeliveryPrincipleId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("CreatedAdmin");

                    b.Navigation("ModifiedAdmin");

                    b.Navigation("TrainingDeliveryPrinciple");
                });

            modelBuilder.Entity("Domain.Models.TMS", b =>
                {
                    b.HasOne("Domain.Models.Users.User", "Admin")
                        .WithMany("TimeMngSystem")
                        .HasForeignKey("CheckedBy");

                    b.HasOne("Domain.Models.Users.User", "Trainee")
                        .WithMany("TimeMngSystemList")
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("Domain.Models.TrainingMaterial", b =>
                {
                    b.HasOne("Domain.Models.Users.User", "User")
                        .WithMany("TrainingMaterials")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.Lecture", "Lecture")
                        .WithMany("TrainingMaterials")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecture");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.TrainingProgram", b =>
                {
                    b.HasOne("Domain.Models.Users.User", "CreatedAdmin")
                        .WithMany("CreatedTrainingProgram")
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Domain.Models.Users.User", "ModifiedAdmin")
                        .WithMany("ModifyTrainingProgram")
                        .HasForeignKey("LastModifyBy");

                    b.Navigation("CreatedAdmin");

                    b.Navigation("ModifiedAdmin");
                });

            modelBuilder.Entity("Domain.Models.Users.User", b =>
                {
                    b.HasOne("Domain.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SyllabusTrainingProgram", b =>
                {
                    b.HasOne("Domain.Models.Syllabuses.Syllabus", null)
                        .WithMany()
                        .HasForeignKey("SyllabusesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.TrainingProgram", null)
                        .WithMany()
                        .HasForeignKey("TrainingProgramsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SyllabusUnit", b =>
                {
                    b.HasOne("Domain.Models.Syllabuses.Syllabus", null)
                        .WithMany()
                        .HasForeignKey("SyllabusesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Unit", null)
                        .WithMany()
                        .HasForeignKey("UnitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.AuditPlans", b =>
                {
                    b.Navigation("AuditDetails");
                });

            modelBuilder.Entity("Domain.Models.Class", b =>
                {
                    b.Navigation("ClassUsers");
                });

            modelBuilder.Entity("Domain.Models.ClassUsers", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("Domain.Models.Lecture", b =>
                {
                    b.Navigation("GradeReports");

                    b.Navigation("TrainingMaterials");
                });

            modelBuilder.Entity("Domain.Models.OutputStandard", b =>
                {
                    b.Navigation("Lecture");
                });

            modelBuilder.Entity("Domain.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Models.Syllabuses.Syllabus", b =>
                {
                    b.Navigation("AuditPlans");
                });

            modelBuilder.Entity("Domain.Models.TrainingDeliveryPrinciple", b =>
                {
                    b.Navigation("Syllabus");
                });

            modelBuilder.Entity("Domain.Models.TrainingProgram", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("Domain.Models.Unit", b =>
                {
                    b.Navigation("Lectures");
                });

            modelBuilder.Entity("Domain.Models.Users.User", b =>
                {
                    b.Navigation("ApprovedClass");

                    b.Navigation("AuditDetailsAuditor");

                    b.Navigation("AuditDetailsTrainee");

                    b.Navigation("AuditPlans");

                    b.Navigation("ClassUsers");

                    b.Navigation("CreatedClass");

                    b.Navigation("CreatedSyllabus");

                    b.Navigation("CreatedTrainingProgram");

                    b.Navigation("FeedbackTrainee");

                    b.Navigation("FeedbackTrainer");

                    b.Navigation("GradeReports");

                    b.Navigation("ModifiedSyllabus");

                    b.Navigation("ModifyTrainingProgram");

                    b.Navigation("TimeMngSystem");

                    b.Navigation("TimeMngSystemList");

                    b.Navigation("TrainingMaterials");
                });
#pragma warning restore 612, 618
        }
    }
}
