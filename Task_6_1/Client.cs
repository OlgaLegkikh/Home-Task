using System;
namespace Task_6_1
{
    public class Client
    {

        public delegate void NewsHadler(string message);
        public event NewsHadler Notify;
        public string ClientName;
        public string ClientEmail;
        public int[] ClientNewsTypes;

        public Client(string clientName, string clientEmail, int[] clientNewsTypes)
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