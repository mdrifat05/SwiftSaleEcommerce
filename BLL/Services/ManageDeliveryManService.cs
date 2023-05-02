using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    public class ManageDeliveryManService
    {
        public static bool Create(ManageDeliveryManDTO manageDelivery)
        {
            var data=Convert(manageDelivery);
            return DataAccessFactory.DeliveryManData().Create(data);

        }
        public static List<ManageDeliveryManDTO> Read()
        {
            var data = DataAccessFactory.DeliveryManData().Read();
            return Convert(data);

        }
        public static ManageDeliveryManDTO Read(int id)
        {
            return Convert(DataAccessFactory.DeliveryManData().Read(id));   
        }

        public static bool Update(ManageDeliveryManDTO managedelivery)
        {
            var data = Convert(managedelivery);
            return DataAccessFactory.DeliveryManData().Update(data);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.DeliveryManData().Delete(id);

        }

        static List<ManageDeliveryManDTO> Convert(List<DeliveryMan> Delivery)
        {
            var data = new List<ManageDeliveryManDTO>();
            foreach (DeliveryMan managedelivery in Delivery)
            {
                data.Add(Convert(managedelivery));
            }
            return data;
        }
        static List<DeliveryMan> Convert(List<ManageDeliveryManDTO> Delivery)
        {
            var data = new List<DeliveryMan>();
            foreach (ManageDeliveryManDTO manageDelivery in Delivery)
            {
                data.Add(Convert(manageDelivery));
            }
            return data;
        }

        static ManageDeliveryManDTO Convert(DeliveryMan Delivery)
        {
            return new ManageDeliveryManDTO()
            {

               DelId= Delivery.DelId,
               Name= Delivery.Name,
               Email=Delivery.Email,
                Password=Delivery.Password,
                Phone= Delivery.Phone,
                Gender = Delivery.Gender,
                JoinDate = Delivery.JoinDate,
                Dob = Delivery.Dob,
                Zip_Code= Delivery.Zip_Code,
                nid = Delivery.nid


            };
        }

        static DeliveryMan Convert(ManageDeliveryManDTO del)
        {
            return new DeliveryMan()
            {
                DelId = del.DelId,
                Name = del.Name,
                Email = del.Email,
                Password = del.Password,
                Phone = del.Phone,
                Gender = del.Gender,
                JoinDate = del.JoinDate,
                Dob = del.Dob,
                Zip_Code = del.Zip_Code,
                nid = del.nid
            };

        }
    }
}
