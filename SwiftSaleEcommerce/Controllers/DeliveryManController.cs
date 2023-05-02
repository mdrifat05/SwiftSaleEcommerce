using BLL.DTOs;
using BLL.services;
using SwiftSaleEcommerce.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwiftSaleEcommerce.Controllers
{
    public class DeliveryManController : ApiController
    {
        
        [HttpGet]
        [Route("api/ManageDeliveryMan")]
        public HttpResponseMessage Read()
        {
            try
            {
                var data=ManageDeliveryManService.Read();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/ManageDeliveryMan/{id}")]
        public HttpResponseMessage Read(int id)
        {
            try
            {
                var data = ManageDeliveryManService.Read(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/ManageDeliveryMan/Create")]
        public HttpResponseMessage Create(ManageDeliveryManDTO obj)
        {
            try
            {
                var data = ManageDeliveryManService.Create(obj);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK,new {Msg = "Delivery Man Added Successfully", Data=obj});
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Error Occured while Creating", Data = obj });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = obj });
            }
        }

        [HttpPost]
        [Route("api/ManageDeliveryMan/Update")]
        public HttpResponseMessage Update(ManageDeliveryManDTO obj)
        {
            try
            {
                var data = ManageDeliveryManService.Update(obj);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Delivery Man Updated Successfully", Data = obj });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Unable to update Data", Data = obj });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = obj });
            }
        }

        [HttpPost]
        [Route("api/ManageDeliveryMan/Delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ManageDeliveryManService.Delete(id);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Delivery Man Deleted Successfully" });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Unable to Delete Data"});
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}
