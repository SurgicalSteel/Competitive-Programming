if __name__ == '__main__':
    sz = int(input())
    isKey = False
    isPhone = False
    isWallet = False
    for x in range(sz):
        temp = input()
        if temp == "keys" :
            isKey =True
        elif temp == "phone" :
            isPhone = True
        elif temp == "wallet" :
            isWallet = True

    if isKey and isPhone and isWallet :
        print("ready")
    else :
        if not(isKey):
            print("keys")
        if not(isPhone):
            print("phone")
        if not(isWallet):
            print("wallet")
