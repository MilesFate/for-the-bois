# this was made for 2 reason
# in case the main project isnt enough
# and because i am insanely bored
# that means i dont have to comment shit 
# and anything that is commented is code i took from other projects i have made
# gl figuring out what this code means ^_^
 
import platform
import os

def start():
    os_clear_screen()
    print('Hello Welcome to my program, I hope you enjoy it! ^_^')
    print("Coded by Luisalberto Castaneda, 4/23/2021")
    print('------------------------------------------------------')
    print("The main purpose of this program is to help calculate simple and compound interest.")
    print("All you have to do is enter what kind of intrest you want to calculate \nand then enter all the requested infomation.")


def compound_interest():
  Principle =float(input("Enter Principle Amount: "))
  Rate_of_Interest = float(input("Enter Rate of Interest: "))
  Time = float(input("Enter Number of Years= "))
  Output = Principle * ( 1 +  Rate_of_Interest / 100)**Time
  Output = str(round(Output, 2))
  print(Output)

def simple_interest():
  Principle =float(input("Enter Principle Amount: "))
  Rate_of_Interest = float(input("Enter Rate of Interest: "))
  Time = float(input("Enter Number of Years= "))
  Output = Principle*Rate_of_Interest *Time
  Output = str(round(Output, 2))
  print(Output)

def os_clear_screen():
    plt = platform.system()
    if   plt == "Windows":
           os.system('cls')# windows clear terminal command
    elif plt == "Linux":
            os.system('clear')# linux clear terminal command
    elif plt == "Darwin":
            os.system('clear')# mac clear terminal command

start()
a = input("simple or compound? ")
while True:
    if (a =='compound'):
        compound_interest()
        break
    elif (a=='simple'):
        simple_interest()
        break
    elif (a=='quit'):
        print('GoodBye\nPlease do comeback\n^_^')
        break
    else:
        print("Invalid Response")
        a = input()
  
