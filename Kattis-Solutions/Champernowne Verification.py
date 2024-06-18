if __name__ == "__main__":
    arr = []
    for x in range(11):
        if x==0:
            arr.append(str(x+1))
        else:
            arr.append(arr[x-1]+str(x+1))
    
   #print(arr)
    
    res = -1
    s = input()
    for x in range(11):
        if s == arr[x] :
            res = x+1

    print(res)
