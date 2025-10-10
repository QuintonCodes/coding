# Big O Notation

# Constant Time - O(1)
def get_first_element(arr: list[int]) -> int:
    # Accessing the first element always takes constant time
    return arr[0]

print(get_first_element([10, 20, "30"]))  # Output: 10


# Linear Time - O(n)
def print_all_elements(arr: list[int]) -> int:
    for item in arr:
        print(item)

print_all_elements([1, 2, 3, 4, 5])


# Quadratic Time - O(n^2)
def print_pairs(arr: list[int]) -> int:
    for i in arr:
        for j in arr:
            print(i, j)

print_pairs([1, 2, 3])


# Logarithmic Time - O(log n)
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

    return -1  # not found

print(binary_search([1, 3, 5, 7, 9, 11], 7))  # Output: 3


# Recursion Example
def factorial(n: int) -> int:
    if n == 0 or n == 1:
        return 1
    # Recursive case
    return n * factorial(n - 1)

print(factorial(5))  # Output: 120


# Space Complexity Example
def create_list(n: int) -> list[int]:
    # O(n) space complexity because list grows with n
    result = []
    for i in range(n):
        result.append(i)
    return result

print(create_list(5))