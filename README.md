# EntityFrameworkCore.AutoLoad
Auto Load Configurations for EntityFrameworkCore

### This is an add-in for [EntityFrameworkCore](https://github.com/aspnet/EntityFrameworkCore/) 

Allow to use same configurations existing in EntityFramework 6 to auto load configurations.

[![Build status](https://ci.appveyor.com/api/projects/status/nlihfujfdw0x4l4r?svg=true)](https://ci.appveyor.com/project/davidrevoledo/microsoft-entityframeworkcore-autoload)
[![CodeFactor](https://www.codefactor.io/repository/github/davidrevoledo/entityframeworkcore.autoload/badge)](https://www.codefactor.io/repository/github/davidrevoledo/entityframeworkcore.autoload)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

### Nuget package

To Install from the Nuget Package Manager Console 

```sh
PM > Install-Package EntityFrameworkCore.AutoLoad 
NET CLI - dotnet add package EntityFrameworkCore.AutoLoad
paket paket add EntityFrameworkCore.AutoLoad
```
Available here https://www.nuget.org/packages/EntityFrameworkCore.AutoLoad/#

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
## Sample here [Usage](https://github.com/davidrevoledo/Microsoft.EntityFrameworkCore.AutoLoad/tree/master/src/Microsoft.EntityFrameworkCore.AutoLoad.Usage) 

