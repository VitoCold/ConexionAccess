using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WPF.DataAccess
{
    public class BaseDA
    {
        public string GetCnxStringColegio
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["cnxStringColegio"].ConnectionString;
            }

        }

    }
}
