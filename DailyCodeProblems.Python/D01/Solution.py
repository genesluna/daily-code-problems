# Unperformant version O(n^2)
def run(numbers_list, k):

    for number in numbers_list:
        if k - number in numbers_list:
            return True

    return False

# More peformant version O(n)
def run_v2(numbers_list, k):
    known_numbers = set()

    for number in numbers_list:
        # sets search is O(1)
        if k - number in known_numbers:
            return True
        known_numbers.add(number)

    return False


