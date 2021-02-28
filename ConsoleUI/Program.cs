using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

using CloudLibrary.Abstract;
using CloudLibrary.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICloudProvider, IGSCloudProvider>()
                .BuildServiceProvider();
            
            var igsCloudProvider = serviceProvider.GetService<ICloudProvider>();

            try {
                // creating a cloud infrastructure + its resources
                var uatInfrastructure = new CloudInfrastructure() { 
                    Name = "UAT", 
                    Title = "Project 1", 
                    Resources = getSampleUATResources()
                };
                igsCloudProvider.Create(uatInfrastructure);
                
                // creating another cloud infrastructure + its resources
                var devInfrastructure = new CloudInfrastructure() { 
                    Name = "Dev",
                    Title = "Project 2", 
                    Resources = getSampleDevResources()
                };
                igsCloudProvider.Create(devInfrastructure);

                // delete first cloud infrastructure
                igsCloudProvider.Delete("UAT");
            }
            catch (System.Exception err) {
                Console.WriteLine("An error was happened during creating or deleing infrastructure(s): " + err.Message);
            }
        }

        static AbstractCloudResource[] getSampleUATResources() 
        {
            var cloudResources1 = new List<AbstractCloudResource>();

            cloudResources1.Add(new LinuxCloudResource() { 
                Cpu = "Pentium |||", 
                Ram = "256MB", 
                HardDisks = "HDD1",
                Distribution = "Ubuntu",
                Version = "20.10"
            });
            cloudResources1.Add(new WindowsCloudResource("Xeon", "64GB", "NVMe SSD", "Server 2014"));
            cloudResources1.Add(new SqlServerCloudResource() { 
                Host = "server1.igs.com", 
                UserName = "user1", 
                Password = "1##$2D3A", 
                DatabaseName = "geeksDB",
                IntegratedSecurity = true
            });
            cloudResources1.Add(new MySqlCloudResource() {
                Host = "server2.igs.com",
                UserName = "user2",
                Password = "sdfa343D#2",
                DatabaseName = "sample_db"
            });
            
            return cloudResources1.ToArray();
        }

        static AbstractCloudResource[] getSampleDevResources() 
        {
            var cloudResources1 = new List<AbstractCloudResource>();

            cloudResources1.Add(new LinuxCloudResource() { 
                Cpu = "Pentium |||", 
                Ram = "256MB", 
                HardDisks = "HDD1",
                Distribution = "Ubuntu",
                Version = "20.10"
            });
            cloudResources1.Add(new SqlServerCloudResource() { 
                Host = "server1.igs.com", 
                UserName = "user1", 
                Password = "1##$2D3A", 
                DatabaseName = "geeksDB",
                IntegratedSecurity = true
            });
            
            return cloudResources1.ToArray();
        }
    }
}
