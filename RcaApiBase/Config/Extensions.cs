using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcaApiBase.Config
{
	public static class Extension
	{

		/// <summary>
		/// adds <typeparamref name="T"/> config to the DI
		/// </summary>
		/// <typeparam name="T">config class to be added</typeparam>
		/// <param name="services"></param>
		/// <param name="configuration"></param>
		/// <returns></returns>
		public static IServiceCollection AddConfig<T>(this IServiceCollection services, IConfiguration configuration)
		{
			services.Add(AddConfig<T>(configuration));
			return services;
		}

		/// <summary>
		/// creates new service descriptor
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="factory">how to create a config class instance</param>
		/// <param name="lifetime"></param>
		/// <returns></returns>
		static ServiceDescriptor AddDescriptor<T>(Func<IServiceProvider, T> factory, ServiceLifetime lifetime = ServiceLifetime.Singleton)
		{
			return new ServiceDescriptor(typeof(T), _ => factory(_), lifetime);
		}

		/// <summary>
		/// creates service descriptor using <see cref="LoadConfig{T}(IConfiguration)"/> as the factory
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="configuration"></param>
		/// <param name="lifetime"></param>
		/// <returns></returns>
		static ServiceDescriptor AddConfig<T>(IConfiguration configuration, ServiceLifetime lifetime = ServiceLifetime.Singleton)
		{
			return AddDescriptor<T>(_ => LoadConfig<T>(configuration), lifetime);
		}

		/// <summary>
		/// loads instance from config
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="configuration"></param>
		/// <returns></returns>
		public static T LoadConfig<T>(this IConfiguration configuration)
		{
			var name = GetSectionName<T>();
			var section = configuration.GetSection(name);
			var config = section.Get<T>();
			if (config == null)
				Log.Error("no configuration section:{0} value", name);
			return config;
		}

		/// <summary>
		/// converts class name to the configuration element name
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static string GetSectionName<T>()
		{
			var name = typeof(T).Name;
			return name;
		}

	}
}
