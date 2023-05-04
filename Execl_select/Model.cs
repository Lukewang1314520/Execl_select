using DevExpress.Xpo;
using System;

namespace Execl_select
{
    public class SN_PCB
    {
        public string SN
        {
            set; get;
        }
        public string REELID
        {
            set; get;
        }
    }

    public class ReelInfo
    {
        public string IMEI
        {
            set; get;
        }
        public string Pannel
        {
            set; get;
        }
        public string CompName
        {
            set; get;
        }
        public string DC
        {
            set; get;
        }
        public string LotNober
        {
            set; get;
        }
    }

    public class model
    {
        public static string Chosetime
        {
            set; get;
        }
        public string Weizhi
        {
            set; get;
        }
        public static string UserID
        {
            get; set;
        }
    }

    public class Imei_Pannel
    {
        public  string IMEI
        {
            set; get;
        }
        public string Pannel
        {
            set; get;
        }
    }
    public class QWSQ_Pannel
    {
        public string QWSQ
        {
            set; get;
        }
        public string Order
        {
            set; get;
        }
        public string CompName
        {
            set; get;
        }
        public string DC
        {
            set; get;
        }
        public string LotNober
        {
            set; get;
        }
    }
}