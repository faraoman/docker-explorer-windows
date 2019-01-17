using System.Threading.Tasks;

namespace DockerExplorer.WinForms
{
   public interface IMainToolbarClient
   {
      /// <summary>
      /// This instance is activated
      /// </summary>
      void ToolbarActivate();

      IMainToolbarServer ToolbarServer { set; }

      void ToolbarRefreshAll(string substring);

      void ToolbarSearch(string substring);

      Task ToolbarDeleteAsync();
   }
}
