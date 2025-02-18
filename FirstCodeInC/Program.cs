var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();

//Permite procurar por Controllers
builder.Services.AddControllers();

//Adiciona o Swagger dentro do codigo
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    //Habilita o acesso a pagina do swagger
    app.UseSwagger();
    app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "FirstCodeInC"); });
}

//Mapea e executa os controllers
app.MapControllers();
app.Run();
