using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace KK.KKBlog.Business.Tools.LogTool
{
    public class NLogAdapter:ICustomLogger
    {
        public void LogError(string message)
        {
            var logger = LogManager.GetLogger("fileLogger");
            logger.Log(LogLevel.Error, message);
        }
    }
}
