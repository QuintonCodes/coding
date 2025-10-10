# Chapter 2: Arrays & Lists

arr = [10, 20, 30, 40]

# Traversal (O(n))
def traverse_array(arr: list[int]) -> str:
  for i in range(len(arr)):
    print(f"Index {i}: Value {arr[i]}")

traverse_array(arr)

# Insert
arr.insert(2, 99) # Insert 99 at index 2
print(arr)  # [1, 2, 99, 3, 4]

# Delete
arr.remove(99) # Remove first occurence of 99
print(arr)  # [1, 2, 3, 4]

# Linear Search (O(n))
def linear_search(arr: list[int], target: int) -> int:
  for i in range(len(arr)):
    if arr[i] == target:
      return i
  return -1

print(linear_search([5, 8, 12, 7], 12)) # Output: 2

# Binary Search (O(log n))
def binary_search(arr: list[int], target: int) -> int:
  left, right = 0, len(arr) - 1
  while left <= right:
    mid = (left + right) // 2
    if arr[mid] == target:
      return mid
    elif arr[mid] < target:
      left = mid + 1
    else:
      right = mid - 1
  return -1

print(binary_search([1, 3, 5, 7, 9], 7)) # Output: 3

# Two-Pointer Technique
def has_pair_with_sum(arr: list[int], target: int) -> bool:
  arr.sort()
  left, right = 0, len(arr) - 1

  while left < right:
    current_sum = arr[left] + arr[right]
    if current_sum == target:
      return True
    elif current_sum < target:
      left += 1
    else:
      right -= 1

  return False

print(has_pair_with_sum([10, 5, 2, 3, -6, 9, 11], 4)) # Output: True (5, -1)

# Sliding Window - Max Sum Subarray of size k
def max_sum_subarray(arr: list[int], k: int) -> int:
  window_sum = sum(arr[:k])
  max_sum = window_sum

  for i in range(k, len(arr)):
    window_sum += arr[i] - arr[i - k]
    max_sum = max(max_sum, window_sum)

  return max_sum

print(max_sum_subarray([2, 1, 5, 1, 3, 2], 3)) # Output: 9 (5 + 1 + 3)