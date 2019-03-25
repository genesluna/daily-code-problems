# Time O(n log n), constant space O(1)
def run(input):

    input = list(dict.fromkeys(input))

    input.sort()

    n = len(input) 

    for i in range(n):
        if i == n - 1:
            return (input[i] + 1)

        if (input[i] +1) > 0 and (input[i] + 1) != input[i+1]:
            return (input[i] +1)

    return -1

# O(n) time and space
def run_v2(input):
    s = set(input)
    i = 1
    
    while i in s:
        i += 1

    return i

# Time O(n), constant space O(1) as demanded by the problem
def run_v3(input):
   
    for i, num in enumerate(input):
        while i + 1 != input[i] and 0 < input[i] <= len(input):
            v = input[i]
            input[i], input[v - 1] = input[v - 1], input[i]

            if input[i] == input[v - 1]:
                break

    for i, num in enumerate(input, 1):
        if num != i:
            return i

    return len(input) + 1