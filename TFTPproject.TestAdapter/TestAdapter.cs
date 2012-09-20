using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using TFTPClientNameSpace;

namespace TFTPproject.TestAdapter
{
    public class TestAdapter
    {
        public static TFTPClient client = null;

        public static string LOCAL_FILE_PATH = createLocalFile();
        public static string REMOTE_FILE_PATH = @"remote.txt";

        public static string createLocalFile()
        {
            string activeDir = @"C:\Users\James Ma\Documents\TFTPTestDir";
            string newPath = System.IO.Path.Combine(activeDir, "subDir");

            // Create the sub folder
            System.IO.Directory.CreateDirectory(newPath);

            // Create a file name, generate a random string
            newPath = System.IO.Path.Combine(newPath, System.IO.Path.GetRandomFileName());

            // Create the file and write to it. Will overwrite the file if it already exists.
            if (!System.IO.File.Exists(newPath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(newPath))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }

            return newPath;
        }

        /// <summary>
        /// State checker pattern method, see: http://msdn.microsoft.com/en-us/library/ee620464.aspx
        /// </summary>
        /// <param name="mode"></param>
        public static void checker(int m)
        {
            if (m != -1)
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual
                    (m, (int)client.tftpClientMode, "TestAdapter mismatch: Model vs Implementation");
        }

        /// <summary>
        /// Initialze the TFTP client. Set the state to be INIT
        /// </summary>
        public static void initializeAdapter()
        {
            client = new TFTPClient("127.0.0.1", 69);
            // Connect to the local server
            client.initialize();
            LOCAL_FILE_PATH = createLocalFile();
        }

        /// <summary>
        /// Send Read Request. It creates the TFTP read request packet, send the packet. INIT --> RRQ_SENT.
        /// </summary>
        /// <param name="remoteFile">The remote file.</param>
        /// <param name="localFile">The local file.</param>
        /// <param name="tftpMode">The TFTP mode, NetAscii, Octet, Mail.</param>
        public static void sendReadRequestAdapter()
        {
            client.sendReadRequest(REMOTE_FILE_PATH, LOCAL_FILE_PATH, TFTPClient.Modes.NetAscii);
        }

        /// <summary>
        /// Receive Data Block from the TFTP server. RRQ_SENT or ACK_SENT --> DATA_RECEIVED.
        /// </summary>
        /// <param name="rcvBuffer">the receiving buffer for return.</param>
        /// <returns>
        /// A int variable that tell the length of the receiving buffer. 
        /// </returns>
        public static void receiveDataBlockAdapter()
        {
            byte[] rcvBuffer;
            client.receiveDataBlock(out rcvBuffer);
        }

        /// <summary>
        /// Send ACK packet to the TFTP server, after successfully receive the data block from the TFTP server. DATA_RECEIVED --> ACK_SENT.
        /// </summary>
        public static void sendACKAdapter()
        {
            client.sendACK();
        }

        /// <summary>
        /// check whether it is time to successfully exit. If yes, current state --> EXIT; otherwise, keep the current state.
        /// </summary>
        /// <param name="len">The length of receving buffer.</param>
        /// <returns>
        /// A bool variable indicating whether it is time to successfully exit. It is TRUE for successfully exit, FALSE for staying in the loop and continuing the file transfer. 
        /// </returns>
        public static bool canGetExitAdapter(int len)
        {
            return client.canGetExit(len);
        }

        /// <summary>
        /// Send Write Request. Create the WRQ packet, send it to the server. INIT --> WRQ_SENT.
        /// </summary>
        /// <param name="remoteFile">The remote file.</param>
        /// <param name="localFile">The local file.</param>
        /// <param name="tftpMode">The TFTP mode.</param>
        /// <param name="sndBuffer">The returned sending buffer.</param>
        public static void sendWriteRequestAdapter()
        {
            byte[] sndBuffer;
            client.sendWriteRequest(REMOTE_FILE_PATH, LOCAL_FILE_PATH, TFTPClient.Modes.NetAscii, out sndBuffer);
        }

        /// <summary>
        /// Send Data Block. ACK_RECEIVED --> DATA_SENT.
        /// </summary>
        /// <param name="fileStream">The file stream for writing the downloading file.</param>
        /// <param name="sndBuffer">The returned sending buffer.</param>
        public static void sendDataBlockAdapter()
        {
            BinaryReader fileStream = new BinaryReader(new FileStream(LOCAL_FILE_PATH, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            byte[] sndBuffer;
            client.sendDataBlock(fileStream, out sndBuffer);
        }

        /// <summary>
        /// Receive ACK from the server. WRQ_SENT or DATA_SENT --> ACK_RECEIVED
        /// </summary>
        /// <param name="rcvBuffer">The receiving buffer.</param>
        /// <returns>
        /// A int variable that tell the length of the receiving buffer. 
        /// </returns>
        public static void receiveACKAdapter()
        {
            byte[] rcvBuffer;
            client.receiveACK(out rcvBuffer);
        }

        /// <summary>
        /// check whether it is time to successfully exit. If yes, current state --> EXIT; otherwise, keep the current state unchanged. 
        /// </summary>
        /// <param name="len">The length of the sending buffer.</param>
        /// <returns>
        /// A bool variable indicating whether it is time to successfully exit. It is TRUE for successfully exit, FALSE for staying in the loop and continuing the file transfer. 
        /// </returns>
        public static bool canPutExitAdapter(int len)
        {
            return client.canPutExit(len);
        }
    }
}
