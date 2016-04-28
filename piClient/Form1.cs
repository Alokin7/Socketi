using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace piClient
{
    public partial class Form1 : Form
    {
        private Socket netSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netSocketClientArgs = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer = new byte[1024];
        public Form1()
        {
            InitializeComponent();
            netSocket.ExclusiveAddressUse = false;
            netSocketClientArgs.Completed += netSocketClientArgs_Completed;
            netSocketClientArgs.SetBuffer(netSocketBuffer, 0, 1024);
        }

        private void DestinationSetAction_Click(object sender, EventArgs e)
        {
           // DestinationSet(GetDestination());
        }

        private void MessageSendAction_Click(object sender, EventArgs e)
        {
           // MessageSend(MessageToSend.Text);
            ClearMessageInput();
            WriteToLog("Message Sent!");
        }

        void netSocketClientArgs_Completed(object sender, SocketAsyncEventArgs e)
        {
            if (netSocketClientArgs.LastOperation == SocketAsyncOperation.SendTo)
            {
                WriteToLog("Destination: " + netSocketClientArgs.RemoteEndPoint.ToString() + "message: " + UTF8Encoding.UTF8.GetString(netSocketClientArgs.Buffer, 0, e.BytesTransferred));
            }
        }
        private void DestinationSet(IPEndPoint address)
        {
            netSocketClientArgs.RemoteEndPoint = address;
            WriteToLog("Destination set: " + netSocketClientArgs.RemoteEndPoint.ToString());
        }
      //  private IPEndPoint GetDestination()
      //  {
           // return new IPEndPoint(IPAddress.Parse(DestinationAddress.Text.Replace(" ","")),8087);
      //  }
        private void WriteToLog(string message)
        {
          //  ReceiveContainer.Invoke((MethodInvoker)delegate
          //  {
           //     ReceiveContainer.Text = message + Environment.NewLine + ReceiveContainer.Text;
          //  });
        }
        private void MessageSend(string message)
        {
            netSocketBuffer = UTF8Encoding.UTF8.GetBytes(message);
            netSocketClientArgs.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
            netSocket.SendToAsync(netSocketClientArgs);
        }
        private void ClearMessageInput()
        {
          //  MessageToSend.Clear();
        }

        // Ovo ispod je ono sto se je trebalo na mojem labosu napraviti!

        private void Hello_Click(object sender, EventArgs e)
        {
            netSocket.Connect(new IPEndPoint(IPAddress.Loopback, 8087));

            netSocketBuffer = UTF8Encoding.UTF8.GetBytes("Hello");
            netSocketClientArgs.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
            netSocket.SendAsync(netSocketClientArgs);
        }

        private void SendHash_Click(object sender, EventArgs e)
        {
            netSocket.Connect(new IPEndPoint(IPAddress.Loopback, 8087));

            netSocketBuffer = UTF8Encoding.UTF8.GetBytes("68a952ac518");
            netSocketClientArgs.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
            netSocket.SendAsync(netSocketClientArgs);
        }

        private void Validacija_Click(object sender, EventArgs e)
        {
            int broj1;
            int broj2;

            if (int.TryParse(Box1.Text, out broj1) == true && int.TryParse(Box2.Text, out broj2) == true)
            {
                if (broj1%broj2 == 0)
                {
                    netSocket.Connect(new IPEndPoint(IPAddress.Loopback, 8087));

                    netSocketBuffer = UTF8Encoding.UTF8.GetBytes("DA");
                    netSocketClientArgs.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
                    netSocket.SendAsync(netSocketClientArgs);
                }
                else
                {
                    netSocket.Connect(new IPEndPoint(IPAddress.Loopback, 8087));

                    netSocketBuffer = UTF8Encoding.UTF8.GetBytes("NE");
                    netSocketClientArgs.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
                    netSocket.SendAsync(netSocketClientArgs);
                }
            }
        }
    }
}
