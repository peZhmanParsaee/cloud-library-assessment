using CloudLibrary.Abstract;
using CloudLibrary.Helpers;

namespace CloudLibrary.Concrete {
  public class SqlServerCloudResource : AbstractDatabaseServer
  {
    #region Props (7)
    
    public override string FolderName { get { return "DatabaseServer"; } }

    public override string JsonFileName { get { return "SqlServer"; } }
    public override string Host { get; set; }
    public override string DatabaseName { get; set; }
    public override string UserName { get; set; }
    public override string Password { get; set; }

    public bool IntegratedSecurity { get; set; } = false;

    #endregion

    #region Methods (1)
    
    public override string ToJson()
    {
      object jsonData= new { Host, DatabaseName, UserName, Password };;

      if (this.IntegratedSecurity) {
        jsonData = new { Host, DatabaseName, IntegratedSecurity };
      }

      return JsonHelper.SerializeResouceContents(jsonData);
    }

    #endregion
  }
}
