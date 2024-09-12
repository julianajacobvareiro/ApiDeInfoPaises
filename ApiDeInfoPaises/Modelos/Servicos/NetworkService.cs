using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiDeInfoPaises.Modelos.Servicos
{
    public class NetworkService
    {


        public Response CheckConnection()
        {


            var cliente = new WebClient();
            try
            {
                using (cliente.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return new Response
                    {
                        IsSuccess = true,
                    };
                }
            }
            catch
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Configure sua ligação à internet"
                };
            }

        }

        public bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                            return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

    }
}

