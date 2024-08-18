add-migration InitialCreate -OutputDir Data/Migrations -Project Ordering.Infrastructure -StartupProject Ordering.API

dotnet ef migrations add InitialCreate -o Data/Migrations -p Ordering.Infrastructure -s Ordering.API