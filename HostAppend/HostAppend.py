

#path = "C:\\Windows\\System32\\drivers\\etc\\hosts"
path = 'test.txt'
first_line = "127.0.0.1 bnet-emu.fish\n"
second_line = "127.0.0.1 us.game.bwattle.uwu\n"
first_line_exists = False
second_line_exists = False
with open(path, 'r') as hosts:
    content = hosts.readlines()
with open(path, 'a') as hosts:
    if(not first_line in content):
        hosts.write("\n"+first_line)
    if(not second_line in content):
        hosts.write(second_line)

print(content)