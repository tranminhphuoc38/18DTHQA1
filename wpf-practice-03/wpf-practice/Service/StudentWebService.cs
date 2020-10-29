using Common.Model;
using Common.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace wpf_practice.Service {
    public class StudentWebService : IStudentService {

        public const string BASE_URL = "https://localhost:44361/api/";
        private readonly HttpClient m_client;

        public StudentWebService() {
            m_client = new HttpClient();
            m_client.BaseAddress = new Uri(BASE_URL);
        }

        public Student Add(Student student) {
            throw new NotImplementedException();
        }

        public List<Class> GetAllClasses() {
            return new List<Class>();
        }

        public void Remove(int studentId) {
            throw new NotImplementedException();
        }

        public List<Student> SearchStudent(StudentSearchCriteria criteria) {
            var responseTask = m_client.GetAsync("student");

            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode) {
                var jsonResult = result.Content.ReadAsStringAsync();
                jsonResult.Wait();
                return JsonConvert.DeserializeObject<List<Student>>(jsonResult.Result);
            }

            return new List<Student>();
        }

        public Student Update(Student student) {
            throw new NotImplementedException();
        }
    }
}
