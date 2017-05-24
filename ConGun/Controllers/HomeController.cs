using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;

namespace ConGun.Controllers
{
    public class HomeController : Controller
    {
        UsedEquipmentDAL objUsedEquipmentDAL = new UsedEquipmentDAL();
        public ActionResult Index()
        {
            DataSet dtData = objUsedEquipmentDAL.GetEquipmentList_Dashboard();
            var imageCount = 1;
            if (dtData != null)
            {
                if (dtData.Tables[0] != null)
                {
                    foreach (DataRow item in dtData.Tables[0].Rows)
                    {
                        if (Convert.ToString(item["ImageData1"]) != "")
                        {
                            byte[] bytes = (byte[])item["ImageData1"];
                            var base64 = Convert.ToBase64String(bytes);

                            switch (imageCount)
                            {
                                case 1:
                                    ViewBag.ImagePath1 = String.Format("data:{0};base64,{1}", item["FileType"].ToString(), base64);
                                    break;
                                case 2:
                                    ViewBag.ImagePath2 = String.Format("data:{0};base64,{1}", item["FileType"].ToString(), base64);
                                    break;
                                case 3:
                                    ViewBag.ImagePath3 = String.Format("data:{0};base64,{1}", item["FileType"].ToString(), base64);
                                    break;
                                case 4:
                                    ViewBag.ImagePath4 = String.Format("data:{0};base64,{1}", item["FileType"].ToString(), base64);
                                    break;
                                case 5:
                                    ViewBag.ImagePath5 = String.Format("data:{0};base64,{1}", item["FileType"].ToString(), base64);
                                    break;
                            }
                            imageCount++;
                        }
                    }
                }
                if (dtData.Tables[1] != null)
                {
                    var DescCount = 1;
                    foreach (DataRow item in dtData.Tables[1].Rows)
                    {
                        switch (DescCount)
                        {
                            case 1:
                                ViewBag.RentDetail1 = String.Format("Looking for a <b>{0}</b> for <b>{1}</b> days <br/><br/><i class='glyphicon glyphicon-map-marker'></i>&nbsp;{2} | <i class='glyphicon glyphicon-phone'></i>&nbsp;{3} <br/>Range: <i class='fa fa-inr'></i>&nbsp;{4}", Convert.ToString(item["EquipmentType"]), Convert.ToString(item["Days"]), Convert.ToString(item["Location"]), Convert.ToString(item["ContactNumber"]), Convert.ToString(item["Price"]));
                                break;
                            case 2:
                                ViewBag.RentDetail2 = String.Format("Looking for a <b>{0}</b> for <b>{1}</b> days <br/><br/><i class='glyphicon glyphicon-map-marker'></i>&nbsp;{2} | <i class='glyphicon glyphicon-phone'></i>&nbsp;{3} <br/>Range: <i class='fa fa-inr'></i>&nbsp;{4}", Convert.ToString(item["EquipmentType"]), Convert.ToString(item["Days"]), Convert.ToString(item["Location"]), Convert.ToString(item["ContactNumber"]), Convert.ToString(item["Price"]));
                                break;
                            case 3:
                                ViewBag.RentDetail3 = String.Format("Looking for a <b>{0}</b> for <b>{1}</b> days <br/><br/><i class='glyphicon glyphicon-map-marker'></i>&nbsp;{2} | <i class='glyphicon glyphicon-phone'></i>&nbsp;{3} <br/>Range: <i class='fa fa-inr'></i>&nbsp;{4}", Convert.ToString(item["EquipmentType"]), Convert.ToString(item["Days"]), Convert.ToString(item["Location"]), Convert.ToString(item["ContactNumber"]), Convert.ToString(item["Price"]));
                                break;
                            case 4:
                                ViewBag.RentDetail4 = String.Format("Looking for a <b>{0}</b> for <b>{1}</b> days <br/><br/><i class='glyphicon glyphicon-map-marker'></i>&nbsp;{2} | <i class='glyphicon glyphicon-phone'></i>&nbsp;{3} <br/>Range: <i class='fa fa-inr'></i>&nbsp;{4}", Convert.ToString(item["EquipmentType"]), Convert.ToString(item["Days"]), Convert.ToString(item["Location"]), Convert.ToString(item["ContactNumber"]), Convert.ToString(item["Price"]));
                                break;
                            case 5:
                                ViewBag.RentDetail5 = String.Format("Looking for a <b>{0}</b> for <b>{1}</b> days <br/><br/><i class='glyphicon glyphicon-map-marker'></i>&nbsp;{2} | <i class='glyphicon glyphicon-phone'></i>&nbsp;{3} <br/>Range: <i class='fa fa-inr'></i>&nbsp;{4}", Convert.ToString(item["EquipmentType"]), Convert.ToString(item["Days"]), Convert.ToString(item["Location"]), Convert.ToString(item["ContactNumber"]), Convert.ToString(item["Price"]));
                                break;
                        }
                        DescCount++;
                    }
                }
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}