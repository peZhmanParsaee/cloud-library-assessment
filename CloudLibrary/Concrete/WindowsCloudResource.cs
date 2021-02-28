using System;

using CloudLibrary.Abstract;
using CloudLibrary.Enums;
using CloudLibrary.Helpers;

namespace CloudLibrary.Concrete {
  public class WindowsCloudResource : AbstractVirtualMachine
  {
    #region Props (6)

    public override string FolderName { get { return "VirtualMachine"; } }
    public override string JsonFileName { get { return "WindowsVM"; } }
    public override OperatingSystemEnum Os { get { return OperatingSystemEnum.Windows; } }
    public override string Cpu { get; set; }
    public override string Ram { get; set; }
    public override string HardDisks { get; set; }
    public string Version { get; set; }

    #endregion
    

    #region Ctors (1)

    public WindowsCloudResource(string cpu, string ram, string hardDisks, string version)
    {
      this.Cpu = cpu;
      this.Ram = ram;
      this.HardDisks = hardDisks;
      this.Version = version;
    }

    #endregion

    
    #region Methods (1)
    
    public override string ToJson()
    {
      var jsonData = new { Cpu, Ram, Os= Os.ToString(), HardDisks, Version };
      return JsonHelper.SerializeResouceContents(jsonData);
    }

    #endregion
    
  }
}