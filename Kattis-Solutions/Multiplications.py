if __name__ == "__main__":
    tot = 1
    n = int(input())
    m = 1000000007
    temp = 0
    for x in range(n):
        temp = int(input()) % m
        tot = tot * temp
    
    print(tot%m)
