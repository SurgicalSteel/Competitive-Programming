def reverse(str):
    res = ""
    maxLen = len(str)
    for x in range(maxLen):
        ci = maxLen - x - 1
        res += str[ci:ci+1]
    return res

def decode(str):
    newstr = ""
    curr = ""
    maxLen = len(str)
    for x in range(maxLen):
        curr = str[x:x+1]
        if curr == "2":
            newstr += "5"
        elif curr == "5":
            newstr += "2"
        else:
            newstr += curr

    return newstr

if __name__ == "__main__":
    sarr = input().split(" ")
    da = int(decode(reverse(sarr[0])))
    db = int(decode(reverse(sarr[1])))
    if da>db :
        print(1)
    else:
        print(2)
