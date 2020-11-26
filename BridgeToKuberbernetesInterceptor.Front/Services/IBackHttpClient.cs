using System.Threading.Tasks;

namespace BridgeToKuberbernetesInterceptor.Front.Services
{
  public interface IBackHttpClient
  {
    Task<string> GetValueAsync(int id);
  }
}