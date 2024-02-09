using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EncryptionTool.Models.DTOModels
{
    public class DTOEncrypt
    {
        public string PlainText { get; set; }
        public int Shift { get; set; }
    }
}