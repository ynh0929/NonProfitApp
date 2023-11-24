using Microsoft.AspNetCore.Http;
namespace NonProfitLibrary.Data;

public class AppDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
     private readonly IHttpContextAccessor _httpContextAccessor;

        public AppDbContext(DbContextOptions<AppDbContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public DbSet<ContactList> ContactLists => Set<ContactList>();
        public DbSet<TransactionType> TransactionTypes => Set<TransactionType>();
        public DbSet<PaymentMethod> PaymentMethods => Set<PaymentMethod>();
        public DbSet<Donation> Donations => Set<Donation>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure ContactList-Donation relationship
            modelBuilder.Entity<Donation>()
                .HasOne<ContactList>()
                .WithMany()
                .HasForeignKey(d => d.AccountNo);

            // Configure TransactionType-Donation relationship
            modelBuilder.Entity<Donation>()
                .HasOne<TransactionType>()
                .WithMany()
                .HasForeignKey(d => d.TransactionTypeId);

            // Configure PaymentMethod-Donation relationship
            modelBuilder.Entity<Donation>()
                .HasOne<PaymentMethod>()
                .WithMany()
                .HasForeignKey(d => d.PaymentMethodId);

            // Seed data
            modelBuilder.Entity<ContactList>().HasData(GetContactLists());
            modelBuilder.Entity<TransactionType>().HasData(GetTransactionTypes());
            modelBuilder.Entity<PaymentMethod>().HasData(GetPaymentMethods());
            modelBuilder.Entity<Donation>().HasData(GetDonations());

            modelBuilder.Seed();

            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityUserToken<string>>().HasKey(x => x.UserId);
        }

        public override int SaveChanges()
        {
            UpdateTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateTimestamps();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void UpdateTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var username = _httpContextAccessor.HttpContext?.User?.Identity?.Name ?? "System";

            foreach (var entityEntry in entities)
            {
                var now = DateTime.UtcNow;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).Created = now;
                    ((BaseEntity)entityEntry.Entity).CreatedBy = username;
                }

                ((BaseEntity)entityEntry.Entity).Modified = now;
                ((BaseEntity)entityEntry.Entity).ModifiedBy = username;
            }
        }

         private static IEnumerable<ContactList> GetContactLists() 
     {
        string[] p = { Directory.GetCurrentDirectory(), "wwwroot", "ContactList.csv" };
        var csvFilePath = Path.Combine(p);

        var config = new CsvConfiguration(CultureInfo.InvariantCulture) {
            HeaderValidated = null,
            MissingFieldFound = null,
            PrepareHeaderForMatch = args => args.Header.ToLower(),
        };

        var data = new List<ContactList>().AsEnumerable();
        using (var reader = new StreamReader(csvFilePath)) {
            using (var csvReader = new CsvReader(reader, config)) {
                data = csvReader.GetRecords<ContactList>().Select(d => 
                {
                    d.Created = DateTime.UtcNow;
                    d.Modified = DateTime.UtcNow;
                    d.CreatedBy = "System"; 
                    d.ModifiedBy = "System"; 
                    return d;
                }).ToList();
            }
        }
   
        return data;
     }
    private static IEnumerable<TransactionType> GetTransactionTypes() 
     {
        string[] p = { Directory.GetCurrentDirectory(), "wwwroot", "TransactionType.csv" };
        var csvFilePath = Path.Combine(p);

        var config = new CsvConfiguration(CultureInfo.InvariantCulture) {
            HeaderValidated = null,
            MissingFieldFound = null,
            PrepareHeaderForMatch = args => args.Header.ToLower(),
        };

        var data = new List<TransactionType>().AsEnumerable();
        using (var reader = new StreamReader(csvFilePath)) {
            using (var csvReader = new CsvReader(reader, config)) {
                 data = csvReader.GetRecords<TransactionType>().Select(d => 
                {
                    d.Created = DateTime.UtcNow;
                    d.Modified = DateTime.UtcNow;
                    d.CreatedBy = "System"; 
                    d.ModifiedBy = "System"; 
                    return d;
                }).ToList();
            }
        }
        return data;
     }
     private static IEnumerable<PaymentMethod> GetPaymentMethods() 
     {
        string[] p = { Directory.GetCurrentDirectory(), "wwwroot", "PaymentMethod.csv" };
        var csvFilePath = Path.Combine(p);

        var config = new CsvConfiguration(CultureInfo.InvariantCulture) {
            HeaderValidated = null,
            MissingFieldFound = null,
            PrepareHeaderForMatch = args => args.Header.ToLower(),
        };

        var data = new List<PaymentMethod>().AsEnumerable();
        using (var reader = new StreamReader(csvFilePath)) {
            using (var csvReader = new CsvReader(reader, config)) {
                 data = csvReader.GetRecords<PaymentMethod>().Select(d => 
                {
                    d.Created = DateTime.UtcNow;
                    d.Modified = DateTime.UtcNow;
                    d.CreatedBy = "System"; 
                    d.ModifiedBy = "System"; 
                    return d;
                }).ToList();
            }
        }

        
        return data;
     }

    private static IEnumerable<Donation> GetDonations() 
     {
        string[] p = { Directory.GetCurrentDirectory(), "wwwroot", "Donation.csv" };
        var csvFilePath = Path.Combine(p);

        var config = new CsvConfiguration(CultureInfo.InvariantCulture) {
            HeaderValidated = null,
            MissingFieldFound = null,
            PrepareHeaderForMatch = args => args.Header.ToLower(),
        };

        var data = new List<Donation>().AsEnumerable();
        using (var reader = new StreamReader(csvFilePath)) {
            using (var csvReader = new CsvReader(reader, config)) {
                 data = csvReader.GetRecords<Donation>().Select(d => 
                {
                    d.Created = DateTime.UtcNow;
                    d.Modified = DateTime.UtcNow;
                    d.CreatedBy = "System"; 
                    d.ModifiedBy = "System";                     
                    return d;
                    
                }).ToList();
            }
        }

        
        return data;
     }


     

}
