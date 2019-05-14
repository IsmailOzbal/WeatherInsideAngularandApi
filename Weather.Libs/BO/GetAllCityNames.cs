using System;
using System.Collections.Generic;
using System.Text;
using Weather.Libs.Interface;

namespace Weather.Libs.BO
{
    public class GetAllCityNames : ICity
    {
        public List<string> GetAll()
        {
            List<string> cityList = new List<string>();
            cityList.Add("Ankara");
            cityList.Add("Adana");
            cityList.Add("Istanbul");
            cityList.Add("Duzce");
            cityList.Add("Eskisehir");
            cityList.Add("Mersin");
            cityList.Add("Aydin");
            cityList.Add("Malatya");
            cityList.Add("Bolu");
            cityList.Add("Sakarya");
            return cityList;
        }
    }
}
