using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;
using RestSharp;
using System.Configuration;
using System.Xml.Linq;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace BusinessLogicLayer
{
    public class Employee_BLL
    {
        CommonClass objCommonClass = new CommonClass();

        public async Task<string> GetEmployeeDetailsBasedOnSearch(Employee objEmployee, int page, int pageSize)
        {
            string jsonString = string.Empty;

            HttpClient client = new HttpClient();

            string URL = objCommonClass.RESTfulApiUrl + "users" + "?id=" + objEmployee.id + "&name=" + objEmployee.name + "&page=" + page + "&per_page=" + pageSize;

            HttpResponseMessage httpResponse = await client.GetAsync(URL);

            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {

                jsonString = await httpResponse.Content.ReadAsStringAsync();

            }

            return jsonString;
        }

        public async Task<HttpResponseMessage> CreateEmployee(Employee objEmployee)
        {

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", objCommonClass.ApiToken);

            string URL = objCommonClass.RESTfulApiUrl + "users";

            string jsonString = JsonConvert.SerializeObject(objEmployee);

            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            HttpResponseMessage httpResponse = await client.PostAsync(URL, httpContent);

            return httpResponse;

        }

        public async Task<HttpResponseMessage> UpdateEmployee(Employee objEmployee)
        {

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", objCommonClass.ApiToken);

            string URL = objCommonClass.RESTfulApiUrl + "users" + "/" + objEmployee.id;

            string jsonString = JsonConvert.SerializeObject(objEmployee);

            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            HttpResponseMessage httpResponse = await client.PutAsync(URL, httpContent);

            return httpResponse;

        }

        public async Task<HttpResponseMessage> DeleteEmployee(string EmployeeID)
        {

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", objCommonClass.ApiToken);

            string URL = objCommonClass.RESTfulApiUrl + "users" + "/" + EmployeeID;

            HttpResponseMessage httpResponse = await client.DeleteAsync(URL);

            return httpResponse;

        }

    }
}
