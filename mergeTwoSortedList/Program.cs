// See https://aka.ms/new-console-template for more information

using System;

public class ListNode{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null){
		this.val = val;
		this.next = next;
	}
}

public class Solution{
	public ListNode MergeTwoLists(ListNode list1, ListNode list2){
		ListNode dummy = new ListNode(0);
		ListNode current = dummy;

		while (list1 != null && list2 != null)
		{
		    if (list1.val <= list2.val)
		    {
		        current.next = list1;
				list1 = list1.next;
		    }else{
		        current.next = list2;
				list2 = list2.next;
			}
			current = current.next;
		}
		current.next = (list1 != null) ? list1 : list2;
		return dummy.next;
	}
}

class Program{
	static void Main(){
		ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
		ListNode l2 = new ListNode(1, new ListNode(2, new ListNode(4)));

		Solution sol = new Solution();
		ListNode merged = sol.MergeTwoLists(l1, l2);

		Console.Write("Resultado: ");
		while(merged != null){
			Console.Write(merged.val + " -> ");
			merged = merged.next;
		}
		Console.WriteLine("null");
	}
}
