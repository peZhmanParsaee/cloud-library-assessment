using CloudLibrary.Abstract;
using CloudLibrary.Enums;
using CloudLibrary.Helpers;

namespace CloudLibrary.Concrete {
  public class LinuxCloudResource : AbstractVirtualMachine
  {
    #region Props (6)

    public override string FolderName { get { return "VirtualMachine"; } }
    public override string JsonFileName { get { return "LinuxVM"; } }
    public override OperatingSystemEnum Os { get { return OperatingSystemEnum.Linux; } }
    public override string Cpu { get; set; }
    public override string Ram { get; set; }
    public override string HardDisks { get; set; }
    public string Distribution { get; set; }
    public string Version { get; set; }

    #endregion
    
    
    #region Methods (1)

    public override string ToJson()
    {
      var jsonData = new { Cpu, Ram, Os = Os.ToString(), HardDisks, Version, Distribution };
      return JsonHelper.SerializeResouceContents(jsonData);
    }

    #endregion
  }
}
