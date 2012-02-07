﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Octgn
{
    public class TraceEvent
    {
        public object[] Args;
        public TraceEventCache Cache;
        public string Format;
        public int ID;
        public String Message;
        public string Source;
        public TraceEventType Type;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("<{0}>", Type);
            if (Cache != null)
                if (Cache.DateTime != null)
                    sb.AppendFormat("[{0} {1}]", Cache.DateTime.ToShortTimeString(), Cache.DateTime.ToShortDateString());
            if (Source != null)
                sb.AppendFormat("'{0}'", Source);
            sb.Append(ID);
            sb.Append(" - ");
            if (Message == null && Args != null && Format != null)
            {
                sb.AppendFormat(Format, Args);
            }
            else
            {
                sb.Append(Message);
            }
            return sb.ToString();
        }
    }

    public class CacheTraceListener : TraceListener
    {
        #region Delegates

        public delegate void EventAdded(TraceEvent te);

        #endregion

        public CacheTraceListener()
        {
            Events = new List<TraceEvent>();
        }

        public List<TraceEvent> Events { get; set; }
        public event EventAdded OnEventAdd;

        public override void Write(string message)
        {
            var te = new TraceEvent();
            te.Cache = new TraceEventCache();
            te.Message = message;
            te.Type = TraceEventType.Information;
            Events.Add(te);
            if (OnEventAdd != null)
                OnEventAdd.Invoke(te);
        }

        public override void WriteLine(string message)
        {
            var te = new TraceEvent();
            te.Cache = new TraceEventCache();
            te.Message = message + Environment.NewLine;
            te.Type = TraceEventType.Information;
            Events.Add(te);
            if (OnEventAdd != null)
                OnEventAdd.Invoke(te);
        }

        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id,
                                        string message)
        {
            var te = new TraceEvent();
            te.Cache = eventCache;
            te.Source = source;
            te.Type = eventType;
            te.ID = id;
            te.Message = message;
            Events.Add(te);
            if (OnEventAdd != null)
                OnEventAdd.Invoke(te);
        }

        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id)
        {
            var te = new TraceEvent();
            te.Cache = eventCache;
            te.Source = source;
            te.Type = eventType;
            te.ID = id;
            Events.Add(te);
            if (OnEventAdd != null)
                OnEventAdd.Invoke(te);
        }

        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id,
                                        string format, params object[] args)
        {
            var te = new TraceEvent();
            te.Cache = eventCache;
            te.Source = source;
            te.Type = eventType;
            te.ID = id;
            te.Format = format;
            te.Args = args;
            Events.Add(te);
            if (OnEventAdd != null)
                OnEventAdd.Invoke(te);
        }
    }
}