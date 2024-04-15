using Apbd_cw5.DataBase;
using Apbd_cw5.Endpoints;

var builder = WebApplication.CreateBuilder(args);
//!Blazer -> WebApi
//!Prawo gura wybieramy apbd http
//!Zeby przetestowac w postman kopiujemy link z swaggera n.p: http://localhost:5000/weatherforecast
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddControllers();//Dodajemy controllery
// builder.Services.AddSingleton<MockDb>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Minimal API
app.MapAnimalEndpoints();
app.MapVisitEndpoints();

//Controllers
//app.MapControllers(); //Mapuje wszystkie koncowki z kontrollerow
app.Run();
