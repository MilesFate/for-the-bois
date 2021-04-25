# time is used to make the program wait
# i will mainly use this to give the user time to read
# importing os makes the screen clutter cut down
# like by a lot
# i love the person who made it
# platform is for making os work on different platforms
# like windows, linux, and mac
import time,os,platform

# randint is used to add some randomization to the program
from random import randint

# this will be used mainly so i dont have to write this 100 times
# all it does is tells the user to wait and sleeps the program
def sleep():
    print('Please Wait..')
    time.sleep(2)

# this fixes and issue i had that the program would not work cross platform
# but now it finds what platform your using and works accordinly
# thank you Haim Cohen on stack overflow for this
def os_type():
    plt = platform.system()
    if   plt == "Windows":
           os.system('cls')# windows clear terminal command
    elif plt == "Linux":
            os.system('clear')# linux clear terminal command
    elif plt == "Darwin":
            os.system('clear')# mac clear terminal command

# lines works to show both the begining and the end of a given section
lines= '---------------------------------'
# because i need a list
teams_list = ['Team','options','are',':','tl,', 'c9,', 'tsm,', 'thieves,', 'clg,', 'dig,', 'eg,', 'fly,', 'gg']
#because i cant be bothered to do this correctly
teams = " ".join(teams_list)

# lap is used to show the user their options for what team they wish to see
# like with sleep it is mainly used to save time for me when writing the program
def options():
        sleep()
        print(lines)
        print(teams)

# the following functions are for each team
# i use classes for the teams to make it easier to change a given name
# mainly because any given possition on a team changes quite often
def Team_Liquid():
    class Team_Liquid:
        Top='Alphari'
        Jungle='Santorin'
        Mid='Jenson'
        Bot='Tactical'
        Sup ='CoreJJ'
    tl = Team_Liquid
    # this one line right here is the biggest iq move in all the code
    # this calls the system and clears the screen
    # though this only works on windows and its terminal
    # but who is going to run this on a bash terminal
    # so i have fixed this issue, go and use all the bash you want ^_^
    os_type()
    print(lines)
    print("This is Team Liquid's Current Roaster for LCS.")
    print(lines)
    sleep()
    print(' ')
    print("In the Top Lane "+ tl.Top)
    print("In the Jungle "+ tl.Jungle)
    print("In the Mid Lane "+ tl.Mid)
    print("In the Bot Lane "+ tl.Bot)
    print("In the Support Role "+ tl.Sup)

# tbh this is the best team
def Cloud_9():
    class Cloud_9:
        Top='Fudge'
        Jungle='Blaber'
        Mid='Perkz' # the GOAT
        Bot='Zven' # Sneaky was more fun to watch
        Sup ='Vulcan'
    c9=Cloud_9
    os_type()
    print(lines)
    print("This is Cloud 9's Current Roaster for LCS.")
    print(lines)
    sleep()
    print(' ')
    print("In the Top Lane "+ c9.Top)
    print("In the Jungle "+ c9.Jungle)
    print("In the Mid Lane "+ c9.Mid)
    print("In the Bot Lane "+ c9.Bot)
    print("In the Support Role "+ c9.Sup)

# TSM is overrated 
# they never perform well internationally
def TSM():
    class TSM:
        Top='Huni'
        Jungle='Spica'
        Mid='Power Of Evil'
        Bot='Lost'
        Sup ='SwordArt'
    tsm = TSM
    os_type()
    print(lines)
    print("This is TSM's Current Roaster for LCS.")
    print(lines)
    sleep()
    print(' ')
    print("In the Top Lane "+ tsm.Top)
    print("In the Jungle "+ tsm.Jungle)
    print("In the Mid Lane "+ tsm.Mid)
    print("In the Bot Lane "+ tsm.Bot)
    print("In the Support Role "+ tsm.Sup)

def Thieves():
    class Thieves:
        Top='Ssumday'
        Jungle='Closer'
        Mid='Damonte'
        Bot='FBI'
        Sup ='huhi'
    thieves=Thieves
    os_type()
    print(lines)
    print("This is Thieves's Current Roaster for LCS.")
    print(lines)
    sleep()
    print(' ')
    print("In the Top Lane "+ thieves.Top)
    print("In the Jungle "+ thieves.Jungle)
    print("In the Mid Lane "+ thieves.Mid)
    print("In the Bot Lane "+ thieves.Bot)
    print("In the Support Role "+ thieves.Sup)

