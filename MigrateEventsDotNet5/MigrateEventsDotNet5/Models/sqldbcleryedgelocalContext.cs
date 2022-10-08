using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MigrateEvents.Models
{
    public partial class sqldbcleryedgelocalContext : DbContext
    {
        public sqldbcleryedgelocalContext()
        {
        }

        public sqldbcleryedgelocalContext(DbContextOptions<sqldbcleryedgelocalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alert> Alerts { get; set; } = null!;
        public virtual DbSet<AlertsOrganizer> AlertsOrganizers { get; set; } = null!;
        public virtual DbSet<Allergy> Allergies { get; set; } = null!;
        public virtual DbSet<AuditReconciliation> AuditReconciliations { get; set; } = null!;
        public virtual DbSet<AuthCode> AuthCodes { get; set; } = null!;
        public virtual DbSet<Boilerplate> Boilerplates { get; set; } = null!;
        public virtual DbSet<Campus> Campuses { get; set; } = null!;
        public virtual DbSet<Channel> Channels { get; set; } = null!;
        public virtual DbSet<ChannelEmail> ChannelEmails { get; set; } = null!;
        public virtual DbSet<CleryArrest> CleryArrests { get; set; } = null!;
        public virtual DbSet<CleryCampus> CleryCampuses { get; set; } = null!;
        public virtual DbSet<CleryCategory> CleryCategories { get; set; } = null!;
        public virtual DbSet<CleryCause> CleryCauses { get; set; } = null!;
        public virtual DbSet<CleryClassification> CleryClassifications { get; set; } = null!;
        public virtual DbSet<CleryCsaclassification> CleryCsaclassifications { get; set; } = null!;
        public virtual DbSet<CleryCsahistory> CleryCsahistories { get; set; } = null!;
        public virtual DbSet<CleryCsalistHistory> CleryCsalistHistories { get; set; } = null!;
        public virtual DbSet<CleryCsatrainingAssignment> CleryCsatrainingAssignments { get; set; } = null!;
        public virtual DbSet<CleryCsauser> CleryCsausers { get; set; } = null!;
        public virtual DbSet<CleryCsauserHistory> CleryCsauserHistories { get; set; } = null!;
        public virtual DbSet<CleryGeographicLocation> CleryGeographicLocations { get; set; } = null!;
        public virtual DbSet<CleryPoliceAddress> CleryPoliceAddresses { get; set; } = null!;
        public virtual DbSet<CleryReport> CleryReports { get; set; } = null!;
        public virtual DbSet<CleryVawa> CleryVawas { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<CrimeLogArchive> CrimeLogArchives { get; set; } = null!;
        public virtual DbSet<DailyCrimeLog> DailyCrimeLogs { get; set; } = null!;
        public virtual DbSet<DailyCrimeLogHistory> DailyCrimeLogHistories { get; set; } = null!;
        public virtual DbSet<Dcrclassification> Dcrclassifications { get; set; } = null!;
        public virtual DbSet<Disposition> Dispositions { get; set; } = null!;
        public virtual DbSet<Email> Emails { get; set; } = null!;
        public virtual DbSet<EmailHeader> EmailHeaders { get; set; } = null!;
        public virtual DbSet<EmailType> EmailTypes { get; set; } = null!;
        public virtual DbSet<EmailVariable> EmailVariables { get; set; } = null!;
        public virtual DbSet<EmergencyContact> EmergencyContacts { get; set; } = null!;
        public virtual DbSet<ExportControl> ExportControls { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Geography> Geographies { get; set; } = null!;
        public virtual DbSet<GeographyAgency> GeographyAgencies { get; set; } = null!;
        public virtual DbSet<GeographyClassification> GeographyClassifications { get; set; } = null!;
        public virtual DbSet<GeographyEffectiveDate> GeographyEffectiveDates { get; set; } = null!;
        public virtual DbSet<GeographyMap> GeographyMaps { get; set; } = null!;
        public virtual DbSet<Immunization> Immunizations { get; set; } = null!;
        public virtual DbSet<Institution> Institutions { get; set; } = null!;
        public virtual DbSet<InstitutionCollegeSchool> InstitutionCollegeSchools { get; set; } = null!;
        public virtual DbSet<InstitutionDepartment> InstitutionDepartments { get; set; } = null!;
        public virtual DbSet<InstitutionEmail> InstitutionEmails { get; set; } = null!;
        public virtual DbSet<Insurance> Insurances { get; set; } = null!;
        public virtual DbSet<Itinerary> Itineraries { get; set; } = null!;
        public virtual DbSet<Llea> Lleas { get; set; } = null!;
        public virtual DbSet<Medical> Medicals { get; set; } = null!;
        public virtual DbSet<Medication> Medications { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MissingContact> MissingContacts { get; set; } = null!;
        public virtual DbSet<MissingOutreach> MissingOutreaches { get; set; } = null!;
        public virtual DbSet<MissingReport> MissingReports { get; set; } = null!;
        public virtual DbSet<MissingReportAgency> MissingReportAgencies { get; set; } = null!;
        public virtual DbSet<MultipleQuestion> MultipleQuestions { get; set; } = null!;
        public virtual DbSet<Passport> Passports { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<PermissionGroup> PermissionGroups { get; set; } = null!;
        public virtual DbSet<Piralert> Piralerts { get; set; } = null!;
        public virtual DbSet<PreExisiting> PreExisitings { get; set; } = null!;
        public virtual DbSet<QuizAnswer> QuizAnswers { get; set; } = null!;
        public virtual DbSet<QuizMultiple> QuizMultiples { get; set; } = null!;
        public virtual DbSet<QuizTrueFalse> QuizTrueFalses { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Rental> Rentals { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<ReportClery> ReportCleries { get; set; } = null!;
        public virtual DbSet<ReportCleryType> ReportCleryTypes { get; set; } = null!;
        public virtual DbSet<ReportNote> ReportNotes { get; set; } = null!;
        public virtual DbSet<ReportType> ReportTypes { get; set; } = null!;
        public virtual DbSet<ReportsAlert> ReportsAlerts { get; set; } = null!;
        public virtual DbSet<ReportsKnown> ReportsKnowns { get; set; } = null!;
        public virtual DbSet<ReportsTwassessment> ReportsTwassessments { get; set; } = null!;
        public virtual DbSet<ReportsTwassessmentReviewer> ReportsTwassessmentReviewers { get; set; } = null!;
        public virtual DbSet<ReportsUnknown> ReportsUnknowns { get; set; } = null!;
        public virtual DbSet<Research> Researches { get; set; } = null!;
        public virtual DbSet<RiskCountry> RiskCountries { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<SiteContent> SiteContents { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<TrainingCourse> TrainingCourses { get; set; } = null!;
        public virtual DbSet<TrainingLesson> TrainingLessons { get; set; } = null!;
        public virtual DbSet<TrainingQuiz> TrainingQuizzes { get; set; } = null!;
        public virtual DbSet<TravelAuth> TravelAuths { get; set; } = null!;
        public virtual DbSet<Traveller> Travellers { get; set; } = null!;
        public virtual DbSet<TwilioCredential> TwilioCredentials { get; set; } = null!;
        public virtual DbSet<UploadedFile> UploadedFiles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserType> UserTypes { get; set; } = null!;
        public virtual DbSet<UserTypePermission> UserTypePermissions { get; set; } = null!;
        public virtual DbSet<VRptItinerary> VRptItineraries { get; set; } = null!;
        public virtual DbSet<VRptParticipant> VRptParticipants { get; set; } = null!;
        public virtual DbSet<VRptStep> VRptSteps { get; set; } = null!;
        public virtual DbSet<VRptTraveler> VRptTravelers { get; set; } = null!;
        public virtual DbSet<VRptTrip> VRptTrips { get; set; } = null!;
        public virtual DbSet<VTripInfo> VTripInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=sqldb-cleryedge-local;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alert>(entity =>
            {
                entity.Property(e => e.Recipients).HasMaxLength(200);

                entity.Property(e => e.Subject).HasMaxLength(150);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Alerts)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_Alerts_Institution");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Alerts)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alerts_Users");
            });

            modelBuilder.Entity<AlertsOrganizer>(entity =>
            {
                entity.HasKey(e => e.Aoid);

                entity.ToTable("AlertsOrganizer");

                entity.Property(e => e.Aoid).HasColumnName("AOId");

                entity.Property(e => e.Atype)
                    .HasMaxLength(30)
                    .HasColumnName("AType");

                entity.Property(e => e.CaseId).HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.IsLog).HasColumnName("isLog");

                entity.Property(e => e.MsgSubject).HasMaxLength(150);

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.OtherId).HasMaxLength(30);

                entity.Property(e => e.PreviousAoid).HasColumnName("PreviousAOId");

                entity.Property(e => e.PublicationChannels).HasMaxLength(300);

                entity.HasOne(d => d.Footer)
                    .WithMany(p => p.AlertsOrganizerFooters)
                    .HasForeignKey(d => d.FooterId)
                    .HasConstraintName("FK_AlertsOrganizer_boilerplate2");

                entity.HasOne(d => d.Header)
                    .WithMany(p => p.AlertsOrganizerHeaders)
                    .HasForeignKey(d => d.HeaderId)
                    .HasConstraintName("FK_AlertsOrganizer_boilerplate");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.AlertsOrganizers)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_AlertsOrganizer_Institution");

                entity.HasOne(d => d.Safety)
                    .WithMany(p => p.AlertsOrganizerSafeties)
                    .HasForeignKey(d => d.SafetyId)
                    .HasConstraintName("FK_AlertsOrganizer_boilerplate1");
            });

            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.ToTable("Allergy");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Medical)
                    .WithMany(p => p.Allergies)
                    .HasForeignKey(d => d.MedicalId)
                    .HasConstraintName("FK_Allergy_Medical");
            });

            modelBuilder.Entity<AuditReconciliation>(entity =>
            {
                entity.ToTable("AuditReconciliation");

                entity.HasIndex(e => e.CleryCrimeId, "IX_AuditReconciliation")
                    .IsUnique();

                entity.HasOne(d => d.CleryCrime)
                    .WithOne(p => p.AuditReconciliation)
                    .HasForeignKey<AuditReconciliation>(d => d.CleryCrimeId)
                    .HasConstraintName("FK_AuditReconciliation_ReportClery");
            });

            modelBuilder.Entity<AuthCode>(entity =>
            {
                entity.ToTable("AuthCode");

                entity.Property(e => e.AuthCodeId).ValueGeneratedNever();

                entity.Property(e => e.IpAddress).HasMaxLength(16);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthCodes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AuthCode_Users");
            });

            modelBuilder.Entity<Boilerplate>(entity =>
            {
                entity.HasKey(e => e.BpId);

                entity.ToTable("boilerplate");

                entity.Property(e => e.BpId).HasColumnName("bpID");

                entity.Property(e => e.ContentName).HasMaxLength(100);

                entity.Property(e => e.Section).HasMaxLength(50);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Boilerplates)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_boilerplate_Institution");
            });

            modelBuilder.Entity<Campus>(entity =>
            {
                entity.ToTable("Campus");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.HasOne(d => d.Inst)
                    .WithMany(p => p.Campuses)
                    .HasForeignKey(d => d.InstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Campus_Institution");
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.ToTable("Channel");

                entity.Property(e => e.AlertType).HasMaxLength(35);

                entity.Property(e => e.ChannelType).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Channels)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_Channel_Institution");
            });

            modelBuilder.Entity<ChannelEmail>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.ToTable("ChannelEmail");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.ChannelEmails)
                    .HasForeignKey(d => d.ChannelId)
                    .HasConstraintName("FK_ChannelEmail_Channel");
            });

            modelBuilder.Entity<CleryArrest>(entity =>
            {
                entity.HasKey(e => e.ArrestsId);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CleryCampus>(entity =>
            {
                entity.ToTable("CleryCampus");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.CleryCampuses)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CleryCampus_Institution");
            });

            modelBuilder.Entity<CleryCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("CleryCategory");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CleryCause>(entity =>
            {
                entity.HasKey(e => e.CauseId);

                entity.ToTable("CleryCause");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CleryClassification>(entity =>
            {
                entity.HasKey(e => e.ClassificationId);

                entity.ToTable("CleryClassification");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CleryCsaclassification>(entity =>
            {
                entity.HasKey(e => e.ClassificationId);

                entity.ToTable("CleryCSAClassification");

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<CleryCsahistory>(entity =>
            {
                entity.ToTable("CleryCSAHistory");

                entity.Property(e => e.CleryCsahistoryId).HasColumnName("CleryCSAHistoryId");

                entity.Property(e => e.CleryCsaid).HasColumnName("CleryCSAid");

                entity.HasOne(d => d.CleryCsa)
                    .WithMany(p => p.CleryCsahistories)
                    .HasForeignKey(d => d.CleryCsaid)
                    .HasConstraintName("FK_CleryCSAHistory_CleryCSAUser");
            });

            modelBuilder.Entity<CleryCsalistHistory>(entity =>
            {
                entity.ToTable("CleryCSAListHistory");

                entity.Property(e => e.CleryCsalistHistoryId).HasColumnName("CleryCSAListHistoryId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CleryCsalistHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CleryCSAListHistory_Users");
            });

            modelBuilder.Entity<CleryCsatrainingAssignment>(entity =>
            {
                entity.HasKey(e => e.AssignmentId);

                entity.ToTable("CleryCSATrainingAssignment");

                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.CleryCsaid).HasColumnName("CleryCSAid");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.HasOne(d => d.CleryCsa)
                    .WithMany(p => p.CleryCsatrainingAssignments)
                    .HasForeignKey(d => d.CleryCsaid)
                    .HasConstraintName("FK_CleryCSATrainingAssignment_CleryCSAUser");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CleryCsatrainingAssignments)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CleryCSATrainingAssignment_TrainingCourse");
            });

            modelBuilder.Entity<CleryCsauser>(entity =>
            {
                entity.HasKey(e => e.CleryCsaid);

                entity.ToTable("CleryCSAUser");

                entity.HasIndex(e => e.UserId, "UQ__CleryCSA__CB9A1CFE3E3FA377")
                    .IsUnique();

                entity.Property(e => e.CleryCsaid).HasColumnName("CleryCSAid");

                entity.Property(e => e.ConfirmationCode).HasMaxLength(50);

                entity.Property(e => e.CsalistUpdater).HasColumnName("CSAListUpdater");

                entity.Property(e => e.Title).HasMaxLength(75);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Classification)
                    .WithMany(p => p.CleryCsausers)
                    .HasForeignKey(d => d.ClassificationId)
                    .HasConstraintName("FK_CleryCSAUser_CleryCSAClassification");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.CleryCsauser)
                    .HasForeignKey<CleryCsauser>(d => d.UserId)
                    .HasConstraintName("FK_CleryCSAUser_Users");
            });

            modelBuilder.Entity<CleryCsauserHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("CleryCSAUserHistory");

                entity.Property(e => e.ActionName).HasMaxLength(120);

                entity.Property(e => e.CleryCsauserId).HasColumnName("CleryCSAUserId");

                entity.HasOne(d => d.CleryCsauser)
                    .WithMany(p => p.CleryCsauserHistories)
                    .HasForeignKey(d => d.CleryCsauserId)
                    .HasConstraintName("FK_CleryCSAUserHistory_CleryCSAUser");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.CleryCsauserHistories)
                    .HasForeignKey(d => d.TrainingId)
                    .HasConstraintName("FK_CleryCSAUserHistory_TrainingCourse");
            });

            modelBuilder.Entity<CleryGeographicLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("CleryGeographicLocation");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CleryPoliceAddress>(entity =>
            {
                entity.HasKey(e => e.PoliceId);

                entity.ToTable("CleryPoliceAddress");

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(100);

                entity.Property(e => e.County).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PoliceName).HasMaxLength(150);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((2))");

                entity.Property(e => e.Website).HasMaxLength(500);

                entity.Property(e => e.Zip).HasMaxLength(18);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CleryPoliceAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CleryPoliceAddress_Country");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CleryPoliceAddresses)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_CleryPoliceAddress_Users");
            });

            modelBuilder.Entity<CleryReport>(entity =>
            {
                entity.HasKey(e => e.CleryId);

                entity.ToTable("CleryReport");

                entity.Property(e => e.CaseNumber).HasMaxLength(15);

                entity.Property(e => e.ContactEmail).HasMaxLength(320);

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.ContactPhone).HasMaxLength(20);

                entity.Property(e => e.LocationCity).HasMaxLength(150);

                entity.Property(e => e.LocationEmail).HasMaxLength(320);

                entity.Property(e => e.LocationName).HasMaxLength(150);

                entity.Property(e => e.LocationPhone).HasMaxLength(35);

                entity.Property(e => e.LocationRoomNum).HasMaxLength(20);

                entity.Property(e => e.LocationState).HasMaxLength(100);

                entity.Property(e => e.LocationStreetAddress).HasMaxLength(150);

                entity.Property(e => e.LocationZip).HasMaxLength(18);

                entity.Property(e => e.Status).HasMaxLength(30);

                entity.HasOne(d => d.CleryCampus)
                    .WithMany(p => p.CleryReports)
                    .HasForeignKey(d => d.CleryCampusId)
                    .HasConstraintName("FK_CleryReport_CleryCampus");

                entity.HasOne(d => d.ContactSubUnit)
                    .WithMany(p => p.CleryReports)
                    .HasForeignKey(d => d.ContactSubUnitId)
                    .HasConstraintName("FK_CleryReport_InstitutionDepartment");

                entity.HasOne(d => d.ContactUnit)
                    .WithMany(p => p.CleryReports)
                    .HasForeignKey(d => d.ContactUnitId)
                    .HasConstraintName("FK_CleryReport_InstitutionCollegeSchool");

                entity.HasOne(d => d.LocationCountry)
                    .WithMany(p => p.CleryReports)
                    .HasForeignKey(d => d.LocationCountryId)
                    .HasConstraintName("FK_CleryReport_Country");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.CleryReports)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_CleryReport_CleryGeographicLocation");

                entity.HasOne(d => d.PoliceAddress)
                    .WithMany(p => p.CleryReports)
                    .HasForeignKey(d => d.PoliceAddressId)
                    .HasConstraintName("FK_CleryReport_CleryPoliceAddress");

                entity.HasOne(d => d.RelatedTrip)
                    .WithMany(p => p.CleryReports)
                    .HasForeignKey(d => d.RelatedTripId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CleryReport_TravelAuth");
            });

            modelBuilder.Entity<CleryVawa>(entity =>
            {
                entity.HasKey(e => e.Vawaid);

                entity.ToTable("CleryVAWA");

                entity.Property(e => e.Vawaid).HasColumnName("VAWAid");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Country_Region");
            });

            modelBuilder.Entity<CrimeLogArchive>(entity =>
            {
                entity.ToTable("CrimeLogArchive");

                entity.HasIndex(e => e.UploadedFileId, "UQ__tmp_ms_x__E2C7E78795A86A9B")
                    .IsUnique();

                entity.Property(e => e.ArchiveType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Note).HasMaxLength(800);

                entity.HasOne(d => d.CleryCampus)
                    .WithMany(p => p.CrimeLogArchives)
                    .HasForeignKey(d => d.CleryCampusId)
                    .HasConstraintName("FK_CrimeLogArchive_CleryCampus");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrimeLogArchives)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrimeLogArchive_Users");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.CrimeLogArchives)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrimeLogArchive_Institution");

                entity.HasOne(d => d.UploadedFile)
                    .WithOne(p => p.CrimeLogArchive)
                    .HasForeignKey<CrimeLogArchive>(d => d.UploadedFileId)
                    .HasConstraintName("FK_CrimeLogArchive_UploadedFileId");
            });

            modelBuilder.Entity<DailyCrimeLog>(entity =>
            {
                entity.ToTable("DailyCrimeLog");

                entity.Property(e => e.DclcaseNumber)
                    .HasMaxLength(15)
                    .HasColumnName("DCLCaseNumber");

                entity.Property(e => e.Dclclassification)
                    .HasMaxLength(50)
                    .HasColumnName("DCLClassification");

                entity.Property(e => e.DcldelayReason)
                    .HasMaxLength(150)
                    .HasColumnName("DCLDelayReason");

                entity.Property(e => e.Dcldelayed)
                    .HasMaxLength(5)
                    .HasColumnName("DCLDelayed");

                entity.Property(e => e.Dcldisposition)
                    .HasMaxLength(50)
                    .HasColumnName("DCLDisposition");

                entity.Property(e => e.DclisInfoWithheld)
                    .HasMaxLength(5)
                    .HasColumnName("DCLIsInfoWithheld");

                entity.Property(e => e.Dcllocation)
                    .HasMaxLength(50)
                    .HasColumnName("DCLLocation");

                entity.Property(e => e.DclnotesInternal).HasColumnName("DCLNotesInternal");

                entity.Property(e => e.DclnotesPublic).HasColumnName("DCLNotesPublic");

                entity.Property(e => e.Dcloccur).HasColumnName("DCLOccur");

                entity.Property(e => e.DcloccurEnd).HasColumnName("DCLOccurEnd");

                entity.Property(e => e.DclreportCaseNumber)
                    .HasMaxLength(15)
                    .HasColumnName("DCLReportCaseNumber");

                entity.Property(e => e.Dclreported).HasColumnName("DCLReported");

                entity.Property(e => e.DclwhenPublished).HasColumnName("DCLWhenPublished");

                entity.Property(e => e.DclwhenReviewed).HasColumnName("DCLWhenReviewed");

                entity.Property(e => e.DclwhoPublished)
                    .HasMaxLength(100)
                    .HasColumnName("DCLWhoPublished");

                entity.Property(e => e.DclwhoReviewed)
                    .HasMaxLength(100)
                    .HasColumnName("DCLWhoReviewed");

                entity.Property(e => e.DclwithheldDetails)
                    .HasMaxLength(150)
                    .HasColumnName("DCLWithheldDetails");

                entity.Property(e => e.DclwithheldReason)
                    .HasMaxLength(150)
                    .HasColumnName("DCLWithheldReason");

                entity.Property(e => e.PublicationStatus).HasMaxLength(20);

                entity.HasOne(d => d.CleryCampus)
                    .WithMany(p => p.DailyCrimeLogs)
                    .HasForeignKey(d => d.CleryCampusId)
                    .HasConstraintName("FK_DailyCrimeLog_CleryCampus");

                entity.HasOne(d => d.DailyCrimeLogHistory)
                    .WithMany(p => p.DailyCrimeLogs)
                    .HasForeignKey(d => d.DailyCrimeLogHistoryId)
                    .HasConstraintName("FK_DailyCrimeLog_DailyCrimeLogHistory");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.DailyCrimeLogs)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_DailyCrimeLog_Institution");
            });

            modelBuilder.Entity<DailyCrimeLogHistory>(entity =>
            {
                entity.ToTable("DailyCrimeLogHistory");

                entity.Property(e => e.Dclclassification)
                    .HasMaxLength(50)
                    .HasColumnName("DCLClassification");

                entity.Property(e => e.Dcldisposition)
                    .HasMaxLength(50)
                    .HasColumnName("DCLDisposition");

                entity.Property(e => e.Dclid).HasColumnName("DCLId");

                entity.Property(e => e.DcllastUpdatedTime).HasColumnName("DCLLastUpdatedTime");

                entity.Property(e => e.DcllastUpdatedUser)
                    .HasMaxLength(100)
                    .HasColumnName("DCLLastUpdatedUser");

                entity.Property(e => e.Dcllocation)
                    .HasMaxLength(50)
                    .HasColumnName("DCLLocation");

                entity.Property(e => e.DclnotesPublic).HasColumnName("DCLNotesPublic");

                entity.Property(e => e.Dcloccur).HasColumnName("DCLOccur");

                entity.Property(e => e.DclrecentPublishUser)
                    .HasMaxLength(100)
                    .HasColumnName("DCLRecentPublishUser");

                entity.Property(e => e.DclrecentPulishTime).HasColumnName("DCLRecentPulishTime");

                entity.Property(e => e.Dclreported).HasColumnName("DCLReported");
            });

            modelBuilder.Entity<Dcrclassification>(entity =>
            {
                entity.ToTable("DCRClassification");

                entity.Property(e => e.DcrclassificationId).HasColumnName("DCRClassificationId");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Dcrclassifications)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DCRClassification_Institution");
            });

            modelBuilder.Entity<Disposition>(entity =>
            {
                entity.ToTable("Disposition");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ReportType).HasMaxLength(20);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Dispositions)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Disposition_Institution");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasKey(e => e.MailId);

                entity.ToTable("Email");

                entity.Property(e => e.MailId).HasColumnName("mailId");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Email_Institution");
            });

            modelBuilder.Entity<EmailHeader>(entity =>
            {
                entity.Property(e => e.EmailName).HasMaxLength(50);

                entity.HasOne(d => d.EmailType)
                    .WithMany(p => p.EmailHeaders)
                    .HasForeignKey(d => d.EmailTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailHeaders_EmailType");
            });

            modelBuilder.Entity<EmailType>(entity =>
            {
                entity.ToTable("EmailType");

                entity.Property(e => e.EmailTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmailTypeID");

                entity.Property(e => e.TypeName).HasMaxLength(20);
            });

            modelBuilder.Entity<EmailVariable>(entity =>
            {
                entity.HasKey(e => e.VariableId);

                entity.Property(e => e.VariableId).HasColumnName("variableId");

                entity.Property(e => e.IsAo).HasColumnName("isAO");

                entity.Property(e => e.IsCl).HasColumnName("isCL");

                entity.Property(e => e.IsCm).HasColumnName("isCM");

                entity.Property(e => e.IsCmletter).HasColumnName("isCMLetter");

                entity.Property(e => e.IsGeneral).HasColumnName("isGeneral");

                entity.Property(e => e.IsIr).HasColumnName("isIR");

                entity.Property(e => e.IsTt).HasColumnName("isTT");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.VarDescription)
                    .HasMaxLength(300)
                    .HasColumnName("varDescription");
            });

            modelBuilder.Entity<EmergencyContact>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Address3).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.EmergencyContactType).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PrimaryEmail).HasMaxLength(320);

                entity.Property(e => e.PrimaryPhone).HasMaxLength(20);

                entity.Property(e => e.Relationship).HasMaxLength(30);

                entity.Property(e => e.SecondaryEmail).HasMaxLength(320);

                entity.Property(e => e.SecondaryPhone).HasMaxLength(20);

                entity.Property(e => e.StateAbr)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Zip).HasMaxLength(18);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmergencyContacts_Country");

                entity.HasOne(d => d.StateAbrNavigation)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.StateAbr)
                    .HasConstraintName("FK_EmergencyContacts_States");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmergencyContacts_Users");
            });

            modelBuilder.Entity<ExportControl>(entity =>
            {
                entity.HasKey(e => e.ExportId);

                entity.ToTable("ExportControl");

                entity.Property(e => e.Acknowledge).HasColumnName("acknowledge");

                entity.Property(e => e.Goods)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("goods")
                    .IsFixedLength();

                entity.HasOne(d => d.TravelAuth)
                    .WithMany(p => p.ExportControls)
                    .HasForeignKey(d => d.TravelAuthId)
                    .HasConstraintName("FK_ExportControl_TravelAuth");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ExportControls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExportControl_Users");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("Flight");

                entity.Property(e => e.Airline).HasMaxLength(50);

                entity.Property(e => e.ArrivalLocation).HasMaxLength(100);

                entity.Property(e => e.DepartureLocation).HasMaxLength(100);

                entity.Property(e => e.FlightNumber).HasMaxLength(75);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.TravelAuth)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.TravelAuthId)
                    .HasConstraintName("FK_Flight_TravelAuth");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Flight_Users");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.InstitutionId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(75);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Genders)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gender_Institution");
            });

            modelBuilder.Entity<Geography>(entity =>
            {
                entity.ToTable("Geography");

                entity.Property(e => e.BuildingCode).HasMaxLength(300);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CleryGeographicLocationId).HasColumnName("CleryGeographicLocationID");

                entity.Property(e => e.ControlledSpace).HasMaxLength(800);

                entity.Property(e => e.CrossStreets).HasMaxLength(400);

                entity.Property(e => e.Distance).HasMaxLength(12);

                entity.Property(e => e.GeoAnalysis).HasMaxLength(35);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.Street).HasMaxLength(400);

                entity.Property(e => e.Zip).HasMaxLength(18);

                entity.HasOne(d => d.CleryCampus)
                    .WithMany(p => p.Geographies)
                    .HasForeignKey(d => d.CleryCampusId)
                    .HasConstraintName("FK_Geography_CleryCampus");

                entity.HasOne(d => d.CleryGeographicLocation)
                    .WithMany(p => p.Geographies)
                    .HasForeignKey(d => d.CleryGeographicLocationId)
                    .HasConstraintName("FK_Geography_CleryGeographicLocation");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Geographies)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_Geography_Country");

                entity.HasOne(d => d.GeographyClassification)
                    .WithMany(p => p.Geographies)
                    .HasForeignKey(d => d.GeographyClassificationId)
                    .HasConstraintName("FK_Geography_GeographyClassification");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Geographies)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_Geography_Institution");
            });

            modelBuilder.Entity<GeographyAgency>(entity =>
            {
                entity.HasKey(e => e.AgencyLinkId);

                entity.Property(e => e.AgencyLinkId).HasColumnName("AgencyLinkID");

                entity.Property(e => e.AgencyId).HasColumnName("AgencyID");

                entity.Property(e => e.GeographyId).HasColumnName("GeographyID");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.GeographyAgencies)
                    .HasForeignKey(d => d.AgencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeographyAgencies_CleryPoliceAddress");

                entity.HasOne(d => d.Geography)
                    .WithMany(p => p.GeographyAgencies)
                    .HasForeignKey(d => d.GeographyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_GeographyAgencies_Geography1");
            });

            modelBuilder.Entity<GeographyClassification>(entity =>
            {
                entity.ToTable("GeographyClassification");

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<GeographyEffectiveDate>(entity =>
            {
                entity.HasKey(e => e.DateId);

                entity.Property(e => e.DateId).HasColumnName("DateID");

                entity.Property(e => e.EndDate).HasColumnName("End Date");

                entity.Property(e => e.GeographyId).HasColumnName("GeographyID");

                entity.Property(e => e.StartDate).HasColumnName("Start Date");

                entity.HasOne(d => d.Geography)
                    .WithMany(p => p.GeographyEffectiveDates)
                    .HasForeignKey(d => d.GeographyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_GeographyEffectiveDates_Geography");
            });

            modelBuilder.Entity<GeographyMap>(entity =>
            {
                entity.HasKey(e => e.GeographyMapsId);

                entity.Property(e => e.MapId).HasMaxLength(15);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(35);

                entity.HasOne(d => d.CleryCampus)
                    .WithMany(p => p.GeographyMaps)
                    .HasForeignKey(d => d.CleryCampusId)
                    .HasConstraintName("FK_GeographyMaps_CleryCampus");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.GeographyMaps)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_GeographyMaps_Institution");

                entity.HasOne(d => d.UploadedFile)
                    .WithMany(p => p.GeographyMaps)
                    .HasForeignKey(d => d.UploadedFileId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_GeographyMaps_UploadedFile");
            });

            modelBuilder.Entity<Immunization>(entity =>
            {
                entity.ToTable("Immunization");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Medical)
                    .WithMany(p => p.Immunizations)
                    .HasForeignKey(d => d.MedicalId)
                    .HasConstraintName("FK_Immunization_Medical");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("Institution");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Address3).HasMaxLength(100);

                entity.Property(e => e.AdminEmail).HasMaxLength(320);

                entity.Property(e => e.AdminFirstname).HasMaxLength(50);

                entity.Property(e => e.AdminLastname).HasMaxLength(50);

                entity.Property(e => e.AdminPhone).HasMaxLength(20);

                entity.Property(e => e.AdminTitle).HasMaxLength(75);

                entity.Property(e => e.AlertsOrganizerEmailAddress).HasMaxLength(320);

                entity.Property(e => e.AlertsOrganizerEmailSender).HasMaxLength(100);

                entity.Property(e => e.BusinessEmail).HasMaxLength(320);

                entity.Property(e => e.BusinessFirstname).HasMaxLength(50);

                entity.Property(e => e.BusinessLastname).HasMaxLength(50);

                entity.Property(e => e.BusinessPhone).HasMaxLength(20);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CleryCsareportLetterClassification).HasColumnName("CleryCSAReportLetterClassification");

                entity.Property(e => e.CleryCsareportLetterDate).HasColumnName("CleryCSAReportLetterDate");

                entity.Property(e => e.CleryCsareportLetterMsg).HasColumnName("CleryCSAReportLetterMsg");

                entity.Property(e => e.CleryCsareportLetterSubject)
                    .HasMaxLength(100)
                    .HasColumnName("CleryCSAReportLetterSubject");

                entity.Property(e => e.CleryEmail).HasMaxLength(320);

                entity.Property(e => e.CleryFirstname).HasMaxLength(50);

                entity.Property(e => e.CleryLastname).HasMaxLength(50);

                entity.Property(e => e.CleryManagerEmailAddress).HasMaxLength(320);

                entity.Property(e => e.CleryManagerEmailSender).HasMaxLength(100);

                entity.Property(e => e.CleryPhone).HasMaxLength(20);

                entity.Property(e => e.ContactNumber).HasMaxLength(15);

                entity.Property(e => e.CorrespondenceEmails).HasMaxLength(320);

                entity.Property(e => e.CorrespondenceSubject).HasMaxLength(100);

                entity.Property(e => e.CsaletterClassification).HasColumnName("CSALetterClassification");

                entity.Property(e => e.CsaletterDate).HasColumnName("CSALetterDate");

                entity.Property(e => e.CsaletterMsg).HasColumnName("CSALetterMsg");

                entity.Property(e => e.CsaletterSubject)
                    .HasMaxLength(100)
                    .HasColumnName("CSALetterSubject");

                entity.Property(e => e.DclmanagerEmailAddress)
                    .HasMaxLength(320)
                    .HasColumnName("DCLManagerEmailAddress");

                entity.Property(e => e.DclmanagerEmailSender)
                    .HasMaxLength(100)
                    .HasColumnName("DCLManagerEmailSender");

                entity.Property(e => e.ExportEmail).HasMaxLength(320);

                entity.Property(e => e.ExportFirstname).HasMaxLength(50);

                entity.Property(e => e.ExportLastname).HasMaxLength(50);

                entity.Property(e => e.ExportPhone).HasMaxLength(20);

                entity.Property(e => e.GeneralEmailAddress).HasMaxLength(320);

                entity.Property(e => e.GeneralEmailSender).HasMaxLength(100);

                entity.Property(e => e.IncidentReporterEmailAddress).HasMaxLength(320);

                entity.Property(e => e.IncidentReporterEmailSender).HasMaxLength(100);

                entity.Property(e => e.MissingStudentLetterSubject).HasMaxLength(100);

                entity.Property(e => e.ModCsas).HasColumnName("ModCSAs");

                entity.Property(e => e.ModDcl).HasColumnName("ModDCL");

                entity.Property(e => e.ModLlea).HasColumnName("ModLLEA");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PostalCode).HasMaxLength(18);

                entity.Property(e => e.RemoteId)
                    .HasMaxLength(32)
                    .HasColumnName("RemoteID")
                    .HasComputedColumnSql("(CONVERT([nvarchar](32),hashbytes('MD5',CONVERT([nvarchar](100),[InstitutionId],(0))),(2)))", true);

                entity.Property(e => e.ResearchEmail).HasMaxLength(320);

                entity.Property(e => e.ResearchFirstname).HasMaxLength(50);

                entity.Property(e => e.ResearchLastname).HasMaxLength(50);

                entity.Property(e => e.ResearchPhone).HasMaxLength(20);

                entity.Property(e => e.StateAbr)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.TimeZone).HasMaxLength(50);

                entity.Property(e => e.TripTrackerEmailAddress).HasMaxLength(320);

                entity.Property(e => e.TripTrackerEmailSender).HasMaxLength(100);

                entity.Property(e => e.WebAddress).HasMaxLength(250);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Institution_Country");

                entity.HasOne(d => d.StateAbrNavigation)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.StateAbr)
                    .HasConstraintName("FK_Institution_States");
            });

            modelBuilder.Entity<InstitutionCollegeSchool>(entity =>
            {
                entity.ToTable("InstitutionCollegeSchool");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.InstitutionCollegeSchools)
                    .HasForeignKey(d => d.CampusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_InstitutionCollegeSchool_Campus");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.InstitutionCollegeSchools)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_InstitutionCollegeSchool_Institution");
            });

            modelBuilder.Entity<InstitutionDepartment>(entity =>
            {
                entity.ToTable("InstitutionDepartment");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.InstitutionCollegeSchool)
                    .WithMany(p => p.InstitutionDepartments)
                    .HasForeignKey(d => d.InstitutionCollegeSchoolId)
                    .HasConstraintName("FK_InstitutionDepartment_InstitutionCollegeSchool");
            });

            modelBuilder.Entity<InstitutionEmail>(entity =>
            {
                entity.ToTable("InstitutionEmail");

                entity.Property(e => e.Subject).HasMaxLength(100);

                entity.HasOne(d => d.EmailHeader)
                    .WithMany(p => p.InstitutionEmails)
                    .HasForeignKey(d => d.EmailHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitutionEmail_EmailHeaders");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.InstitutionEmails)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitutionEmail_Institution");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.ToTable("Insurance");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.PolicyNumber).HasMaxLength(35);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Insurances)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Insurance_Users");
            });

            modelBuilder.Entity<Itinerary>(entity =>
            {
                entity.ToTable("Itinerary");

                entity.Property(e => e.AccAddress).HasMaxLength(100);

                entity.Property(e => e.AccEmail).HasMaxLength(320);

                entity.Property(e => e.AccName).HasMaxLength(100);

                entity.Property(e => e.AccPhone).HasMaxLength(35);

                entity.Property(e => e.AccPostcode).HasMaxLength(50);

                entity.Property(e => e.AccRoomNum).HasMaxLength(100);

                entity.Property(e => e.AccWebsite).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.Companions).HasMaxLength(150);

                entity.Property(e => e.Purpose).HasMaxLength(50);

                entity.Property(e => e.Region).HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Itineraries)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Itinerary_Country");

                entity.HasOne(d => d.TravelAuth)
                    .WithMany(p => p.Itineraries)
                    .HasForeignKey(d => d.TravelAuthId)
                    .HasConstraintName("FK_Itinerary_TravelAuth");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Itineraries)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Itinerary_Users");
            });

            modelBuilder.Entity<Llea>(entity =>
            {
                entity.ToTable("LLEA");

                entity.Property(e => e.Lleaid).HasColumnName("LLEAId");

                entity.Property(e => e.LetterId).HasMaxLength(15);

                entity.Property(e => e.OutreachStatus).HasMaxLength(50);

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.Lleas)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK_LLEA_CleryPoliceAddress");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Lleas)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_LLEA_Institution");
            });

            modelBuilder.Entity<Medical>(entity =>
            {
                entity.ToTable("Medical");

                entity.Property(e => e.BloodType).HasMaxLength(4);

                entity.Property(e => e.Comments).HasMaxLength(400);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Medicals)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Medical_Users");
            });

            modelBuilder.Entity<Medication>(entity =>
            {
                entity.ToTable("Medication");

                entity.Property(e => e.Dosage).HasMaxLength(75);

                entity.Property(e => e.Name).HasMaxLength(75);

                entity.HasOne(d => d.Medical)
                    .WithMany(p => p.Medications)
                    .HasForeignKey(d => d.MedicalId)
                    .HasConstraintName("FK_Medication_Medical");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.MessageId).HasColumnName("messageId");

                entity.Property(e => e.Daterecieved).HasColumnName("daterecieved");

                entity.Property(e => e.HasRead).HasColumnName("hasRead");

                entity.Property(e => e.MessageText).HasColumnName("messageText");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(50)
                    .HasColumnName("messageType");

                entity.Property(e => e.RecepientId).HasColumnName("recepientId");

                entity.Property(e => e.SenderId).HasColumnName("senderId");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .HasColumnName("subject");

                entity.HasOne(d => d.Recepient)
                    .WithMany(p => p.MessageRecepients)
                    .HasForeignKey(d => d.RecepientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_Reciever");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.MessageSenders)
                    .HasForeignKey(d => d.SenderId)
                    .HasConstraintName("FK_Message_Sender");
            });

            modelBuilder.Entity<MissingContact>(entity =>
            {
                entity.ToTable("MissingContact");

                entity.Property(e => e.Email).HasMaxLength(320);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PrimaryContactAddress).HasMaxLength(100);

                entity.Property(e => e.PrimaryContactEmail).HasMaxLength(320);

                entity.Property(e => e.PrimaryContactName).HasMaxLength(100);

                entity.Property(e => e.PrimaryContactPhone1).HasMaxLength(20);

                entity.Property(e => e.PrimaryContactPhone2).HasMaxLength(20);

                entity.Property(e => e.PrimaryContactRelationship).HasMaxLength(50);

                entity.Property(e => e.SecondaryContactAddress).HasMaxLength(100);

                entity.Property(e => e.SecondaryContactEmail).HasMaxLength(320);

                entity.Property(e => e.SecondaryContactName).HasMaxLength(100);

                entity.Property(e => e.SecondaryContactPhone1).HasMaxLength(20);

                entity.Property(e => e.SecondaryContactPhone2).HasMaxLength(20);

                entity.Property(e => e.SecondaryContactRelationship).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasMaxLength(30);

                entity.Property(e => e.ThirdContactAddress).HasMaxLength(100);

                entity.Property(e => e.ThirdContactEmail).HasMaxLength(320);

                entity.Property(e => e.ThirdContactName).HasMaxLength(100);

                entity.Property(e => e.ThirdContactPhone1).HasMaxLength(20);

                entity.Property(e => e.ThirdContactPhone2).HasMaxLength(20);

                entity.Property(e => e.ThirdContactRelationship).HasMaxLength(50);

                entity.Property(e => e.WhoSubmitted).HasMaxLength(100);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.MissingContacts)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_MissingContact_Institution");
            });

            modelBuilder.Entity<MissingOutreach>(entity =>
            {
                entity.ToTable("MissingOutreach");

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.HowContacted).HasMaxLength(100);

                entity.Property(e => e.WhoContacted).HasMaxLength(100);

                entity.HasOne(d => d.MissingReport)
                    .WithMany(p => p.MissingOutreaches)
                    .HasForeignKey(d => d.MissingReportId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MissingOutreach_MissingReport");
            });

            modelBuilder.Entity<MissingReport>(entity =>
            {
                entity.ToTable("MissingReport");

                entity.Property(e => e.AdminIncidentId).HasMaxLength(15);

                entity.Property(e => e.AdminLleaid)
                    .HasMaxLength(15)
                    .HasColumnName("AdminLLEAId");

                entity.Property(e => e.AdminPubSafetyId).HasMaxLength(15);

                entity.Property(e => e.AdminReportId).HasMaxLength(15);

                entity.Property(e => e.AdminStatus).HasMaxLength(7);

                entity.Property(e => e.DeterminationStatus).HasMaxLength(25);

                entity.Property(e => e.DeterminationWho).HasMaxLength(100);

                entity.Property(e => e.ReferralHow).HasMaxLength(100);

                entity.Property(e => e.ReportToWhom).HasMaxLength(100);

                entity.Property(e => e.ReportWhere).HasMaxLength(100);

                entity.Property(e => e.ReportWho).HasMaxLength(100);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.MissingReports)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_MissingReport_Institution");

                entity.HasOne(d => d.MissingContact)
                    .WithMany(p => p.MissingReports)
                    .HasForeignKey(d => d.MissingContactId)
                    .HasConstraintName("FK_MissingReport_MissingContact");
            });

            modelBuilder.Entity<MissingReportAgency>(entity =>
            {
                entity.HasKey(e => e.MissingReportLinkId);

                entity.ToTable("MissingReportAgency");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.MissingReportAgencies)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK_MissingReportAgency_CleryPoliceAddress");

                entity.HasOne(d => d.MissingReport)
                    .WithMany(p => p.MissingReportAgencies)
                    .HasForeignKey(d => d.MissingReportId)
                    .HasConstraintName("FK_MissingReportAgency_MissingReport");
            });

            modelBuilder.Entity<MultipleQuestion>(entity =>
            {
                entity.ToTable("MultipleQuestion");

                entity.Property(e => e.Question).HasMaxLength(400);

                entity.HasOne(d => d.Multiple)
                    .WithMany(p => p.MultipleQuestions)
                    .HasForeignKey(d => d.MultipleId)
                    .HasConstraintName("FK_MultipleQuestion_QuizMultiple");
            });

            modelBuilder.Entity<Passport>(entity =>
            {
                entity.Property(e => e.Emergency).HasMaxLength(35);

                entity.Property(e => e.PassportNumber).HasMaxLength(35);

                entity.HasOne(d => d.CitizenshipNavigation)
                    .WithMany(p => p.PassportCitizenshipNavigations)
                    .HasForeignKey(d => d.Citizenship)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Passports_Citizenship");

                entity.HasOne(d => d.IssuedByNavigation)
                    .WithMany(p => p.PassportIssuedByNavigations)
                    .HasForeignKey(d => d.IssuedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Passports_Issuer");

                entity.HasOne(d => d.UploadedFile)
                    .WithMany(p => p.Passports)
                    .HasForeignKey(d => d.UploadedFileId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Passports_UploadedFile");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Passports)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Passports_Users");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ReadableName).HasMaxLength(50);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Permission_PermissionGroups");
            });

            modelBuilder.Entity<PermissionGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("GroupID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Piralert>(entity =>
            {
                entity.ToTable("PIRAlerts");

                entity.Property(e => e.PiralertId).HasColumnName("PIRAlertId");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Piralerts)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PIRAlerts_Institution");
            });

            modelBuilder.Entity<PreExisiting>(entity =>
            {
                entity.ToTable("PreExisiting");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Medical)
                    .WithMany(p => p.PreExisitings)
                    .HasForeignKey(d => d.MedicalId)
                    .HasConstraintName("FK_PreExisiting_Medical");
            });

            modelBuilder.Entity<QuizAnswer>(entity =>
            {
                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.HasOne(d => d.Multiple)
                    .WithMany(p => p.QuizAnswers)
                    .HasForeignKey(d => d.MultipleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_QuizAnswers_QuizMultiple");

                entity.HasOne(d => d.MultipleQuestion)
                    .WithMany(p => p.QuizAnswers)
                    .HasForeignKey(d => d.MultipleQuestionId)
                    .HasConstraintName("FK_QuizAnswers_MultipleQuestion");

                entity.HasOne(d => d.QuizTrueFalse)
                    .WithMany(p => p.QuizAnswers)
                    .HasForeignKey(d => d.QuizTrueFalseId)
                    .HasConstraintName("FK_QuizAnswers_QuizTrueFalse");
            });

            modelBuilder.Entity<QuizMultiple>(entity =>
            {
                entity.HasKey(e => e.MultipleId);

                entity.ToTable("QuizMultiple");

                entity.Property(e => e.MultipleName).HasMaxLength(100);

                entity.Property(e => e.Question).HasMaxLength(400);

                entity.HasOne(d => d.CorrectAnswerNavigation)
                    .WithMany(p => p.QuizMultiples)
                    .HasForeignKey(d => d.CorrectAnswer)
                    .HasConstraintName("FK_QuizMultiple_MultipleQuestion");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.QuizMultiples)
                    .HasForeignKey(d => d.QuizId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_QuizMultiple_TrainingQuiz1");
            });

            modelBuilder.Entity<QuizTrueFalse>(entity =>
            {
                entity.ToTable("QuizTrueFalse");

                entity.Property(e => e.IsTrue).HasColumnName("isTrue");

                entity.Property(e => e.Question).HasMaxLength(400);

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.QuizTrueFalses)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("FK_QuizTrueFalse_TrainingQuiz");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.ToTable("Rental");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Address3).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(320)
                    .HasColumnName("email");

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Website)
                    .HasMaxLength(250)
                    .HasColumnName("website");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Rentals)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental_Country");

                entity.HasOne(d => d.TravelAuth)
                    .WithMany(p => p.Rentals)
                    .HasForeignKey(d => d.TravelAuthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental_TravelAuth");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Rentals)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Rental_Users");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.AssociatedDcl).HasColumnName("AssociatedDCL");

                entity.Property(e => e.CaseNumber).HasMaxLength(30);

                entity.Property(e => e.ClassificationList).HasMaxLength(50);

                entity.Property(e => e.CleryReview).HasMaxLength(20);

                entity.Property(e => e.ConductReportId).HasMaxLength(50);

                entity.Property(e => e.ContactEmail).HasMaxLength(320);

                entity.Property(e => e.ContactFn)
                    .HasMaxLength(50)
                    .HasColumnName("ContactFN");

                entity.Property(e => e.ContactLn)
                    .HasMaxLength(50)
                    .HasColumnName("ContactLN");

                entity.Property(e => e.ContactPhone).HasMaxLength(20);

                entity.Property(e => e.Dcldate).HasColumnName("DCLDate");

                entity.Property(e => e.Dclnote).HasColumnName("DCLNote");

                entity.Property(e => e.Dclrequired)
                    .HasMaxLength(15)
                    .HasColumnName("DCLRequired");

                entity.Property(e => e.DispositionList).HasMaxLength(100);

                entity.Property(e => e.FireCause).HasMaxLength(50);

                entity.Property(e => e.FireCauseIntentional).HasMaxLength(50);

                entity.Property(e => e.FireCauseUnintentional).HasMaxLength(50);

                entity.Property(e => e.FireDamage).HasMaxLength(200);

                entity.Property(e => e.FireNature).HasMaxLength(200);

                entity.Property(e => e.HowLearnAbout).HasMaxLength(400);

                entity.Property(e => e.LocalLawId).HasMaxLength(25);

                entity.Property(e => e.LocationSpecific).HasMaxLength(100);

                entity.Property(e => e.PreviouslyReported).HasMaxLength(35);

                entity.Property(e => e.PublicReportType).HasMaxLength(35);

                entity.Property(e => e.RelatedLleaid).HasColumnName("RelatedLLEAid");

                entity.Property(e => e.RelatedReports).HasMaxLength(100);

                entity.Property(e => e.SafetyReportId).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(7);

                entity.Property(e => e.TitleIxid)
                    .HasMaxLength(15)
                    .HasColumnName("TitleIXId");

                entity.Property(e => e.TwassessmentId).HasColumnName("TWAssessmentId");

                entity.Property(e => e.Twnotes).HasColumnName("TWnotes");

                entity.Property(e => e.TwreviewDate).HasColumnName("TWReviewDate");

                entity.Property(e => e.WhoReportedCampusId).HasMaxLength(35);

                entity.Property(e => e.WhoReportedEmail).HasMaxLength(320);

                entity.Property(e => e.WhoReportedFn)
                    .HasMaxLength(50)
                    .HasColumnName("WhoReportedFN");

                entity.Property(e => e.WhoReportedLn)
                    .HasMaxLength(50)
                    .HasColumnName("WhoReportedLN");

                entity.Property(e => e.WhoReportedPhone).HasMaxLength(20);

                entity.Property(e => e.WhoReportedType).HasMaxLength(35);

                entity.Property(e => e.Witnesses).HasMaxLength(200);

                entity.HasOne(d => d.AssociatedDclNavigation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.AssociatedDcl)
                    .HasConstraintName("FK_Reports_DailyCrimeLog");

                entity.HasOne(d => d.Geography)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.GeographyId)
                    .HasConstraintName("FK_Reports_Geography");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Reports_Institution");

                entity.HasOne(d => d.RelatedLlea)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.RelatedLleaid)
                    .HasConstraintName("FK_Reports_LLEA");

                entity.HasOne(d => d.RelatedTripNavigation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.RelatedTrip)
                    .HasConstraintName("FK_Reports_TravelAuth");

                entity.HasOne(d => d.ReportType)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.ReportTypeId)
                    .HasConstraintName("FK_Reports_ReportType");

                entity.HasOne(d => d.Twassessment)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.TwassessmentId)
                    .HasConstraintName("FK_Reports_ReportsTWAssessment");
            });

            modelBuilder.Entity<ReportClery>(entity =>
            {
                entity.ToTable("ReportClery");

                entity.Property(e => e.CleryRationale).HasMaxLength(500);

                entity.Property(e => e.Vawaid).HasColumnName("VAWAid");

                entity.HasOne(d => d.Arrests)
                    .WithMany(p => p.ReportCleries)
                    .HasForeignKey(d => d.ArrestsId)
                    .HasConstraintName("FK_ReportClery_CleryArrests");

                entity.HasOne(d => d.CleryClassification)
                    .WithMany(p => p.ReportCleries)
                    .HasForeignKey(d => d.CleryClassificationId)
                    .HasConstraintName("FK_ReportClery_CleryClassification");

                entity.HasOne(d => d.HateCrimeCategory)
                    .WithMany(p => p.ReportCleries)
                    .HasForeignKey(d => d.HateCrimeCategoryId)
                    .HasConstraintName("FK_ReportClery_CleryCategory");

                entity.HasOne(d => d.HateCrime)
                    .WithMany(p => p.ReportCleries)
                    .HasForeignKey(d => d.HateCrimeId)
                    .HasConstraintName("FK_ReportClery_CleryCause");

                entity.HasOne(d => d.ReportCleryType)
                    .WithMany(p => p.ReportCleries)
                    .HasForeignKey(d => d.ReportCleryTypeId)
                    .HasConstraintName("FK_ReportClery_ReportCleryType");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportCleries)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportClery_Reports");

                entity.HasOne(d => d.Vawa)
                    .WithMany(p => p.ReportCleries)
                    .HasForeignKey(d => d.Vawaid)
                    .HasConstraintName("FK_ReportClery_CleryVAWA");
            });

            modelBuilder.Entity<ReportCleryType>(entity =>
            {
                entity.ToTable("ReportCleryType");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportNote>(entity =>
            {
                entity.ToTable("ReportNote");

                entity.Property(e => e.Lleaid).HasColumnName("LLEAId");

                entity.Property(e => e.Note).HasColumnType("text");

                entity.HasOne(d => d.AuditReconciliation)
                    .WithMany(p => p.ReportNotes)
                    .HasForeignKey(d => d.AuditReconciliationId)
                    .HasConstraintName("FK_ReportNote_AuditReconciliation");

                entity.HasOne(d => d.Llea)
                    .WithMany(p => p.ReportNotes)
                    .HasForeignKey(d => d.Lleaid)
                    .HasConstraintName("FK_ReportNote_LLEA");

                entity.HasOne(d => d.Missing)
                    .WithMany(p => p.ReportNotes)
                    .HasForeignKey(d => d.MissingId)
                    .HasConstraintName("FK_ReportNote_MissingReport");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportNotes)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK_ReportNote_Reports");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportNotes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportNote_Users");
            });

            modelBuilder.Entity<ReportType>(entity =>
            {
                entity.ToTable("ReportType");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<ReportsAlert>(entity =>
            {
                entity.ToTable("ReportsAlert");

                entity.Property(e => e.Aoid).HasColumnName("AOId");

                entity.HasOne(d => d.Ao)
                    .WithMany(p => p.ReportsAlerts)
                    .HasForeignKey(d => d.Aoid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportsAlert_AlertsOrganizer");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportsAlerts)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportsAlert_Reports");
            });

            modelBuilder.Entity<ReportsKnown>(entity =>
            {
                entity.HasKey(e => e.KnownId);

                entity.ToTable("ReportsKnown");

                entity.Property(e => e.CampusId).HasMaxLength(25);

                entity.Property(e => e.Email).HasMaxLength(320);

                entity.Property(e => e.Fn)
                    .HasMaxLength(50)
                    .HasColumnName("FN");

                entity.Property(e => e.KnownType).HasMaxLength(20);

                entity.Property(e => e.Ln)
                    .HasMaxLength(50)
                    .HasColumnName("LN");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportsKnowns)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportsKnown_Reports");
            });

            modelBuilder.Entity<ReportsTwassessment>(entity =>
            {
                entity.ToTable("ReportsTWAssessment");

                entity.Property(e => e.ReportsTwassessmentId).HasColumnName("ReportsTWAssessmentId");

                entity.Property(e => e.DateReviewed).HasColumnName("Date Reviewed");

                entity.Property(e => e.EndateReviewed).HasColumnName("ENDateReviewed");

                entity.Property(e => e.Ennotes).HasColumnName("ENNotes");

                entity.Property(e => e.Enrequired)
                    .HasMaxLength(5)
                    .HasColumnName("ENRequired");

                entity.Property(e => e.IsInfoWithheld).HasMaxLength(5);

                entity.Property(e => e.TwnotSupporting)
                    .HasMaxLength(100)
                    .HasColumnName("TWNotSupporting");

                entity.Property(e => e.Twrequired)
                    .HasMaxLength(3)
                    .HasColumnName("TWRequired");

                entity.Property(e => e.Twsupporting)
                    .HasMaxLength(100)
                    .HasColumnName("TWSupporting");

                entity.HasOne(d => d.Reviewer)
                    .WithMany(p => p.ReportsTwassessments)
                    .HasForeignKey(d => d.ReviewerId)
                    .HasConstraintName("FK_ReportsTWAssessment_Users");
            });

            modelBuilder.Entity<ReportsTwassessmentReviewer>(entity =>
            {
                entity.ToTable("ReportsTWAssessmentReviewer");

                entity.Property(e => e.ReportsTwassessmentReviewerId).HasColumnName("ReportsTWAssessmentReviewerID");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.ReviewerId).HasColumnName("ReviewerID");

                entity.HasOne(d => d.Assessment)
                    .WithMany(p => p.ReportsTwassessmentReviewers)
                    .HasForeignKey(d => d.AssessmentId)
                    .HasConstraintName("FK_ReportsTWAssessmentReviewer_ReportsTWAssessment");

                entity.HasOne(d => d.Reviewer)
                    .WithMany(p => p.ReportsTwassessmentReviewers)
                    .HasForeignKey(d => d.ReviewerId)
                    .HasConstraintName("FK_ReportsTWAssessmentReviewer_Users");
            });

            modelBuilder.Entity<ReportsUnknown>(entity =>
            {
                entity.HasKey(e => e.UnknownId);

                entity.ToTable("ReportsUnknown");

                entity.Property(e => e.Age).HasMaxLength(3);

                entity.Property(e => e.Gender).HasMaxLength(8);

                entity.Property(e => e.Height).HasMaxLength(8);

                entity.Property(e => e.Race).HasMaxLength(50);

                entity.Property(e => e.UnknownType).HasMaxLength(5);

                entity.Property(e => e.Weight).HasMaxLength(6);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportsUnknowns)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK_ReportsUnknown_Reports");
            });

            modelBuilder.Entity<Research>(entity =>
            {
                entity.ToTable("Research");

                entity.Property(e => e.Acknowledge).HasColumnName("acknowledge");

                entity.Property(e => e.Research1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("research")
                    .IsFixedLength();

                entity.HasOne(d => d.TravelAuth)
                    .WithMany(p => p.Researches)
                    .HasForeignKey(d => d.TravelAuthId)
                    .HasConstraintName("FK_Research_Research");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Researches)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Research_Users");
            });

            modelBuilder.Entity<RiskCountry>(entity =>
            {
                entity.ToTable("RiskCountry");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.RiskCountries)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RiskCountry_Country");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.RiskCountries)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RiskCountry_Institution");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("Setting");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Settings)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_Setting_Institution");
            });

            modelBuilder.Entity<SiteContent>(entity =>
            {
                entity.HasKey(e => e.ContentId);

                entity.ToTable("SiteContent");

                entity.Property(e => e.InstitutionId).HasColumnName("institutionId");

                entity.Property(e => e.Name).HasMaxLength(75);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.SiteContents)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_SiteContent_Institution");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.StateAbr);

                entity.Property(e => e.StateAbr)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TrainingCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("TrainingCourse");

                entity.Property(e => e.Name).HasMaxLength(75);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TrainingCourses)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_TrainingCourse_Users");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.TrainingCourses)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingCourse_Institution");
            });

            modelBuilder.Entity<TrainingLesson>(entity =>
            {
                entity.HasKey(e => e.LessonId);

                entity.ToTable("TrainingLesson");

                entity.Property(e => e.ContentType).HasMaxLength(20);

                entity.Property(e => e.LessonName).HasMaxLength(75);

                entity.Property(e => e.VideoId).HasMaxLength(20);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TrainingLessons)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_TrainingLesson_TrainingCourse");
            });

            modelBuilder.Entity<TrainingQuiz>(entity =>
            {
                entity.HasKey(e => e.QuizId);

                entity.ToTable("TrainingQuiz");

                entity.Property(e => e.QuizName).HasMaxLength(150);

                entity.Property(e => e.QuizType).HasMaxLength(15);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TrainingQuizzes)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_TrainingQuiz_TrainingCourse");
            });

            modelBuilder.Entity<TravelAuth>(entity =>
            {
                entity.ToTable("TravelAuth");

                entity.Property(e => e.ApprovalEmail).HasMaxLength(320);

                entity.Property(e => e.ApprovalIndividual).HasMaxLength(100);

                entity.Property(e => e.ApprovalPhone).HasMaxLength(20);

                entity.Property(e => e.DepartmentChair).HasMaxLength(100);

                entity.Property(e => e.FacultyAdvisor).HasMaxLength(100);

                entity.Property(e => e.FundingAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FundingSchool).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Onedayemail).HasColumnName("onedayemail");

                entity.Property(e => e.Sevendayemail).HasColumnName("sevendayemail");

                entity.Property(e => e.Solo).HasColumnName("solo");

                entity.Property(e => e.Status).HasMaxLength(25);

                entity.Property(e => e.Twodayreturnemail).HasColumnName("twodayreturnemail");

                entity.Property(e => e.UniqueId).HasMaxLength(25);

                entity.HasOne(d => d.ContactSubUnit)
                    .WithMany(p => p.TravelAuths)
                    .HasForeignKey(d => d.ContactSubUnitId)
                    .HasConstraintName("FK_TravelAuth_InstitutionDepartment");

                entity.HasOne(d => d.ContactUnit)
                    .WithMany(p => p.TravelAuths)
                    .HasForeignKey(d => d.ContactUnitId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TravelAuth_InstitutionCollegeSchool");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TravelAuths)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TravelAuth_Users");
            });

            modelBuilder.Entity<Traveller>(entity =>
            {
                entity.ToTable("Traveller");

                entity.Property(e => e.Acknowledge).HasColumnName("acknowledge");

                entity.Property(e => e.AcknowledgeDate).HasColumnName("acknowledgeDate");

                entity.Property(e => e.Goods)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("goods")
                    .IsFixedLength();

                entity.Property(e => e.GoodsDate).HasColumnName("goodsDate");

                entity.Property(e => e.Research)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("research")
                    .IsFixedLength();

                entity.Property(e => e.Researchacknowledge).HasColumnName("researchacknowledge");

                entity.Property(e => e.Signature).HasColumnName("signature");

                entity.Property(e => e.SignatureDate).HasColumnName("signatureDate");

                entity.Property(e => e.WaviersAccepted).HasColumnName("waviersAccepted");

                entity.Property(e => e.WaviersDate).HasColumnName("waviersDate");

                entity.HasOne(d => d.TravelAuth)
                    .WithMany(p => p.Travellers)
                    .HasForeignKey(d => d.TravelAuthId)
                    .HasConstraintName("FK_Traveller_TravelAuth");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Travellers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traveller_Users");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Travellers)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traveller_UserType");
            });

            modelBuilder.Entity<TwilioCredential>(entity =>
            {
                entity.HasKey(e => e.TwilioCredentialsId)
                    .HasName("PK__TwilioCr__056A6A83CFDF7F52");

                entity.HasIndex(e => e.InstitutionId, "UQ__TwilioCr__8DF6B6ACDD98EA7E")
                    .IsUnique();

                entity.Property(e => e.AccountSid)
                    .HasMaxLength(40)
                    .HasColumnName("AccountSID");

                entity.Property(e => e.AuthToken).HasMaxLength(40);

                entity.Property(e => e.PhoneNumber).HasMaxLength(13);

                entity.HasOne(d => d.Institution)
                    .WithOne(p => p.TwilioCredential)
                    .HasForeignKey<TwilioCredential>(d => d.InstitutionId)
                    .HasConstraintName("FK_TwilioCredentials_Institution");
            });

            modelBuilder.Entity<UploadedFile>(entity =>
            {
                entity.ToTable("UploadedFile");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Lleaid).HasColumnName("LLEAId");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Section).HasMaxLength(25);

                entity.Property(e => e.Uri).HasMaxLength(200);

                entity.HasOne(d => d.AlertsOrganizer)
                    .WithMany(p => p.UploadedFiles)
                    .HasForeignKey(d => d.AlertsOrganizerId)
                    .HasConstraintName("FK_UploadedFile_AlertsOrganizer");

                entity.HasOne(d => d.DailyCrimeLog)
                    .WithMany(p => p.UploadedFiles)
                    .HasForeignKey(d => d.DailyCrimeLogId)
                    .HasConstraintName("FK_File_DailyCrimeLog");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.UploadedFiles)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_UploadedFile_Institution");

                entity.HasOne(d => d.Llea)
                    .WithMany(p => p.UploadedFiles)
                    .HasForeignKey(d => d.Lleaid)
                    .HasConstraintName("FK_File_LLEA");

                entity.HasOne(d => d.Missing)
                    .WithMany(p => p.UploadedFiles)
                    .HasForeignKey(d => d.MissingId)
                    .HasConstraintName("FK_UploadedFile_MissingReport");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.UploadedFiles)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK_File_Reports");

                entity.HasOne(d => d.TrainingLesson)
                    .WithMany(p => p.UploadedFiles)
                    .HasForeignKey(d => d.TrainingLessonId)
                    .HasConstraintName("FK_UploadedFile_TrainingLesson");

                entity.HasOne(d => d.Traveller)
                    .WithMany(p => p.UploadedFiles)
                    .HasForeignKey(d => d.TravellerId)
                    .HasConstraintName("FK_File_Travellers");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.UploadedFiles)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_UploadedFile_UserType");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.PrimaryEmail, "pinky")
                    .IsUnique();

                entity.Property(e => e.BusEmail).HasMaxLength(320);

                entity.Property(e => e.BusPhone).HasMaxLength(20);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.EmergencyContactType).HasMaxLength(25);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MobilePhone).HasMaxLength(20);

                entity.Property(e => e.PrimaryEmail).HasMaxLength(320);

                entity.Property(e => e.PrimaryPhone).HasMaxLength(20);

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.SecondaryEmail).HasMaxLength(320);

                entity.Property(e => e.SecondaryPhone).HasMaxLength(20);

                entity.Property(e => e.Suffix).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UniversityId).HasMaxLength(25);

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CampusId)
                    .HasConstraintName("FK_Users_Campus");

                entity.HasOne(d => d.DefaultRole)
                    .WithMany(p => p.UserDefaultRoles)
                    .HasForeignKey(d => d.DefaultRoleId)
                    .HasConstraintName("FK_Users_UserType1");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Users_Gender");

                entity.HasOne(d => d.InstitutionDepartment)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.InstitutionDepartmentId)
                    .HasConstraintName("FK_Users_InstitutionDepartment");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Institution");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.UserUserTypes)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_UserType");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.UserTypes)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK_UserType_Institution");
            });

            modelBuilder.Entity<UserTypePermission>(entity =>
            {
                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserTypePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTypePermissions_Permission");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.UserTypePermissions)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_UserTypePermissions_UserType");
            });

            modelBuilder.Entity<VRptItinerary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRptItinerary");

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.TotalTravellers).HasColumnName("totalTravellers");

                entity.Property(e => e.TripStatus)
                    .HasMaxLength(25)
                    .HasColumnName("tripStatus");
            });

            modelBuilder.Entity<VRptParticipant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRptParticipants");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(75)
                    .HasColumnName("gender");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MobilePhone).HasMaxLength(20);

                entity.Property(e => e.PassportNumber)
                    .HasMaxLength(35)
                    .HasColumnName("passportNumber");

                entity.Property(e => e.PrimaryEmail).HasMaxLength(320);

                entity.Property(e => e.Row).HasColumnName("Row#");

                entity.Property(e => e.TripName).HasMaxLength(113);
            });

            modelBuilder.Entity<VRptStep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRptSTEP");

                entity.Property(e => e.Dob).HasColumnName("dob");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.PassportNumber)
                    .HasMaxLength(35)
                    .HasColumnName("passportNumber");

                entity.Property(e => e.PrimaryEmail).HasMaxLength(320);

                entity.Property(e => e.PrimaryPhone).HasMaxLength(20);

                entity.Property(e => e.TripName).HasMaxLength(113);
            });

            modelBuilder.Entity<VRptTraveler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRptTravelers");

                entity.Property(e => e.CollegeName).HasMaxLength(100);

                entity.Property(e => e.DepartmentName).HasMaxLength(100);

                entity.Property(e => e.Fullname)
                    .HasMaxLength(151)
                    .HasColumnName("fullname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(75)
                    .HasColumnName("gender");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Role).HasMaxLength(50);
            });

            modelBuilder.Entity<VRptTrip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRptTrip");

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Region).HasMaxLength(50);

                entity.Property(e => e.TotalTravellers).HasColumnName("totalTravellers");

                entity.Property(e => e.TripStatus)
                    .HasMaxLength(25)
                    .HasColumnName("tripStatus");
            });

            modelBuilder.Entity<VTripInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTripInfo");

                entity.Property(e => e.ApprovalIndividual).HasMaxLength(100);

                entity.Property(e => e.ApprovalPhone).HasMaxLength(20);

                entity.Property(e => e.Countries).HasColumnName("countries");

                entity.Property(e => e.DepartmentChair).HasMaxLength(100);

                entity.Property(e => e.FacultyAdvisor).HasMaxLength(100);

                entity.Property(e => e.FundingAmount).HasColumnType("money");

                entity.Property(e => e.FundingSchool).HasMaxLength(100);

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Onedayemail).HasColumnName("onedayemail");

                entity.Property(e => e.Sevendayemail).HasColumnName("sevendayemail");

                entity.Property(e => e.TripStatus)
                    .HasMaxLength(25)
                    .HasColumnName("tripStatus");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
