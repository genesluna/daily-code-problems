from math import fabs

def run(numbers_list, k):

    for number in numbers_list:
        if fabs(k - number) in numbers_list:
            return True

    return False


