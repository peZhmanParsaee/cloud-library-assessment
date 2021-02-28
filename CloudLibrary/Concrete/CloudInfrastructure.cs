using System;

using CloudLibrary.Abstract;

namespace CloudLibrary.Concrete {
  public class CloudInfrastructure {
    public String Name { get; set; }
    public String Title { get; set; }
    public AbstractCloudResource[] Resources { get; set; }
  }
}
