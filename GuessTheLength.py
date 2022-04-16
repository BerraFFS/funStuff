from random import randint

res = "y"

while res == "y" or res == "Y":
    cor = randint(1, 10)
    x = 5
    while x > 0:
        print("You have", str(x), "attempts left")
        ans = int(input("How tall is the giraffes neck?: "))
        if ans == cor:
            print("You won!")
            x = 0
        elif ans != cor:
            x -= 1
            if cor < ans:
                print("That's too big!")
            elif cor > ans:
                print("That's too small")
    if ans != cor:
        print("You lost :(")
    res = input("Would you like to continue? (y/n): ")

#BerraFFS
