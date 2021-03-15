using BALCRUD;
using EntityCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<Student> Get()
        {
            List<Student> students =StudentBal.GetUsers();
            return students;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public bool AddStudent([FromBody]Student value)
        {
            bool isAddStudent = false;
            Student students = new Student
            {
                StudentAge = 39,
                StudentName = "Mohammad"
            };
            isAddStudent = StudentBal.AddStudent(value);
            if (isAddStudent)
                return isAddStudent;
            return isAddStudent;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
