using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.TaskApp.DataAccess.Repositories;
using ToDo.TaskApp.DataAccess.Repositories.CacheRepositories;
using ToDo.TaskApp.Domain;

namespace Services.Helpers
{
    public static class DIRepositoryModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<ToDoTask>, ToDoTaskRepository>();
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<SubTask>, SubTaskRepository>();
            return services;
        }
    }
}
