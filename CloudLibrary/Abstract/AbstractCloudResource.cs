using System;
using System.IO;

namespace CloudLibrary.Abstract {
  public abstract class AbstractCloudResource {
    public abstract String FolderName { get; }
    public abstract String JsonFileName { get; }
    
    public abstract string ToJson();

    public virtual void CreateFile(string providerName, string infrastructureName) {
      var dirPath = $"{providerName}/{infrastructureName}/{FolderName}";
      Directory.CreateDirectory(dirPath);

      var jsonFilePath = $"{dirPath}/{JsonFileName}.json";
      var jsonData = this.ToJson();
      File.WriteAllText(jsonFilePath, jsonData);
    }
  }
}
