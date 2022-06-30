using Domain.Entities;
using Domain.Respositories;
using Microsoft.EntityFrameworkCore;
using persistence;
using Presentation.Controller;
using Presistence.Repositories;
using Services;
using Services.Abstractions;

namespace EducationalSystemServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<RepositoryDbContext>(opt => opt.UseInMemoryDatabase("EduSys"));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                                      policy =>
                                      {
                                          policy.WithOrigins("http://localhost:4200")
                                                              .AllowAnyHeader()
                                                              .AllowAnyMethod();
                                      });
            });


            builder.Services.AddTransient<IServiceManager, ServiceManager>();
            builder.Services.AddTransient<IRepositoryManager, RepositoryManager>();

            builder.Services.AddMvc()
                .AddApplicationPart(typeof(Controller).GetType().Assembly);

            //builder.Services.AddScoped<IServiceManager,ServiceManager>();


            var app = builder.Build();

            var scp = app.Services.CreateScope();

            AddFakeData(scp.ServiceProvider.GetRequiredService<RepositoryDbContext>());



            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

            }


            app.UseHttpsRedirection();

            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }


        static async void AddFakeData(RepositoryDbContext context) { 

            var t = new Teacher[] {
                  new() {Id = Guid.NewGuid(), Name = "teacher 1"},
                  new() {Id = Guid.NewGuid(), Name = "teacher 2"},
                  new() {Id = Guid.NewGuid(), Name = "teacher 3"},
                  new() { Id = Guid.NewGuid(), Name = "teacher 4"},
                  new() { Id = Guid.NewGuid(), Name = "teacher 5"}
            };

            var s = new Student[] {
                new() { Id =  Guid.NewGuid() , Name =  "student 1"},
                new() { Id =  Guid.NewGuid() , Name =  "student 2"},
                new() { Id =  Guid.NewGuid() , Name =  "student 3"},
                new() { Id =  Guid.NewGuid() , Name =  "student 4"},
                new() { Id =  Guid.NewGuid() , Name =  "student 5"},
                new() { Id =  Guid.NewGuid() , Name =  "student 6"},
                new() { Id =  Guid.NewGuid() , Name =  "student 7"},
                new() { Id =  Guid.NewGuid() , Name =  "student 8"},
                new() { Id =  Guid.NewGuid() , Name =  "student 9"},
                new() { Id =  Guid.NewGuid() , Name =  "student 10"},
                new() { Id =  Guid.NewGuid() , Name =  "student 11"},
                new() { Id =  Guid.NewGuid() , Name =  "student 12"},
                new() { Id =  Guid.NewGuid() , Name =  "student 13"},
                new() { Id =  Guid.NewGuid() , Name =  "student 14"},
                new() { Id =  Guid.NewGuid() , Name =  "student 15"},
            };

            foreach(var item in t)
            {
                await context.Teachers.AddAsync(item);
            }

            foreach(var item in s)
            {
                await context.Students.AddAsync(item);
            }

            await context.SaveChangesAsync();
        }
    }
}






