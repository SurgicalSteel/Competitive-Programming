if __name__ == "__main__":
    udd = 13
    num = int(input())
    arr = input().split()

    if num >= udd:
        print(arr[udd-1])
    else:
        print(arr[(udd%num)-1])
