using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUPPORT1Lib;

namespace BLL
{
    class SupportOCX : Support1
    {
        public string encrypted { get; set; }
        public string unencrypted { get; set; }
        public string passkey { get; set; }

        public int Encrypt()
        {
            throw new NotImplementedException();
        }

        public int Unencrypt()
        {
            throw new NotImplementedException();
        }
    }
}
