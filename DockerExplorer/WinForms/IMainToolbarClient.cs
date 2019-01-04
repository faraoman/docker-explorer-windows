namespace DockerExplorer.WinForms
{
   public interface IMainToolbarClient
   {
      void RefreshAll(string substring);

      void Search(string substring);
   }
}
