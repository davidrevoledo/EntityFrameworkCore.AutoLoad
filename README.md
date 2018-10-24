# Microsoft.EntityFrameworkCore.AutoLoad
Auto Load Configurations for EntityFrameworkCore

### This is an add-in for [EntityFrameworkCore](https://github.com/aspnet/EntityFrameworkCore/) 

Allow to use same configurations existing in EntityFramework 6 to auto load configurations.

### Nuget package

To Install from the Nuget Package Manager Console 

```sh

```
Available here 


## Usage

Just call it from `OnModelCreating` in `DbContext` class it will read all your configuratons where they implement `IEntityTypeConfiguration`

``` C#
 public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddFromAssembly(typeof(TestContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
```
## Sample here [Sample](https://github.com/davidrevoledo/Microsoft.EntityFrameworkCore.AutoLoad/tree/master/src/Microsoft.EntityFrameworkCore.AutoLoad.Usage) 

