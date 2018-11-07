import socket

data = ("localhost", 12345)
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server.bind(data)
server.listen(1)

conn, addr = server.accept()

byteS = bytearray()
byteS.append(0x00000010)
byteS.append('h')
byteS.append('e')
byteS.append('y')
byteS.append('\n')

conn.send(byteS)

server.close()
