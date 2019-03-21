import numpy as np

# unperformant version O(n^2)
def run(numbers_list):
    response = list()

    for number in numbers_list:
        exept_i = [x for x in numbers_list if x != number]
        product = np.prod(exept_i)
        response.append(product)


    return response

# More peformant version O(n)
def run_v2(numbers):
    n = len(numbers)
    left_side = np.empty(n, dtype=int)
    left = 1

    # Traverse from the left
    # if numbers = { 1, 2, 3, 4, 5 }
    # then left side would be = { 1, 1, 2, 6, 24 }
    for i in range(n):
       left_side[i] = left
       left *= numbers[i]

    right = 1
    product_array = left_side

    # Traverse from the right
    # we would get product array = { 120, 60, 40 ,30, 24 }
    for i in range(n - 1, -1, -1):
        product_array[i] *= right
        right *= numbers[i]

    return product_array

