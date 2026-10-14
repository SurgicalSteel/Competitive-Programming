if __name__ == "__main__":
    arr = [1,2,3]
    sz = int(input())
    if sz <= 3:
        for i in range(sz):
            print(arr[i])
    else:
        currIdx = 2
        while currIdx < sz-1:
            temp = arr[currIdx] + arr[currIdx-1] + arr[currIdx-2]
            arr.append(temp)
            currIdx += 1
        
        for a in arr:
            print(a)
            
