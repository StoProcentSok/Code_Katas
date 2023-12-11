using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class _2_Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode();

            var trailingValue = 0;
            var addend1 = l1;
            var addend2 = l2;



            while (addend1 != null)
            {
                while(addend2 != null)
                {
                    
                    var sum = addend1.val + addend2.val + trailingValue;
                    if (sum >= 10)
                    {
                        result.val = 1;
                        trailingValue = 10 - sum;
                    }
                    addend1 = l1.next;
                    addend2 = l2.next;
                }
            }

            return result;
        }
    }





    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
