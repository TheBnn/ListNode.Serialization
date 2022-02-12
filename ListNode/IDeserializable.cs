using System.IO;
using System.Threading.Tasks;

namespace ListNode
{
    public interface IDeserializable
    {
        /// <summary>
        /// Deserializes the list from the stream, returns the head node of the list
        /// </summary>
        /// <exception cref="System.ArgumentException">Thrown when a stream has invalid data</exception>
        Task<ListNode> Deserialize(Stream stream);
    }
}