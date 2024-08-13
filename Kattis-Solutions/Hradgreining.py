if __name__ == "__main__":
    s = input()
    lens = len(s)
    exist=False
    for x in range(lens):
        if x <= lens-3 and s[x:x+3]=="COV":
            exist=True

    if exist:
        print("Veikur!")
    else:
        print("Ekki veikur!")
