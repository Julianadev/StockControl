var builder = WebApplication.CreateBuilder(args);

int[] estoque = { 200, 700, 150, 900, 175, 43, 75, 210 };
int soma = 0;
int bin = 0;
foreach (int items in estoque)
{
    soma += items;
    bin++;
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine($"Bin {bin} = {items} itens\t\t(Estoque Total:{soma})");
}
Console.WriteLine($"\n\nVocê tem {soma} itens no estoque");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
