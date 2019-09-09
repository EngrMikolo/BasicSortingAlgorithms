# BasicSortingAlgorithms
https://www.slideshare.net/MichealOgundero/basic-sorting-algorithms-csharp/MichealOgundero/basic-sorting-algorithms-csharp
Data Structures and Algorithms : A demonstration of the basic sorting algorithms: insertion sort, selection sort and bubble sort
 The two most common operations performed on data stored in a computer are sorting and searching.
Big-O notation is a mathematical function used to describe how complex an algorithm is — or more specifically, the execution time required by an algorithm.
It does this by presenting a “worst-case” scenario of how long it would take an algorithm to run (or in math terms, it puts an “asymptotic upper bound” on the time it takes an algorithm to run).

Bubble Sort
The bubble sort is one of the slowest sorting algorithms available, but it is also one of the simplest sorts to understand and implement.
Assuming you are sorting a list of numbers in ascending order, higher values float to the right whereas lower values float to the left.
This behavior is caused by moving through the list many times, comparing
adjacent values and swapping them if the value to the left is greater than the
value to the right.

Selection Sort
This algorithm follows the concept of dividing the given array into two subarrays.
The subarray of sorted elements
The subarray of unsorted elements

This sort works by starting at the beginning of the array, comparing the first element with the other elements
in the array. 
The smallest element is placed in position 0, and the sort then
begins again at position 1. This continues until each position except the last
position has been the starting point for a new loop.

Inserion Sort
Here, a sub-list is maintained which is always sorted. 

For example, the lower part of an array is maintained to be sorted. An element which is to be inserted in this sorted sub-list, has to find its appropriate place and then it has to be inserted there. 

This algorithm is efficient for smaller datasets.

The array is searched sequentially and unsorted items are moved and inserted into the sorted sub-list (in the same array).

