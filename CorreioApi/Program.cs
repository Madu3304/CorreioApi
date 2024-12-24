using CorreioApi.Integracao.Interfaces;
using CorreioApi.Integracao.Refit;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddEntityFrameworkSqlServer()
//    .AddDbContext<CorreioApiDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));


//builder.Services.AddScoped<IUsuarioRepositorio, IUsuarioRepositorio>();
//builder.Services.AddScoped<ITarefaRepositorio, ITarefaRepositorio>();
builder.Services.AddScoped<IViaCepIntegracao, IViaCepIntegracao>();



builder.Services.AddRefitClient<IViaCepIntegracaoRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://viacep.com.br");
    //endereco da api
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
