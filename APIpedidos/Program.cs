using Microsoft.EntityFrameworkCore;
using WebApiGest�oPedidos.Data;
using WebApiGest�oPedidos.Services.Cliente;
using WebApiGest�oPedidos.Services.ItemPedido;
using WebApiGest�oPedidos.Services.Pedido;
using WebApiGest�oPedidos.Services.Produto;
using WebApiGest�oPedidos.Services.StatusPedido;
using WebApiGest�oPedidos.Services.TipoProduto;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IClienteInterface, ClienteService>();
builder.Services.AddScoped<IPedidoInterface, PedidoService>();
builder.Services.AddScoped<IItemPedidoInterface, ItemPedidoService>();
builder.Services.AddScoped<IProdutoInterface, ProdutoService>();
builder.Services.AddScoped<IStatusPedidoInterface, StatusPedidoService>();
builder.Services.AddScoped<ITipoProdutoInterface, TipoProdutoService>();


// conex�o com o banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
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
