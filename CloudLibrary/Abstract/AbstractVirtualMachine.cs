using System;
using CloudLibrary.Enums;

namespace CloudLibrary.Abstract {
  public abstract class AbstractVirtualMachine : AbstractCloudResource {
    public abstract String Cpu { get; set; }
    public abstract String Ram { get; set; }
    public abstract OperatingSystemEnum Os { get; }
    // TODO
    public abstract String HardDisks { get; set; }
  }
}
