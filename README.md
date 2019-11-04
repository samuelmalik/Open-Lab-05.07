# Open-Lab-05.07
(18 XP) A function that removes the smallest integer from an array.

1. Fork this repository to your GitHub account.
2. Open solution file in Visual Studio.
3. Open file `Numbers.cs`.
4. Implement the method `RemoveSmallest(int[] nums)` that removes the smallest integer from an array.
5. Run with `CTRL+F5` to test it.
6. If all tests are passed, commit & sync your repository.
7. Send a link to your repository for Lab Master (in #slack) to check it.

## Examples: 
```C#
RemoveSmallest([1, 2, 3, 4, 5]) ➞ [2, 3, 4, 5]
RemoveSmallest([5, 3, 2, 1, 4]) ➞ [5, 3, 2, 4]
RemoveSmallest([2, 2, 1, 2, 1]) ➞ [2, 2, 2, 1]
```

## Notes:
* Don't change the order of other numbers.
* If the array contains multiple numbers with the same value, remove the number with the smallest index (check example num. 3).
