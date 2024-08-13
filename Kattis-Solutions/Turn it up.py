if __name__ == "__main__":
    num = int(input())
    cv = 7
    s = ""
    for x in range(num):
        s = input()
        if s == "Skru op!" and cv <10:
            cv += 1
        elif s == "Skru ned!" and cv >0:
            cv -= 1
        
    print(cv)
