import math

if __name__ == "__main__":
    d = float(input())
    r = float(d/2)
    sa = float(input())
    sb = float(input())
    h = float(input())
    lm = float(math.pi * r * r)
    lt = float((sa+sb)*h/2)

    if lm>lt:
        print("Mahjong!")
    elif lt > lm:
        print("Trapizza!")
    else:
        print("Jafn storar!")
