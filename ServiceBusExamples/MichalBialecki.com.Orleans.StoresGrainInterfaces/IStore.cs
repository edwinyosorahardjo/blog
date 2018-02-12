using System.Threading.Tasks;
using Orleans;

namespace MichalBialecki.com.Orleans.StoresGrainInterfaces
{
    /// <summary>
    /// Grain interface IGrain1
    /// </summary>
    public interface IStore : IGrainWithGuidKey
    {
        Task<float> GetBalanceForToday();
    }
}