using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Modeling;
using TFTPClientNameSpace;
using System.IO;

namespace TFTPproject
{
    static class ModelProgram
    {
        public enum FSM_Modes
        {
            BEFORE_INIT = -1,
            INIT = 0,
            EXIT = 1,
            ERROR = 2,
            RRQ_SENT = 3,
            DATA_RECEIVED = 4,
            ACK_SENT = 5,
            WRQ_SENT = 6,
            ACK_RECEIVED = 7,
            DATA_SENT = 8,
        }

        static FSM_Modes FSM_Mode = FSM_Modes.BEFORE_INIT;

        [Rule(Action = "initializeAdapter()")]
        static void initialize()
        {
            Condition.IsTrue(FSM_Mode == FSM_Modes.BEFORE_INIT);

            FSM_Mode = FSM_Modes.INIT;
        }

        [Rule(Action = "sendReadRequestAdapter()")]
        static void sendReadRequest()
        {
            Condition.IsTrue(FSM_Mode == FSM_Modes.INIT);

            FSM_Mode = FSM_Modes.RRQ_SENT;
        }

        [Rule(Action = "receiveDataBlockAdapter()")]
        static void receiveDataBlock()
        {
            Condition.IsTrue(FSM_Mode == FSM_Modes.RRQ_SENT || FSM_Mode == FSM_Modes.ACK_SENT);

            FSM_Mode = FSM_Modes.DATA_RECEIVED;
        }

        [Rule(Action = "sendACKAdapter()")]
        static void sendACK()
        {
            Condition.IsTrue(FSM_Mode == FSM_Modes.DATA_RECEIVED);

            FSM_Mode = FSM_Modes.ACK_SENT;
        }

        [Rule(Action = "canGetExitAdapter(len)/result")]
        static bool canGetExit(int len)
        {
            Condition.IsTrue(FSM_Mode == FSM_Modes.DATA_RECEIVED);
            if (len < 516)
            {
                FSM_Mode = FSM_Modes.EXIT;
                return true;
            }
            return false;
        }

        [Rule(Action = "sendWriteRequestAdapter()")]
        static void sendWriteRequest()
        {
            Condition.IsTrue(FSM_Mode == FSM_Modes.INIT);

            FSM_Mode = FSM_Modes.WRQ_SENT;
        }

        [Rule(Action = "sendDataBlockAdapter()")]
        static void sendDataBlock()
        {
            Condition.IsTrue(FSM_Mode == FSM_Modes.ACK_RECEIVED);

            FSM_Mode = FSM_Modes.DATA_SENT;
        }

        [Rule(Action = "receiveACKAdapter()")]
        static void receiveACK()
        {
            Condition.IsTrue(FSM_Mode == FSM_Modes.WRQ_SENT || FSM_Mode == FSM_Modes.DATA_SENT);

            FSM_Mode = FSM_Modes.ACK_RECEIVED;
        }

        [Rule(Action = "canPutExitAdapter(len)/result")]
        static bool canPutExit(int len)
        {
            Condition.IsTrue(FSM_Mode == FSM_Modes.DATA_SENT);
            if (len < 516)
            {
                FSM_Mode = FSM_Modes.EXIT;
                return true;
            }
            return false;
        }

        // This is the state where a test can successfully end, leaving the system in a stable state.
        [AcceptingStateCondition]
        static bool exitModeReached()
        {
            if (FSM_Mode == FSM_Modes.EXIT)
                return true;
            return false;
        }

        // State checker pattern, see: http://msdn.microsoft.com/en-us/library/ee620464.aspx
        [Rule]
        static void checker(int m)
        {
            Condition.IsTrue((int)FSM_Mode == m);
        }
    }
}
