using System.Threading.Tasks;

namespace ListNode
{
    public interface IDeepCopy
    {

        /// <summary>
        /// Makes a deep copy of the list, returns the head node of the list 
        /// </summary>
        Task<ListNode> DeepCopy(ListNode head);
    }
}