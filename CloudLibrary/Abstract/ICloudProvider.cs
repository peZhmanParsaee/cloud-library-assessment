using System;

using CloudLibrary.Concrete;

namespace CloudLibrary.Abstract {
  public interface ICloudProvider {
    String Name { get; }

    /// <summary>
    /// Create an infrastructure and its resources on the disk
    /// </summary>
    void Create(CloudInfrastructure infrastructure);
    
    /// <summary>
    /// Delete all the associated resources to an infrastructure
    /// </summary>
    void Delete(String infrastructureName);
  }
}
