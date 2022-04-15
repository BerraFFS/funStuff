from random import randint

cor = randint(1, 10)

x = 5

while x > 0:
    print("You have", str(x), "attempts left")
    ans = input("How tall is the giraffes neck?: ")
    if int(ans) == cor:
        print("You won!")
        break
    elif int(ans) != cor:
        x -= 1
        if cor < int(ans):
            print("That's too big!")
        elif cor > int(ans):
            print("That's too small")
if int(ans) != cor:
    print("You lost :(")
#BerraFFS
