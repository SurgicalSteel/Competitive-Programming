if __name__ == "__main__":
    #raw = "ghandi, mahatma"
    names = input().split(", ")
    last = names[0].capitalize()
    first = names[1][:1].capitalize()
    print(first+". "+last)
