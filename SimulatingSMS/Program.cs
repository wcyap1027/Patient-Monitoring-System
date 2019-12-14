using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;
using Patient_Monitoring_System.Class;
namespace SimulatingSMS
{
    class Program
    {
        private static int id = 0;
        private static int duplicateId = 0;
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 1000;
            timer.Start();
            Console.ReadKey();
        }

        public static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            SMSHandler sMSHandler = new SMSHandler();
            SMS sms = new SMS();
            int lastId = sMSHandler.getLastId(dBc.getConn());
            id = lastId;
            if(id != 0)
            {
                sms = sMSHandler.getSMSLog(dBc.getConn(), id);
                Console.WriteLine("=================================" +
                    Environment.NewLine + "Sent To: " + sms.StaffId +
                    Environment.NewLine + "Message: " + sms.Description +
                    Environment.NewLine + "Date Time Sent: " + sms.DateTimeSent.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine);
                
            }
            else
            {
                Console.ReadKey();
            }
            
        }
    }
}
