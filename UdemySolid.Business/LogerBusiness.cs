using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySolid.Business
{
    // Open/Close uyar



    public interface ILogerBusinness
    {
        bool Log(string value);
    }
    public class LogerBusiness
    {
        private readonly ILogerBusinness _loggerBusinnes;

        public LogerBusiness(ILogerBusinness logerBusinness)
        {
            _loggerBusinnes = logerBusinness;
        }
        public void Log(string value)
        {
            _loggerBusinnes.Log(value);
        }
    }

    // aşağıda ne eklenirse eklensin yukarıda bir dğişiklik olmaz  
    public class XmlLog : ILogerBusinness
    {
        public bool Log(string value)
        {
            //İşlemler 
            return true;
        }
    }

    public class DbLog : ILogerBusinness
    {
        public bool Log(string value)
        {
            //İşlemler 
            return true;
        }
    }
}
/*class Program  Kullanım Senaryosu Örnek
{
    static void Main(string[] args)
    {
        // XML loglama kullanarak örnek
        ILogerBusinness xmlLogger = new XmlLog();
        LogerBusiness logerBusinessWithXml = new LogerBusiness(xmlLogger);
        logerBusinessWithXml.Log("This is an XML log.");

        // DB loglama kullanarak örnek
        ILogerBusinness dbLogger = new DbLog();
        LogerBusiness logerBusinessWithDb = new LogerBusiness(dbLogger);
        logerBusinessWithDb.Log("This is a database log.");
    }
}*/


//  Open/Close uymaz...


/*private readonly XmlLog _XmlLog;
    private readonly DbLog _DbLog;
    private readonly JsonLog _JsonLog;

    public LogerBusiness(XmlLog xmllog, DbLog dblog, JsonLog jsonLog)
    {
        _XmlLog = xmllog;
        _DbLog = dblog;
        _JsonLog = jsonLog;
    }
    public void Log(logType type, string value)
    {
        switch (type)
        {
            case logType.Xml:
                _XmlLog.Log(value);
                break;
            case logType.Db:
                _DbLog.Log(value);
                break;
                case logType.Json:
                    _JsonLog.Log(value);
                break;
            default:
                break;
        }
    }
}

public class XmlLog
{
    public bool Log(string value)
    {
        // işlemler
        return true;
    }
}

public class DbLog
{
    public bool Log(string value)
    {
        // işlemler
        return true;
    }
}
public class JsonLog
{
    public bool Log(string value)
    {
        // işlemler
        return true;
    }
}

public enum logType
{
    Xml,
    Db,
    Json
}*/