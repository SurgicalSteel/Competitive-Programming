def init_arr(max_num):
    arr = ["{}","{{}}"]
    i =2
    while i <= max_num:
        temp = "{"
        for x in range(i):
            temp += arr[x]
            if x <i-1:
                temp += ","
            else:
                temp += "}"
        arr.append(temp)
        i += 1
    
    return arr

if __name__ == "__main__":
    arr = init_arr(10)
    num = int(input())
    print(arr[num])
