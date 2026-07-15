if __name__=="__main__":
    da = int(input())
    db = int(input())
    if da > db :
        print(min(da - db, 360 - da + db))
    else:
        print(min(db - da, 360 - db + da))
