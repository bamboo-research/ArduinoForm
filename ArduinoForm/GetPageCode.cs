using System;
using System.Collections.Generic; 
using System.Text;
using System.Net;
using System.IO;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace Frank
{
  public  class GetPageCode
    {
        public static string GetWebPageCode(string url, string encoding)
        {
            string res = string.Empty;
            try
            {

                WebRequest request = WebRequest.Create(url);
                request.Method = "GET";
                request.Timeout = 9000;
                request.Credentials = CredentialCache.DefaultCredentials; 
                request.ContentType = "application/x-www-form-urlencoded";
                ((HttpWebRequest)request).Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,text/vnd.wap.wml;q=0.6,*/*;q=0.5,UC/145,plugin/1,alipay/un";
                //" image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, */*";
                ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (Linux; U; Android 4.2.1; zh-CN; M353 Build/JOP40D) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 UCBrowser/9.8.0.435 U3/0.8.0 Mobile Safari/533.1";
                //"Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; CIBA; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
                ((HttpWebRequest)request).Referer = "http://www.baidu.com";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                

                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream, Encoding.GetEncoding(encoding));

                res = reader.ReadToEnd();

                reader.Close();

                dataStream.Close();

                response.Close();




            }
            catch (Exception we)
            {
                return string.Empty;
            }

            return res;
        }
       
        public static string GetPageCodeByPost(string url, string postData, string encoding)
        {
            try
            {
                string res = string.Empty;
                byte[] paramByte = Encoding.GetEncoding(encoding).GetBytes(postData); // 转化
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);

                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.Referer = url;
                webRequest.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, */*";
                webRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; CIBA; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
                webRequest.ContentLength = paramByte.Length;
                Stream readStream = webRequest.GetRequestStream();
                readStream.Write(paramByte, 0, paramByte.Length);    //写入参数
                readStream.Close();
                WebResponse response = webRequest.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                res = reader.ReadToEnd();
                reader.Close();
                return res;
            }
            catch (Exception we)
            {
                return we.ToString() ;
            }

        }
       
        public static string getCodeMobile(string url, string encoding)
        {

            try
            {
                string res = string.Empty;

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);

                //webRequest.Method = "Get";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.Referer = "http://www.baidu.com";
                //mobile header
                webRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,text/vnd.wap.wml;q=0.6,*/*;q=0.5,UC/145,plugin/1,alipay/un";
                //" image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, */*";
                webRequest.UserAgent = "Mozilla/5.0 (Linux; U; Android 4.2.1; zh-CN; M353 Build/JOP40D) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 UCBrowser/9.8.0.435 U3/0.8.0 Mobile Safari/533.1"; 
                //"Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; CIBA; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
                webRequest.AllowAutoRedirect = true;
                WebResponse response = webRequest.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                res = reader.ReadToEnd();
                reader.Close();
                return res;
            }
            catch (Exception ew)
            {
                return ew.ToString();

            }
        }
       
        public static string getCode(string url, string encoding)
        {
           return  getCodePC(url,encoding);
        }

        public static string getCodePC(string url, string encoding)
        {

            try
            {
                string res = string.Empty;

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);

                //webRequest.Method = "Get";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.Referer = "http://www.baidu.com";
                //mobile header
                webRequest.Accept ="image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, */*";
                webRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; CIBA; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
                webRequest.AllowAutoRedirect = true;
                WebResponse response = webRequest.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                res = reader.ReadToEnd();
                reader.Close();
                return res;
            }
            catch (Exception ew)
            {
                return ew.ToString();

            }
        }


        public static string GetPageCodeByPost(string url, Hashtable param, ref CookieContainer cc, string encoding)
        {
            CookieCollection cookies = new CookieCollection();
            return GetPageCodeByPost(url, param, ref cc, encoding, url, out cookies,false);
        }
        public static string GetPageCodeByPost(string url, Hashtable param, ref CookieContainer cc, string encoding,bool isSSL)
        {
            CookieCollection cookies = new CookieCollection();
            return GetPageCodeByPost(url, param, ref cc, encoding, url, out cookies,isSSL);
        }
        public static string GetPageCodeByPost(string url, Hashtable param, ref CookieContainer cc, string encoding, out CookieCollection cookies)
        {
            return GetPageCodeByPost(url, param, ref cc, encoding, url, out cookies, false);

        } 
      public static string GetPageCodeByPost(string url, Hashtable param, ref CookieContainer cc, string encoding, out CookieCollection cookies,bool isSSL)
        {
            
           return  GetPageCodeByPost(url,param,ref cc,encoding,url,out cookies,isSSL);

        }
        public static string GetPageCodeByPost(string url, Hashtable param, ref CookieContainer cc, string encoding, string refurl)
        {
            CookieCollection cookies = new CookieCollection();
            return GetPageCodeByPost(url, param, ref cc, encoding, refurl, out cookies, false);
        }  
      public static string GetPageCodeByPost(string url, Hashtable param, ref CookieContainer cc, string encoding, string refurl,bool isSSL)
        {
            CookieCollection cookies = new CookieCollection();
            return GetPageCodeByPost(url, param, ref cc, encoding, refurl, out cookies,isSSL);
        }
        public static string GetPageCodeByPost(string url, Hashtable param, ref CookieContainer cc, string encoding,string refurl,out CookieCollection cookies,bool isSSL)
        {
            try
            {
                string formData = string.Empty;
                foreach (System.Collections.DictionaryEntry de in param)
                {
                    formData += de.Key.ToString() + "=" + System.Web.HttpUtility.UrlEncode(de.Value.ToString(),Encoding.GetEncoding(encoding)) + "&";
                }
                if (formData.Length > 0)
                    formData = formData.Trim('&');
                string res = string.Empty;
                byte[] paramByte = Encoding.GetEncoding(encoding).GetBytes(formData); // 转化


                 
                HttpWebRequest webRequest;
                if (isSSL)
                {
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                    webRequest = WebRequest.Create(url) as HttpWebRequest;
                    webRequest.ProtocolVersion = HttpVersion.Version10;
                }
                else
                    webRequest = (HttpWebRequest)WebRequest.Create(url);


                webRequest.CookieContainer = cc;
                //
                webRequest.Credentials = CredentialCache.DefaultCredentials;

                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.Referer = refurl;

                webRequest.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, */*";
                webRequest.UserAgent = "Mozilla/4.0 (compatible;MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; CIBA; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
                webRequest.ContentLength = paramByte.Length;
                webRequest.KeepAlive = true;
                //
                webRequest.UseDefaultCredentials = true;
                // ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3; 

                webRequest.AllowAutoRedirect = true;//do not

                //webRequest.PreAuthenticate=true;//
                //webRequest.UseDefaultCredentials=true;

                Stream readStream = webRequest.GetRequestStream();
                readStream.Write(paramByte, 0, paramByte.Length);    //写入参数
                readStream.Close();
                WebResponse response = webRequest.GetResponse();
                HttpWebResponse resp = (HttpWebResponse)response;

               cookies=resp.Cookies;

                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                res = reader.ReadToEnd();
                reader.Close();
                return res;
            }
            catch (Exception we)
            {
                cookies=new CookieCollection();
                return we.ToString();
            }

        }
        

        public static string GetWebPageCode(string url, ref CookieContainer cc, string encoding)
        {
            CookieCollection cookies = new CookieCollection();
            return GetWebPageCode(url, ref cc, encoding, out cookies,false,string.Empty);
        }
        public static string GetWebPageCode(string url, ref CookieContainer cc, string encoding,string refUrl)
        {
            CookieCollection cookies = new CookieCollection();
            return GetWebPageCode(url, ref cc, encoding, out cookies, false,refUrl);
        }
        public static string GetWebPageCode(string url, ref CookieContainer cc, string encoding,bool isSSL)
        { 
            return GetWebPageCode(url, ref cc, encoding,isSSL,true);
        }
        public static string GetWebPageCode(string url, ref CookieContainer cc, string encoding, bool isSSL, bool isRedirect)
        {
            CookieCollection cookies = new CookieCollection();
            return GetWebPageCode(url, ref cc, encoding, out cookies, isSSL, string.Empty, isRedirect);
        }
        public static string GetWebPageCode(string url, ref CookieContainer cc, string encoding, bool isSSL,string refUrl)
        {
            CookieCollection cookies = new CookieCollection();
            return GetWebPageCode(url, ref cc, encoding, out cookies, isSSL, refUrl, true);
        }
        public static string GetWebPageCode(string url, ref CookieContainer cc, 
            string encoding, bool isSSL, string refUrl,bool isRedirect)
        {
            CookieCollection cookies = new CookieCollection();
            return GetWebPageCode(url, ref cc, encoding, out cookies, isSSL, refUrl, isRedirect);
        }
        public static string GetWebPageCode(string url, ref CookieContainer cc, string encoding, out CookieCollection cookies)
        {
            return GetWebPageCode(url,ref cc,encoding,out cookies,false,string.Empty);
        }
       
        public static string GetWebPageCode(string url, ref CookieContainer cc, 
            string encoding, out CookieCollection cookies, bool isSSL)
        {
            return GetWebPageCode(url,ref cc,encoding,out cookies,isSSL,string.Empty);
        }
        public static string GetWebPageCode(string url, ref CookieContainer cc, string encoding,
              out CookieCollection cookies, bool isSSL, string refUrl)
        {
            return GetWebPageCode(url, ref cc, encoding, out cookies, isSSL, string.Empty, true);
        }
        public static string GetWebPageCode(string url,ref CookieContainer cc, string encoding,
            out CookieCollection cookies, bool isSSL, string refUrl, bool isRedirect)
        {
            string res = string.Empty;
            try
            {
                HttpWebRequest request;
                if (isSSL)
                {
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                    request = WebRequest.Create(url) as HttpWebRequest;
                    request.ProtocolVersion = HttpVersion.Version10;
                }
                else
                    request = (HttpWebRequest)WebRequest.Create(url);

               
                request.Method = "GET";
                request.Timeout = 1000*30;
                request.Credentials = CredentialCache.DefaultCredentials;
                request.CookieContainer = cc;

                request.ContentType = "application/x-www-form-urlencoded";
                request.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, */*";
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; CIBA; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
                request.Accept = "text/html, application/xhtml+xml, */*";// "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, */*";
                //request.Headers.Add("Accept-Encoding", " gzip, deflate");
                //request.Headers.Add("Accept-Language", " zh-Hans-CN,zh-Hans;q=0.5");

                request.Referer = string.IsNullOrEmpty(refUrl) ? url : refUrl;
                request.AllowAutoRedirect = isRedirect;
                request.MaximumAutomaticRedirections = 9;
                request.KeepAlive = true;
                //request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip; 
                

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                 
                //带出cookie
                cookies = response.Cookies;

                 

                Stream dataStream = response.GetResponseStream();
               

                StreamReader reader = new StreamReader(dataStream, Encoding.GetEncoding(encoding));

                res = reader.ReadToEnd();

                reader.Close();

                dataStream.Close();

                response.Close();

               

                  
            }
            catch (Exception we)
            {
                cookies = new CookieCollection();
                return string.Empty;
            }

            return res;
        }

        public static string GetWebPageCode(string url, ref CookieContainer cc, string encoding,
             out string RedirectUrl)
        {
            string res = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);


                request.Method = "GET";
                request.Timeout = 1000 * 30;
                request.Credentials = CredentialCache.DefaultCredentials;
                request.CookieContainer = cc;

                request.ContentType = "application/x-www-form-urlencoded";
                request.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, */*";
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; CIBA; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
                request.Accept = "text/html, application/xhtml+xml, */*";// "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, */*";
                //request.Headers.Add("Accept-Encoding", " gzip, deflate");
                //request.Headers.Add("Accept-Language", " zh-Hans-CN,zh-Hans;q=0.5");

                request.Referer = url;
                request.AllowAutoRedirect = true;
                request.MaximumAutomaticRedirections = 9;
                request.KeepAlive = true;
                //request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip; 


                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //RedirectUrl = response.Headers.GetValues("Transport")[0];

                StringBuilder sb = new StringBuilder();
                for(int i=0;i<response.Headers.Count;i++)
                {
                    sb.AppendFormat("key:{0}---value:{1}\r\n", response.Headers.AllKeys[i], response.Headers.Get(response.Headers.AllKeys[i]));
                }
                string h = sb.ToString();
                RedirectUrl = response.Headers.Get("Location");


                Stream dataStream = response.GetResponseStream();


                StreamReader reader = new StreamReader(dataStream, Encoding.GetEncoding(encoding));

                res = reader.ReadToEnd();

                reader.Close();

                dataStream.Close();

                response.Close();




            }
            catch (Exception we)
            {
                RedirectUrl = string.Empty;
            }

            return res;
        }



        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受  
        }

       
       
       



       
        public static  int Upload_Request(string address, string fileNamePath,Hashtable param,ref CookieContainer cc, string saveName )
        {
            string formData = string.Empty;
            foreach (System.Collections.DictionaryEntry de in param)
            {
                formData += de.Key.ToString() + "=" + System.Web.HttpUtility.UrlEncode(de.Value.ToString(), Encoding.UTF8) + "&";
            }
            if (formData.Length > 0)
                formData = formData.Trim('&');
            string res = string.Empty;
            byte[] paramByte = Encoding.UTF8.GetBytes(formData); // 转化
            //------
            int returnValue = 0;
            // 要上传的文件
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            //时间戳
            string strBoundary = "----------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundaryBytes = Encoding.ASCII.GetBytes("/r/n--" + strBoundary + "/r/n");
            //请求头部信息
            StringBuilder sb = new StringBuilder();
            sb.Append("--");
            sb.Append(strBoundary);
            sb.Append("/r/n");
            sb.Append(@"Content-Disposition: form-data; name=/""");
            sb.Append("file");
            sb.Append(@"/"";filename=/");
            sb.Append(saveName);
            sb.Append("/");
            sb.Append("/r/n");
            sb.Append("Content-Type: ");
            sb.Append("application/octet-stream");
            sb.Append("/r/n");
            sb.Append("/r/n");
            string strPostHeader = sb.ToString();
            byte[] postHeaderBytes = Encoding.UTF8.GetBytes(strPostHeader);
            // 根据uri创建HttpWebRequest对象
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(new Uri(address));
            httpReq.Method = "POST";
            httpReq.Credentials = CredentialCache.DefaultCredentials;
            httpReq.CookieContainer = cc;

            //对发送的数据不使用缓存
            httpReq.AllowWriteStreamBuffering = false;
            //设置获得响应的超时时间（300秒）
            httpReq.Timeout = 300000;
            httpReq.ContentType = "multipart/form-data; boundary=" + strBoundary;
            long length = fs.Length + postHeaderBytes.Length + boundaryBytes.Length;
            long fileLength = fs.Length;
            httpReq.ContentLength = length;
            try
            {
                
                //每次上传4k
                int bufferLength = 4096;
                byte[] buffer = new byte[bufferLength];
                //已上传的字节数
                long offset = 0;
                //开始上传时间
                DateTime startTime = DateTime.Now;
                int size = r.Read(buffer, 0, bufferLength);
                Stream postStream = httpReq.GetRequestStream();
                //发送请求头部消息
                postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
                postStream.Write(paramByte, 0, paramByte.Length);

                while (size > 0)
                {
                    postStream.Write(buffer, 0, size);
                    offset += size; 
                    TimeSpan span = DateTime.Now - startTime;
                    double second = span.TotalSeconds; 
                    
                    size = r.Read(buffer, 0, bufferLength);
                }
                //添加尾部的时间戳
                postStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                postStream.Close();
                //获取服务器端的响应
                WebResponse webRespon = httpReq.GetResponse();
                Stream s = webRespon.GetResponseStream();
                StreamReader sr = new StreamReader(s);
                //读取服务器端返回的消息
                String sReturnString = sr.ReadLine();
                s.Close();
                sr.Close();
                if (sReturnString == "Success")
                {
                    returnValue = 1;
                }
                else if (sReturnString == "Error")
                {
                    returnValue = 0;
                }
            }
            catch
            {
                returnValue = 0;
            }
            finally
            {
                fs.Close();
                r.Close();
            }
            return returnValue;
        }


    }
}
