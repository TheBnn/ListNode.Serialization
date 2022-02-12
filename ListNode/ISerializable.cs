using System.IO;
using System.Threading.Tasks;

namespace ListNode
{
    public interface ISerializable
    {
        /// <summary>
        /// Serializes all nodes in the list, including topology of the Random links, into stream
        /// </summary>
        Task Serialize(ListNode head, Stream stream);
    }
}