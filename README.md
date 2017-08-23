# Counting Minor Or Equal Numbers Between Arrays

Amy has an array, nums, of n positive integers and another array, maxes, of m positive integers. 
For each maxes, in maxes, she wants to know the total number of elements in nums which are less than or equal
to that maxes. For example, if nums = [1,2,3] and maxes = [2,4], then there are 2 elements in nums that are =< maxes (which is 2)
and 3 elements in nums that are =< maxes (which is 4). We can store this respective answers in another array answer = [2,3]

The counts function must return an array of m positive integers in which the integer at each index (where 0 =< i < m) 
denotes the total number of elements (where 0 =< j < n) satisfying nums =< maxes

Sample Input 

nums: [1,4,2,4]
maxes: [3,5]

Sample Output:

[2,4]

For maxes = 3 we have two elements in nums (nums = 1 and nums = 2) that are =< maxes
For maxes = 5 we have four elements in nums (nums = 1; nums = 4, nums = 2, nums = 4) that are =< maxes

Thus function must return the array [2,4]
