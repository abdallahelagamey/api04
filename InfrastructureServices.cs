public static IServiceCollection AddInfrastructureServices(this IServiceCollection services , IConfiguration)

services. AddDbContext<StoreDbContext>(options =>
{
options. UseSqlServer(configuration.GetConnectionString("DefaultConnection");
});


services. AddkeyedScoped<IDataSeeder, CatalogDataSeed>("Catalog");
services.AddScoped<IUnitOfWork, UnitofWork>();
services.AddSingleton<IConnectionMultiplexer>(Config =>
{
return ConnectionMultiplexer. Connect(configuration.GetConnectionString("RedisConnection") !):
});
return service;