def CLG():
    class CLG:
        Top='Finn'
        Jungle='Broxah'
        Mid='Pobelter'
        Bot='WildTurtle'
        Sup ='Smoothie'
    clg=CLG
    os_type()
    print(lines)
    print("This is CLG's Current Roaster for LCS.")
    print(lines)
    sleep()
    print(' ')
    print("In the Top Lane "+ clg.Top)
    print("In the Jungle "+ clg.Jungle)
    print("In the Mid Lane "+ clg.Mid)
    print("In the Bot Lane "+ clg.Bot)
    print("In the Support Role "+ clg.Sup)

def Dignitas():
    class Dignitas:
        Top='FakeGod'
        Jungle='Dardoch'
        Mid='Soligo'
        Bot='Neo'
        Sup ='aphromoo'
    dig=Dignitas
    os_type()
    print(lines)
    print("This is Dignitas's Current Roaster for LCS.")
    print(lines)
    sleep()
    print(' ')
    print("In the Top Lane "+ dig.Top)
    print("In the Jungle "+ dig.Jungle)
    print("In the Mid Lane "+ dig.Mid)
    print("In the Bot Lane "+ dig.Bot)
    print("In the Support Role "+ dig.Sup)

def Evil_Geniuses():
    class Evil_Geniuses:
        Top='Impact'
        Jungle='Svenskeren'
        Mid='Jiizuke'
        Bot='Deftly'
        Sup ='IgNar'
    eg=Evil_Geniuses
    os_type()
    print(lines)
    print("This is Evil Geniuses's Current Roaster for LCS.")
    print(lines)
    sleep()
    print(' ')
    print("In the Top Lane "+ eg.Top)
    print("In the Jungle "+ eg.Jungle)
    print("In the Mid Lane "+ eg.Mid)
    print("In the Bot Lane "+ eg.Bot)
    print("In the Support Role "+ eg.Sup)

def Fly_Quest():
    class Fly_Quest:
        Top='Licorice'
        Jungle='Josedeodo'
        Mid='Palafox'
        Bot='Johnsun'
        Sup ='Diamond'
    fly=Fly_Quest
    os_type()
    print(lines)
    print("This is Fly Quest's Current Roaster for LCS.")
    print(lines)
    sleep()
    print(' ')
    print("In the Top Lane "+ fly.Top)
    print("In the Jungle "+ fly.Jungle)
    print("In the Mid Lane "+ fly.Mid)
    print("In the Bot Lane "+ fly.Bot)
    print("In the Support Role "+ fly.Sup)

def Golden_Guardians():
    class Golden_Guardians:
        Top='Niles'
        Jungle='Iconic'
        Mid='Ablazeolive'
        Bot='Stixxay'
        Sup ='Newbie'
    gg=Golden_Guardians
    os_type()
    print(lines)
    print("This is Golden Guardians's Current Roaster for LCS.")
    print(lines)
    sleep()
    print(' ')
    print("In the Top Lane "+ gg.Top)
    print("In the Jungle "+ gg.Jungle)
    print("In the Mid Lane "+ gg.Mid)
    print("In the Bot Lane "+ gg.Bot)
    print("In the Support Role "+ gg.Sup)

def start():
    print('Hello Welcome to my program, I hope you enjoy it! ^_^')
    print("Coded by Luisalberto Castaneda, 4/23/2021")
    print('------------------------------------------------------')
    sleep()
    print("Choose an LCS team who's roaster you wish to see")
    print(teams)

start()

User_input_request = "Choose another team or quit to leave\n"
User_input = input()

while True:
    if (User_input == 'tl'):
        Team_Liquid()
        options()
        User_input = input(User_input_request)
    elif(User_input == 'c9'):
        Cloud_9()
        options()
        User_input = input(User_input_request)
    elif(User_input=='tsm'):
        TSM()
        options()
        User_input = input(User_input_request)
    elif(User_input == 'thieves'):
        Thieves()
        options()
        User_input = input(User_input_request)
    elif(User_input=='clg'):
        CLG()
        options()
        User_input = input(User_input_request)
    elif(User_input=='dig'):
        Dignitas()
        options()
        User_input = input(User_input_request)
    elif(User_input=='eg'):
        Evil_Geniuses()
        options()
        User_input = input(User_input_request)
    elif(User_input=='fly'):
        Fly_Quest()
        options()
        User_input = input(User_input_request)
    elif(User_input=='gg'):
        Golden_Guardians()
        options()
        User_input = input(User_input_request)
    elif(User_input=='quit'):
        print('GoodBye\nPlease do comeback\n^_^')
        time.sleep(4)
        break
    else:
        os_type()
        print('not a valid response')
        options()
        User_input = input()

# need and algorhtom
# need a video
