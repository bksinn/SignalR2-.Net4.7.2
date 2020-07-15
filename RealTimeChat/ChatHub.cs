using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }

        public void LogError(ErrorModel errorModel)
        {
            Clients.All.logErrorToPage(errorModel);
        }
    }
    public class ErrorModel
    {
        public string Message { get; set; }
        public string Source { get; set; }
        public int LineNo { get; set; }
        public int ColNo { get; set; }
        public string Error { get; set; }
    }
}