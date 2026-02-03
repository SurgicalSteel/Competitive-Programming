def gcd(x,y):
    if y == 0:
        return x
    else:
        return gcd(y, x%y)

if __name__ == "__main__":
    sarr = input().split(' ')
    x = int(sarr[0])
    y = int(sarr[1])
    print(gcd(x,y))
