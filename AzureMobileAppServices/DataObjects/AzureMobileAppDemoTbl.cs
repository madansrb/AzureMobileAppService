using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureMobileAppServices.DataObjects
{
    public class AzureMobileAppDemoTbl : EntityData
    {
        public int studentid { get; set; }
        public string name { get; set; }
    }
}