using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Models;
using AccommoLinkResidenceAssistance.Models.SystemUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccommoLinkResidenceAssistance.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        if (builder == null)
            throw new ArgumentNullException("modelBuilder");

        builder.Entity<UniversityCampuses>().HasKey(x => new { x.UniversityId, x.CampusId });
        builder.Entity<UniversityCampuses>().
            HasOne(x => x.University).WithMany(x => x.UniversityCampuses).HasForeignKey(y => y.UniversityId);
        builder.Entity<UniversityCampuses>().
            HasOne(x => x.Campus).WithMany(x => x.UniversityCampuses).HasForeignKey(y => y.CampusId);

        // for the other conventions, we do a metadata model loop
        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            // equivalent of modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            entityType.SetTableName(entityType.DisplayName());

            // equivalent of modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            entityType.GetForeignKeys()
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                .ToList()
                .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
        }

        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.Entity<ApplicationUser>().ToTable("tblUsers");
        builder.Entity<IdentityRole>().ToTable("tblRoles");
        builder.Entity<IdentityUserRole<string>>().ToTable("tblUserRoles");
        builder.Entity<IdentityUserClaim<string>>().ToTable("tblUserClaims");
        builder.Entity<IdentityUserLogin<string>>().ToTable("tblUserLogins");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("tblRoleClaims");
        builder.Entity<IdentityUserToken<string>>().ToTable("tblUserTokens");
    }
    public DbSet<UniversityDetails> tblUniversityDetails { get; set; }
    public DbSet<Campuses> tblCampuses { get; set; }
    public DbSet<UniversityCampuses> tblUniversityCampuses { get; set; }
    public DbSet<LandlordDetails> tblLandlordDetails { get; set; }
    public DbSet<StudentDetails> tblStudentDetails { get; set; }
    public DbSet<Residences> tblResidences { get; set; }
    public DbSet<ReportResidence> tblReportResidences { get; set; }
}