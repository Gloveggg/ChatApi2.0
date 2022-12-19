using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//test 1 Shulyanov
namespace ChatApi.Models
{
    public partial class ChatMessage
    {
        private user17Entities1 db = new user17Entities1();
        
        public string GetMessage
        {
            get
            {
                
                var emp = db.Employee.Where(i => i.id == idEmployee).FirstOrDefault();
                string message = $"[{DateTime?.Date} {DateTime?.Hour}:{DateTime?.Minute}:{DateTime?.Second}] {emp.FullName}: {TextMessage}";
                return message;
            }
        }
    }
}