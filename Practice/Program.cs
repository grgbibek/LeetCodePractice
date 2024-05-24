// See https://aka.ms/new-console-template for more information
using Practice;
using Practice.BinarySearchTree;
using Practice.LeetCode.Easy;
using static Practice.LeetCode.Easy.MergeTwoSortedList;

Console.WriteLine("Hello, World!");

#region BinarySearch
//int[] intArray = { 1,5,8,10,15,22,88,96 };

//BinarySearch binarySearch = new BinarySearch(intArray);
//int? index = binarySearch.Find(100);
//if(index != null)
//{
//    Console.WriteLine("Element found at index " + index);
//}
//else
//{
//    Console.WriteLine("Element does not exist");
//}
#endregion

#region BinarySearchTree

//BinarySearchTree tree = new BinarySearchTree();
//tree.Insert(7, "Pokemon");
//tree.Insert(3, "Test3");
//tree.Insert(11, "Test11");
//tree.Insert(17, "Test17");

//var val = tree.Find(17);

#endregion

#region TwoSum
//int[] nums = { 2, 7, 10, 15 };
//TwoSum twoSum = new TwoSum();
//var result = twoSum.Run(nums, 17);
#endregion

#region AverageSalary
//int[] nums = { 48000,59000,99000,13000,78000,45000,31000,17000,39000,37000,93000,77000,33000,28000,4000,54000,67000,6000,1000,11000 };
//AverageSalary sal = new AverageSalary();
//var avg = sal.Run(nums);
#endregion

#region RomanToInteger
//RomanToInteger rmt = new RomanToInteger();
//var val = rmt.GetSum("III");
//var val1 = rmt.GetSum("LVIII");
//var val2 = rmt.GetSum("MCMXCIV");
#endregion

#region LongestCommonPrefix
string[] strs = { "flower", "flow", "flight" };
LongestCommonPrefix commonPrefix = new LongestCommonPrefix();
var a = commonPrefix.Run(strs);
#endregion

#region ValidParenthesis
//ValidParenthesis v = new ValidParenthesis();
// var tet = v.IsValid("[({})]");
#endregion

#region MergeTwoSortedList
//ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
//ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
//var res = new MergeTwoSortedList();
//var result = res.MergeTwoLists(list1, list2);
#endregion

#region SearchInsert
//int[] inputs = { 2, 3, 5, 6 };
//SearchInsertionPosition pr = new SearchInsertionPosition();
//var test = pr.SearchInsert(inputs,1 );
#endregion

#region LengthOfLastWord
//LengthOfLasWord l = new LengthOfLasWord();
//l.Run("   fly me   to   the moon  ");
#endregion

#region PlusOne
//int[] inputs = {9,9};
//PlusOne l = new PlusOne();
//var r = l.Run(inputs);
#endregion


#region Squareroot
//long num = 2147395599;
//Squareroot squareroot = new Squareroot();
//var res = squareroot.Run(num);
#endregion

#region ClimbingStairs
//ClimbingStairs cs = new ClimbingStairs();
//var res = cs.Run(2);
#endregion


#region MergeSortedArray
int[] nums1 = { 1, 2, 3, 0, 0, 0 };
int m = 3;
int[] nums2 = { 2, 5, 6 };
int n = 3;
MergeTwoSortedArray obj = new MergeTwoSortedArray();
//var res =
    obj.Merge(nums1, m, nums2, n);
#endregion
//Console.WriteLine(res);