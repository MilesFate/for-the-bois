from pip._vendor import requests
import time
# https://discord.com/api/v8/channels/750571361646280708/messages test server
# https://discord.com/api/v8/channels/698337570274279439/messages williams: general
# https://discord.com/api/v8/channels/754439239625605280/messages william: spam channel
# https://discord.com/api/v8/channels/764677560667602954/messages kappa pride: bot commands

#this is the message sent, can be text, gifs, and videos
payload = {
    'content' : "*your message here*"
}

#this lets the script use the account
header = {
    'authorization': 'account authorization code here'
}

#this is what sends the message
i = 0
while True:
    r = requests.post('https://discord.com/api/v8/channels/754439239625605280/messages',data= payload,headers=header)
    r = requests.post('https://discord.com/api/v8/channels/750571361646280708/messages',data= payload,headers=header)
    time.sleep(300)
    if i == 20:
        break
    i += 1 
