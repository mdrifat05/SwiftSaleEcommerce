using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ManageSearchService
    {
        public static bool Create(ManageSearchDTO search)
        {
            var data = Convert(search);
            return DataAccessFactory.SearchData().Create(data);

        }
        public static List<ManageSearchDTO> Read()
        {
            var data = DataAccessFactory.SearchData().Read();
            return Convert(data);

        }
        public static ManageSearchDTO Read(int id)
        {
            return Convert(DataAccessFactory.SearchData().Read(id));
        }

        public static bool Update(ManageSearchDTO search)
        {
            var data = Convert(search);
            return DataAccessFactory.SearchData().Update(data);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.SearchData().Delete(id);

        }

        static List<ManageSearchDTO> Convert(List<Search> search)
        {
            var data = new List<ManageSearchDTO>();
            foreach (Search sea in search)
            {
                data.Add(Convert(sea));
            }
            return data;
        }
        static List<Search> Convert(List<ManageSearchDTO> search)
        {
            var data = new List<Search>();
            foreach (ManageSearchDTO sea in search)
            {
                data.Add(Convert(sea));
            }
            return data;
        }

        static ManageSearchDTO Convert(Search search)
        {
            return new ManageSearchDTO()
            {

                search_Id = search.search_Id,
                cust_id = search.cust_id,
                search_text = search.search_text


            };
        }

        static Search Convert(ManageSearchDTO search)
        {
            return new Search()
            {
                search_Id = search.search_Id,
               cust_id=search.cust_id,
               search_text=search.search_text


            };

        }
    }
}
