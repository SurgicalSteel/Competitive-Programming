if __name__ == "__main__" :
    arr = []

    for x in range(1002):
        arr.append((x+1) * (x+2) * (x+3))
    
    n = int(input())

    newarr = [x for x in arr if x < n]
    print(len(newarr))
