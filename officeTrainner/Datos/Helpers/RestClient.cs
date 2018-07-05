using System;
using System.IO;
using System.Net;

namespace Datos.Helpers
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    public class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public string postJSON { get; set; }


        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();

            if ((request.Method == "PUT" || request.Method == "POST") && postJSON != string.Empty)
            {
                request.ContentType = "application/json";
                using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
                {
                    swJSONPayload.Write(postJSON);

                    swJSONPayload.Close();
                }
            }

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                            }
                        }
                    }
                }
                else
                    strResponseValue = "ERROR";
            }
            catch (Exception)
            {
                strResponseValue = "ERROR";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }

        public string makeRequest_GetByUserName()
        {
            string exists = "false";
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = "GET";

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();

                            }

                            if (strResponseValue != "[]")
                            {
                                exists = "true"; //Ya hay un usuario con el mismo nombreusuario
                            }
                            else
                            {
                                exists = "false"; //no hay usuarios con este nombreusuario
                            }
                        }
                    }
                }
                else
                    exists = "ERROR";
            }
            catch (Exception)
            {
                exists = "ERROR";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

            return exists;
        }
    }
}
