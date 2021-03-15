using BALCRUD;
using EntityCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace apiTest
{
    /// <summary>
    /// Summary description for StudentHandler
    /// </summary>
    public class StudentHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string header = context.Request.Headers["Action"];
            if (header == "GetAllUsers")
            {
                GetAllUsers(context);
            }
        }
        public void GetAllUsers(HttpContext context)
        {
            List<Student> students = StudentBal.GetUsers();
            var js = new JavaScriptSerializer();
            context.Response.Write(js.Serialize(students));
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}