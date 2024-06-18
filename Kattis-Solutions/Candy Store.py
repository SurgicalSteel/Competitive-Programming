def getInitial(name):
    arr = str.split(name, " ")
    return f"{arr[0][0]}{arr[1][0]}"

if __name__ == "__main__":
    sarr = input().split(" ")
    fnc = int(sarr[0])
    anc = int(sarr[1])

    dname = dict()
    initial = ""
    name = ""
    
    for x in range(fnc):
        name = input()
        initial = getInitial(name)
        if initial in dname :
            dname[initial] = "ambiguous"
        else:
            dname[initial] = name
    
    for x in range(anc):
        initial = input()
        if initial in dname :
            print(dname[initial])
        else :
            print("nobody")
    
