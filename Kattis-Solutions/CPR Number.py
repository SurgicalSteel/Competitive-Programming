if __name__ == "__main__":
    snum = input()
    sint = "432765-4321"

    tot = 0
    for x in range(len(snum)):
        if snum[x] != "-":
            tot += (int(snum[x]) * int(sint[x]))
    
    if (tot % 11) == 0:
        print(1)
    else:
        print(0)
