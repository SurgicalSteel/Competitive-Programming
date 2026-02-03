def get_remaining_green(g):
    total = 0

    mod3 = g%3
    threes = (g-mod3)/3
    total += (threes *10)

    mod2 = mod3%2
    twos = (mod3 - mod2)/2
    total += (twos *3)

    total += mod2

    return total

def mini(x,y):
    if x < y :
        return x
    else:
        return y

if __name__ == "__main__":
    sarr = input().split(" ")
    g = int(sarr[0])
    r = int(sarr[1])

    total = 0

    if g >0:
        if r > 0:
            mingr = mini(g,r)
            g -= mingr
            r -= mingr
            total += (10 *mingr)
            if g > 0 :
                total += get_remaining_green(g)
        else:
            total = get_remaining_green(g)

    print(int(total))
