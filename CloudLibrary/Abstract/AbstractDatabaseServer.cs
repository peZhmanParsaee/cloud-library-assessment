namespace CloudLibrary.Abstract {
  public abstract class AbstractDatabaseServer : AbstractCloudResource {
    public abstract string Host { get; set; }
    public abstract string DatabaseName { get; set; }
    public abstract string UserName { get; set; }
    public abstract string Password { get; set; }
  }
}