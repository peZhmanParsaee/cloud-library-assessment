using CloudLibrary.Abstract;
using CloudLibrary.Helpers;

namespace CloudLibrary.Concrete {
  public class MySqlCloudResource : AbstractDatabaseServer
  {
    #region Props (4)

    public override string FolderName { get { return "DatabaseServer"; } }
    public override string JsonFileName { get { return "MySql"; } }
    public override string Host { get; set; }
    public override string DatabaseName { get; set; }
    public override string UserName { get; set; }
    public override string Password { get; set; }


    #endregion

    #region Methods (1)

    public override string ToJson()
    {
      var jsonData = new {
        Host,
        DatabaseName,
        UserName,
        Password
      };

      return JsonHelper.SerializeResouceContents(jsonData);
    }

    #endregion    
  }
}
