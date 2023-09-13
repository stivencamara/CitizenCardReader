using System;
using System.Collections.Generic;
using System.Diagnostics;
using CCR.Exceptions;
using PCSC;
using PCSC.Exceptions;
using PCSC.Monitoring;

//https://github.com/danm-de/pcsc-sharp

namespace CCR
{
    public enum CardReaderStatusChange
    {
        CardInserted,
        CardRemoved
    }

    public class CardReaderStatusChangeEventArgs
    {
        public CardReaderStatusChangeEventArgs(CardReaderStatusChange status)
        {
            Status = status;
        }
        public CardReaderStatusChange Status { get; }
    }

    public class CardReaderMonitor
    {
        public delegate void CardReaderStatusChangeHandler(object sender, CardReaderStatusChangeEventArgs e);

        public event CardReaderStatusChangeHandler StatusChange;

        public void Start()
        {
            using (var context = ContextFactory.Instance.Establish(SCardScope.System))
            {
                var readerNames = context.GetReaders();

                if (IsEmpty(readerNames))
                    throw new CardMonitorException("Reader not found");

                using (var monitor = MonitorFactory.Instance.Create(SCardScope.System))
                {
                    AttachToAllEvents(monitor);
                    monitor.Start(readerNames);

                    while (true)
                    {
                        Debug.WriteLine("Monitoring...");
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
        }

        private void AttachToAllEvents(ISCardMonitor monitor)
        {
            monitor.CardInserted += (sender, args) => CardInserted(args);
            monitor.CardRemoved += (sender, args) => CardRemoved(args);
            monitor.Initialized += (sender, args) => Initialized(args);
            monitor.StatusChanged += StatusChanged;
            monitor.MonitorException += MonitorException;
        }

        private void CardRemoved(CardStatusEventArgs args)
        {
            Debug.WriteLine("CardRemoved: {0}", args.ReaderName);
            StatusChange?.Invoke(this, new CardReaderStatusChangeEventArgs(CardReaderStatusChange.CardRemoved));
        }

        private void CardInserted(CardStatusEventArgs args)
        {
            Debug.WriteLine("CardInserted: {0}", args.ReaderName);
            StatusChange?.Invoke(this, new CardReaderStatusChangeEventArgs(CardReaderStatusChange.CardInserted));
        }

        private static void Initialized(CardStatusEventArgs args)
        {
            Debug.WriteLine("Initialized: {0}", args.ReaderName);
        }

        private static void StatusChanged(object sender, StatusChangeEventArgs args)
        {
            Debug.WriteLine("Last state: {0}\nNew state: {1}\n", args.LastState, args.NewState);
        }

        private static void MonitorException(object sender, PCSCException ex)
        {
            Debug.WriteLine(ex.Message);
            throw new CardMonitorException(ex);
        }

        private bool IsEmpty(ICollection<string> readerNames) => readerNames == null || readerNames.Count < 1;
    }
}
