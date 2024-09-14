using System;
using domain.Features.ControleDePrecos.Repositories;
using domain.Features.ControleDePrecos.Services;
using domain.Features.Pedidos.Repositories;
using domain.Features.Pedidos.Services;
using domain.Features.Produtos.Repositories;
using domain.Features.Produtos.Services;
using infra.LocalDataAccess.Repositories;
using infra.LocalDataAccess.Repositories.ControleDePrecosRepositories;
using infra.LocalDataAccess.Repositories.PedidosRepositories;
using infra.LocalDataAccess.Repositories.ProdutosRepositories;
using infra.RemoteDataAccess;

namespace api.injections
{
	public class Injections
	{
		private readonly IServiceCollection _services;


		public Injections(WebApplicationBuilder builder)
		{
			_services = builder.Services;
		}


		public  void RegisterInjections()
		{
			ProdutosInjections();
			ControleDePrecosInjections();
			PessoasInjections();
			//PedidosInjections();
		}


		private void ProdutosInjections()
		{
			//repositories
			_services.AddScoped<IProdutosRepository, ProdutosRepository>();
			//services
			_services.AddScoped<ProdutosService, ProdutosService>();

		}

		private void ControleDePrecosInjections()
		{
			//repositories
			_services.AddScoped<ITabelaDePrecosRepository, TabelasDePrecosRepository>();
			_services.AddScoped<IPrecosDasReferenciasRepository, PrecosDasReferenciasRepository>();
			//services
			_services.AddScoped<ControleDePrecosService>();
		}

		private void PessoasInjections()
		{
			//repositories
            _services.AddScoped<IPessoaRepository, PessoaRepository>();
			//services
            _services.AddScoped<PessoasService>();

        }

		private void PedidosInjections()
		{

			//repositories
			_services.AddScoped<IPedidosRepository,PedidosRepository>();
			_services.AddScoped<INFCRepository, NFCRepository>();
			//services
			_services.AddScoped<PedidosService>();
			_services.AddScoped<NFCsServices>();

			//remote
			_services.AddScoped<NFCWebManiaRemoteDataSource>();
		}


    }
}

