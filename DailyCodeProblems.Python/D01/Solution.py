from math import fabs

def run(lst, k):

    for num in lst:
        if fabs(k - num) in lst:
            return True

    return False


