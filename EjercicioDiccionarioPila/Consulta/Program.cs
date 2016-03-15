using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Net;
using System.Net.Mail;



namespace Consulta
{

    
    class Program
    {
    public static Dictionary<string, string> DiciClientes = new Dictionary<string, string>();
    public static  Stack<string> pedido = new Stack<string>();
    public static int contador = 0;
        public static string line = "";

        static void Main(string[] args)
        {
            CrearDicionario();
            PedidoCliente();
            EnviarEmail();

        }

       public static void EnviarEmail()
        {
           var MailFrom = new MailAddress("juan.marin@yuxipacific.com");
           string Subject = "Pedido";
            string Message = "";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new
            NetworkCredential("juan.marin@yuxipacific.com", "2016Seremillonario");
         
            smtp.EnableSsl = true;

            foreach (KeyValuePair<string, string> Kvp in DiciClientes)
                {
                 Console.WriteLine("Key = {0}, Value = {1}", Kvp.Key, Kvp.Value); contador++;

                 Message = "Buenas Tardes, " + " " + Kvp.Value +" " + "Su pedido es:" + " " + pedido.Pop()+ " " + "Sera despachado en" + " " + contador + " " +"Dias";
                   MailMessage mail = new MailMessage(MailFrom, new MailAddress(Kvp.Key));
                   mail.Subject = Subject;
                   mail.Body = Message;
                   smtp.Send(mail);
                   Console.ReadKey();
                    
                }
        }
       
        public static void PedidoCliente()
        {
          
            StreamReader Lect = new StreamReader("C:/Users/Yuxi.p/Documents/Visual Studio 2013/Projects/Consulta/Consulta/bin/Debug/pedidos.txt");
            if (Lect != null)
            {
                for (int i = 0; i < 11; i++)
                {
                    string Linea = Lect.ReadLine();
                    string[] delimitar = Linea.Split(',');
                    pedido.Push(delimitar[1]);
                                    
                  
                }


            }
        }

       public static void CrearDicionario()
        {
           ;

            StreamReader Lect = new StreamReader("C:/Users/Yuxi.p/Documents/Visual Studio 2013/Projects/Consulta/Consulta/bin/Debug/clientes.txt");

            if (Lect != null)
            {
                 for (int i = 0; i < 11; i++)
                
                {

                    string Linea = Lect.ReadLine();
                    string[] delimitar = Linea.Split(',');
                    DiciClientes.Add(delimitar[0], delimitar[1]);
                }

                //foreach (KeyValuePair<string, string> Kvp in DiciClientes)
                //{
                //    Console.WriteLine("Key = {0}, Value = {1}", Kvp.Key,Kvp.Value);
                //    Console.ReadLine();
                //    Console.ReadKey();
                    
                //}
               
            }
           

        }

    }

    }


    

