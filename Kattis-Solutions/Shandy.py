def mini(a,b):
    if a<b :
        return a
    else:
        return b

if __name__ == "__main__":
    a = int(input())
    b = int(input())

    print(mini(a,b) * 2)
