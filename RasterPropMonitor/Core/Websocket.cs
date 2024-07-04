using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JSI
{
    class WebsocketServer
    {
        public async Task Start()
        {
            var listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/connect/");
            listener.Start();

            while (true)
            {
                try
                {
                    var context = await listener.GetContextAsync();
                    //JUtil.LogInfo()
                    if (context.Request.IsWebSocketRequest)
                    {
                        var socket = await context.AcceptWebSocketAsync(subProtocol: null);
                        var socketId = Guid.NewGuid();
                        var socketTask = HandleSocketAsync(socket.WebSocket, socketId);
                    }
                    else
                    {
                        context.Response.StatusCode = 400;
                        context.Response.Close();
                    }
                }
                catch (Exception ex)
                {
                    JUtil.LogMessage(this, ex.ToString());
                }
            }
        }

        private async Task HandleSocketAsync(WebSocket socket, Guid socketId)
        {
            while (socket.State == WebSocketState.Open)
            {
                var buffer = new ArraySegment<byte>(new byte[64]);
                var received = await socket.ReceiveAsync(buffer, CancellationToken.None);

                if (received.MessageType == WebSocketMessageType.Close)
                {
                    await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                }
                else
                {
                    var message = Encoding.UTF8.GetString(buffer.Array, buffer.Offset, buffer.Count);
                    Console.WriteLine("Received message: " + message);

                    var response = Encoding.UTF8.GetBytes("Hello, " + message + "!");
                    buffer = new ArraySegment<byte>(response);
                    await socket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
                }
            }
        }
    }
}
