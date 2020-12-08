from pip._vendor import requests
import time
# https://discord.com/api/v8/channels/750571361646280708/messages test server
# https://discord.com/api/v8/channels/698337570274279439/messages williams: general
# https://discord.com/api/v8/channels/754439239625605280/messages william: spam channel
# https://discord.com/api/v8/channels/764677560667602954/messages kappa pride: bot commands

payload = {
    'content' : "*Huggie Wuggie big chungus sex lord*"
}

header = {
    'authorization': 'account authorization code here'
}

while True:
    r = requests.post('https://discord.com/api/v8/channels/754439239625605280/messages',data= payload,headers=header)
    r = requests.post('https://discord.com/api/v8/channels/750571361646280708/messages',data= payload,headers=header)
    time.sleep(300)
