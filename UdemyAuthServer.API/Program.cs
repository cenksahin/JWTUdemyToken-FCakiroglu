var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();

//swagger ekle
builder.Services.AddSwaggerGen().AddEndpointsApiExplorer();


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    //swagger ekle
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();