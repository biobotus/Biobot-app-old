import asyncore
import logging

class TCPServer(asyncore.dispatcher):
    """Receives connections and establishes handlers for each client.
    """
    
    def __init__(self, address):
        self.tcpServerHandler = []
        self.logger = logging.getLogger('EchoServer')
        asyncore.dispatcher.__init__(self)
        self.create_socket(socket.AF_INET, socket.SOCK_STREAM)
        self.bind(address)
        self.address = self.socket.getsockname()
        self.logger.debug('binding to %s', self.address)
        self.listen(1)
        return

    def handle_accept(self):
        # Called when a client connects to our socket
        client_info = self.accept()
        self.logger.debug('handle_accept() -> %s', client_info[1])
        self.tcpServerHandler = TCPServerHandler(sock=client_info[0])
        self.tcpServerHandler.send('A')
        self.send()
        return
    
    def handle_close(self):
        self.logger.debug('handle_close()')
        self.close()
        return
		
    def send(self):
	
        self.tcpServerHandler.send('a')
		
class TCPServerHandler(asyncore.dispatcher):
    """Handles echoing messages from a single client.
    """
    
    def __init__(self, sock, chunk_size=256):
        self.chunk_size = chunk_size
        self.logger = logging.getLogger('tcpServerHandler%s' % str(sock.getsockname()))
        asyncore.dispatcher.__init__(self, sock=sock)
        self.data_to_write = []
        return
    
    def writable(self):
        """We want to write if we have received data."""
        response = bool(self.data_to_write)
        self.logger.debug('writable() -> %s', response)
        return response
    
    def handle_write(self):
        """Write as much as possible of the most recent message we have received."""
        data = self.data_to_write.pop()
        sent = self.send(data[:self.chunk_size])
        if sent < len(data):
            remaining = data[sent:]
            self.data.to_write.append(remaining)
        self.logger.debug('handle_write() -> (%d) "%s"', sent, data[:sent])

    def handle_read(self):
        """Read an incoming message from the client and put it into our outgoing queue."""
        data = self.recv(self.chunk_size)
        self.logger.debug('handle_read() -> (%d) "%s"', len(data), data)
        #TODO: treat data until EOF
        self.data_to_write.append(data)
    
    def handle_close(self):
        self.logger.debug('handle_close()')
        self.close()

		
if __name__ == '__main__':
    import socket

    logging.basicConfig(level=logging.DEBUG,
                        format='%(name)s: %(message)s',
                        )

    address = ('localhost', 3000) # let the kernel give us a port
    server = TCPServer(address)
    asyncore.loop()
	