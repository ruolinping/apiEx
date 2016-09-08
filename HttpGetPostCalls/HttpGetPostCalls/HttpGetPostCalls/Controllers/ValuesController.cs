using HttpGetPostCalls.ClassObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HttpGetPostCalls.Controllers
{
    public class ValuesController : ApiController
    {
        /// <summary>
        /// http get call
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetDropdownList()
        {
            string result = string.Empty;
            List<States> lstStates = new List<States>();
            States objStates = new States();
            objStates.stateId = 1;
            objStates.stateName = "Karnataka";
            lstStates.Add(objStates);
            objStates = new States();
            objStates.stateId = 2;
            objStates.stateName = "Maharastra";
            lstStates.Add(objStates);
            objStates = new States();
            objStates.stateId = 3;
            objStates.stateName = "Delhi";
            lstStates.Add(objStates);

            //json stringfy the result
            result = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(lstStates);
            return result;
        }


        /// <summary>
        /// Http post call
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public string GetResult(States obj)
        {
            string result = string.Empty;
            result = "My state name is " + obj.stateName;
            //json stringfy the result
            result = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(result);
            return result;
        }
    }
}