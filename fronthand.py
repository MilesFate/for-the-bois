from backhand import lap,Team_Liquid,Cloud_9,TSM,Thieves,CLG,Dignitas,Evil_Geniuses,Fly_Quest,Golden_Guardians
from start import start
import time

start()

kappa = "Choose another team or quit to leave\n"
xd = input()

while True:
    if (xd == 'tl'):
        Team_Liquid()
        lap()
        xd = input(kappa)
    elif(xd == 'c9'):
        Cloud_9()
        lap()
        xd = input(kappa)
    elif(xd=='tsm'):
        TSM()
        lap()
        xd = input(kappa)
    elif(xd == 'thieves'):
        Thieves()
        lap()
        xd = input(kappa)
    elif(xd=='clg'):
        CLG()
        lap()
        xd = input(kappa)
    elif(xd=='dig'):
        Dignitas()
        lap()
        xd = input(kappa)
    elif(xd=='eg'):
        Evil_Geniuses()
        lap()
        xd = input(kappa)
    elif(xd=='fly'):
        Fly_Quest()
        lap()
        xd = input(kappa)
    elif(xd=='gg'):
        Golden_Guardians()
        lap()
        xd = input(kappa)
    elif(xd=='quit'):
        print('GoodBye\nPlease do comeback\n^_^')
        time.sleep(4)
        break
    else:
        print('not a valid response')
        lap()
        xd = input()

