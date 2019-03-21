import numpy as np

def run(numbers_list):
    response = list()

    for number in numbers_list:
        exept_i = [x for x in numbers_list if x != number]
        product = np.prod(exept_i)
        response.append(product)


    return response


