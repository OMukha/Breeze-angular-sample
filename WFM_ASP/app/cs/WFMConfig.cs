﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WFM
{
    /// <summary>
    /// Класс для доступа к параметрам конфигурации
    /// </summary>
    public class BASampleConfig
    {
        /// <summary>
        /// Порт на котором доступен jasper-сервер
        /// </summary>        
        internal static int GetJasperPort()
        {
            int portNum = 8080;
            string port = ConfigurationManager.AppSettings["jasperPort"];
            if (port != null)
                int.TryParse(port, out portNum);
            return portNum;
        }

        internal static bool AD_Off()
        {
            string adOff = ConfigurationManager.AppSettings["ADAuth"];
            return adOff == "Off";
        }
    }
}