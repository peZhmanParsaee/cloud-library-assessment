using System;
using CloudLibrary.Abstract;
using System.IO;

namespace CloudLibrary.Concrete {
  public class IGSCloudProvider : ICloudProvider {
    public String Name { get { return "IGS"; } }
    
    public void Create(CloudInfrastructure infrastructure) {
      this.Delete(infrastructure.Name);

      foreach (var resource in infrastructure.Resources) {
        resource.CreateFile(this.Name, infrastructure.Name);
      }
    }

    public void Delete(String infrastructureName) {
      var providerPath = $"{this.Name}";
      var infrastructurePath = $"{providerPath}/{infrastructureName}";

      if (Directory.Exists(infrastructurePath) == false) {
        return;
      }

      var directories = Directory.GetDirectories(infrastructurePath);

      foreach (var directory in directories) {
        var di = new DirectoryInfo(directory);
        foreach(var file in di.GetFiles()) {
          file.Delete();
        }

        Directory.Delete(directory);
      }
    }
  }
}
