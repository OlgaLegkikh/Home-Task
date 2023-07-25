using System;
namespace Task_6_1
{
    public class Client
    {

        public delegate void NewsHandler(string message);
        public event NewsHandler Notify;
        public string ClientName;
        public string ClientEmail;
        public NewsTypes ClientNewsTypes;

        public Client(string clientName, string clientEmail, NewsTypes clientNewsTypes)
        {
            ClientName = clientName;
            ClientEmail = clientEmail;
            ClientNewsTypes = clientNewsTypes;
        }

        public void PushNotify()
        {
            Notify?.Invoke($"Получено новое сообщение  на {this.ClientEmail}. проверьте почту!");
        }

    }
}