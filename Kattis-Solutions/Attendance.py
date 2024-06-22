if __name__ == "__main__":
    arr = []
    szin = int(input())
    s = ""
    for x in range(szin):
        s = input()
        arr.append(s)
    
    for x in range(szin):
        if arr[x] == "Present!" and (x-1) >=0 :
            arr[x-1] = "-"
    
    newarr = []

    for x in range(szin):
        if arr[x] != "Present!" and arr[x] != "-":
            newarr.append(arr[x])
    
    if len(newarr) == 0:
        print("No Absences")
    else :
        for x in range (len(newarr)):
            print(newarr[x])
            
