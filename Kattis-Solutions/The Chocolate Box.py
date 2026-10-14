if __name__ == "__main__":
    sz = int(input())
    arr = [int(x) for x in input().split(" ")]
    
    counter_up = 0
    for i in range(sz):
        if i>0:
            if arr[i] > arr[i-1]:
                counter_up += 1
    
    print(counter_up)
