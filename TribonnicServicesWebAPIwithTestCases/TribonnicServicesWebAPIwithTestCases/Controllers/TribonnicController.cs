using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TribonnicServicesWebAPIwithTestCases.Models;
namespace TribonnicServicesWebAPIwithTestCases.Controllers
{
    public class TribonnicController : ApiController
    {
        // GET api/values
        public  ResponsMessage Get()
        {
            ResponsMessage objResponse = new ResponsMessage();
            List<int> lstValues = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                lstValues.Add(Tribonnice.GetValues(i));
            }
            objResponse.Message = "Successfull";
            objResponse.Result = lstValues.Count;
            objResponse.Series = lstValues;
            objResponse.Status = HttpStatusCode.OK;

            return objResponse;

        }



         ///EndPoint: http://localhost:55681/api/SeriesApi?divisible=5&position=3
        /// <summary>
        /// GET: api/Series
        /// </summary>
        /// <param name="divisible"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public ResponsMessage GetSeriesValue(int? divisible = 0, int? position = 0)
        {
            ResponsMessage objResponse = new ResponsMessage();

            if (divisible != 0)
            {
                if (position != 0)
                {
                    int count = 1;
                    List<int> lstValues = new List<int>();
                    List<int> lstDivisibleValues = new List<int>();

                    int restult = 0;

                    for (int i = 0; i < 20; i++)
                    {
                        lstValues.Add(Tribonnice.GetValues(i));
                    }

                    foreach (var x in lstValues)
                    {
                        if (x % divisible == 0)
                            lstDivisibleValues.Add(x);
                    }

                    for (int index = 0; index < lstDivisibleValues.Count; index++)
                    {
                        if (count == position)
                            restult = lstDivisibleValues[index];

                        count++;
                    }


                    objResponse.Result = restult;
                    objResponse.Series = lstValues;
                    objResponse.Status = HttpStatusCode.OK;
                    objResponse.Message = "Successful";
                }
                else
                {
                    objResponse.Message = "Invalid position number";
                }
            }
            else
            {
                objResponse.Message = "Invalid division number";
            }

            return objResponse;
        }
    }
}
