using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.OleDb;
using MGA.Base.Admin;
using MGAChargerEcommerce;
using MGAChargerEcommerce.Models;
using MGAChargerEcommerece.Helper;
using HtmlAgilityPack;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text.html.simpleparser;
using MGA.Utility;
using System.Net;
using System.Globalization;

namespace MGAChargerEcommerce.Controllers
{
    public class AdminController : Controller
    {
        MGA.Base.ActionResult actionResult = new MGA.Base.ActionResult();
        MGA.ActionLayer.Admin.AdminAL adminAction = new MGA.ActionLayer.Admin.AdminAL();

        public ActionResult Dashboard()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ManageLatestWork()
        {
            ManagePages model = new ManagePages();
            model.PageId = 1;//means Latest work page
            actionResult = adminAction.GetPage(model);
            if (actionResult.IsSuccess)
            {
                MasterPagesModel page = new MasterPagesModel();
                page = Helper.ConvertTo<MasterPagesModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ManageLatestWork(ManagePages model)
        {
            ManagePages basemodel = new ManagePages();
            basemodel.PageId = model.PageId;
            basemodel.HtmlContent = model.HtmlContent;
            actionResult = adminAction.UpdatePage(basemodel);
            if (actionResult.IsSuccess)
            {
                if (actionResult.dtResult.Rows[0][0].ToString() == "1")
                {
                    TempData["SuccessMessage"] = "Page Update Successfully..!";
                    return RedirectToAction("ManageLatestWork");
                }
                else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
                {
                    TempData["ErrorMessage"] = "Failed to Update Page..!";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult ManageTestimonials()
        {
            ManagePages model = new ManagePages();
            model.PageId = 2;//means Testimonial work page
            actionResult = adminAction.GetPage(model);
            if (actionResult.IsSuccess)
            {
                MasterPagesModel page = new MasterPagesModel();
                page = Helper.ConvertTo<MasterPagesModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ManageTestimonials(ManagePages model)
        {
            ManagePages basemodel = new ManagePages();
            basemodel.PageId = model.PageId;
            basemodel.HtmlContent = model.HtmlContent;
            actionResult = adminAction.UpdatePage(basemodel);
            if (actionResult.IsSuccess)
            {
                if (actionResult.dtResult.Rows[0][0].ToString() == "1")
                {
                    TempData["SuccessMessage"] = "Page Update Successfully..!";
                    return RedirectToAction("ManageTestimonials");
                }
                else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
                {
                    TempData["ErrorMessage"] = "Failed to Update Page..!";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult ManageWhyChoseUs()
        {
            ManagePages model = new ManagePages();
            model.PageId = 3;//means Why Choose us?.
            actionResult = adminAction.GetPage(model);
            if (actionResult.IsSuccess)
            {
                MasterPagesModel page = new MasterPagesModel();
                page = Helper.ConvertTo<MasterPagesModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ManageWhyChoseUs(ManagePages model)
        {
            ManagePages basemodel = new ManagePages();
            basemodel.PageId = model.PageId;
            basemodel.HtmlContent = model.HtmlContent;
            actionResult = adminAction.UpdatePage(basemodel);
            if (actionResult.IsSuccess)
            {
                if (actionResult.dtResult.Rows[0][0].ToString() == "1")
                {
                    TempData["SuccessMessage"] = "Page Update Successfully..!";
                    return RedirectToAction("ManageWhyChoseUs");
                }
                else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
                {
                    TempData["ErrorMessage"] = "Failed to Update Page..!";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult ManageWhatClientSay()
        {
            ManagePages model = new ManagePages();
            model.PageId = 4;//means What Client Say  page
            actionResult = adminAction.GetPage(model);
            if (actionResult.IsSuccess)
            {
                MasterPagesModel page = new MasterPagesModel();
                page = Helper.ConvertTo<MasterPagesModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ManageWhatClientSay(ManagePages model)
        {
            ManagePages basemodel = new ManagePages();
            basemodel.PageId = model.PageId;
            basemodel.HtmlContent = model.HtmlContent;
            actionResult = adminAction.UpdatePage(basemodel);
            if (actionResult.IsSuccess)
            {
                if (actionResult.dtResult.Rows[0][0].ToString() == "1")
                {
                    TempData["SuccessMessage"] = "Page Update Successfully..!";
                    return RedirectToAction("ManageWhatClientSay");
                }
                else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
                {
                    TempData["ErrorMessage"] = "Failed to Update Page..!";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult ManageAboutUs()
        {
            ManagePages model = new ManagePages();
            model.PageId = 5;//means About us page
            actionResult = adminAction.GetPage(model);
            if (actionResult.IsSuccess)
            {
                MasterPagesModel page = new MasterPagesModel();
                page = Helper.ConvertTo<MasterPagesModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ManageAboutUs(ManagePages model)
        {
            ManagePages basemodel = new ManagePages();
            basemodel.PageId = model.PageId;
            basemodel.HtmlContent = model.HtmlContent;
            actionResult = adminAction.UpdatePage(basemodel);
            if (actionResult.IsSuccess)
            {
                if (actionResult.dtResult.Rows[0][0].ToString() == "1")
                {
                    TempData["SuccessMessage"] = "Page Update Successfully..!";
                    return RedirectToAction("ManageAboutUs");
                }
                else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
                {
                    TempData["ErrorMessage"] = "Failed to Update Page..!";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult ManageMediaRoom()
        {
            ManagePages model = new ManagePages();
            model.PageId = 6;//means media room page
            actionResult = adminAction.GetPage(model);
            if (actionResult.IsSuccess)
            {
                MasterPagesModel page = new MasterPagesModel();
                page = Helper.ConvertTo<MasterPagesModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ManageMediaRoom(ManagePages model)
        {
            ManagePages basemodel = new ManagePages();
            basemodel.PageId = model.PageId;
            basemodel.HtmlContent = model.HtmlContent;
            actionResult = adminAction.UpdatePage(basemodel);
            if (actionResult.IsSuccess)
            {
                if (actionResult.dtResult.Rows[0][0].ToString() == "1")
                {
                    TempData["SuccessMessage"] = "Page Update Successfully..!";
                    return RedirectToAction("ManageMediaRoom");
                }
                else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
                {
                    TempData["ErrorMessage"] = "Failed to Update Page..!";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult ManageOurBusiness()
        {
            ManagePages model = new ManagePages();
            model.PageId = 7;//means media room page
            actionResult = adminAction.GetPage(model);
            if (actionResult.IsSuccess)
            {
                MasterPagesModel page = new MasterPagesModel();
                page = Helper.ConvertTo<MasterPagesModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ManageOurBusiness(ManagePages model)
        {
            ManagePages basemodel = new ManagePages();
            basemodel.PageId = model.PageId;
            basemodel.HtmlContent = model.HtmlContent;
            actionResult = adminAction.UpdatePage(basemodel);
            if (actionResult.IsSuccess)
            {
                if (actionResult.dtResult.Rows[0][0].ToString() == "1")
                {
                    TempData["SuccessMessage"] = "Page Update Successfully..!";
                    return RedirectToAction("ManageOurBusiness");
                }
                else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
                {
                    TempData["ErrorMessage"] = "Failed to Update Page..!";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult ManageSustainability()
        {
            ManagePages model = new ManagePages();
            model.PageId = 8;//means media room page
            actionResult = adminAction.GetPage(model);
            if (actionResult.IsSuccess)
            {
                MasterPagesModel page = new MasterPagesModel();
                page = Helper.ConvertTo<MasterPagesModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ManageSustainability(ManagePages model)
        {
            ManagePages basemodel = new ManagePages();
            basemodel.PageId = model.PageId;
            basemodel.HtmlContent = model.HtmlContent;
            actionResult = adminAction.UpdatePage(basemodel);
            if (actionResult.IsSuccess)
            {
                if (actionResult.dtResult.Rows[0][0].ToString() == "1")
                {
                    TempData["SuccessMessage"] = "Page Update Successfully..!";
                    return RedirectToAction("ManageSustainability");
                }
                else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
                {
                    TempData["ErrorMessage"] = "Failed to Update Page..!";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult ManageInnovation()
        {
            ManagePages model = new ManagePages();
            model.PageId = 9;//means media room page
            actionResult = adminAction.GetPage(model);
            if (actionResult.IsSuccess)
            {
                MasterPagesModel page = new MasterPagesModel();
                page = Helper.ConvertTo<MasterPagesModel>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ManageInnovation(ManagePages model)
        {
            ManagePages basemodel = new ManagePages();
            basemodel.PageId = model.PageId;
            basemodel.HtmlContent = model.HtmlContent;
            actionResult = adminAction.UpdatePage(basemodel);
            if (actionResult.IsSuccess)
            {
                if (actionResult.dtResult.Rows[0][0].ToString() == "1")
                {
                    TempData["SuccessMessage"] = "Page Update Successfully..!";
                    return RedirectToAction("ManageInnovation");
                }
                else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
                {
                    TempData["ErrorMessage"] = "Failed to Update Page..!";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult PhotoGallery()
        {
            ManagePhotoGallery manage = new ManagePhotoGallery();
            List<PhotoGallery> photoGalleryList = new List<PhotoGallery>();
            actionResult = adminAction.getEvent();
            manage.photoGalleryList = photoGalleryList;
            if (actionResult.IsSuccess)
            {
                photoGalleryList = Helper.ConvertTo<PhotoGallery>(actionResult.dtResult);
            }
            manage.photoGalleryList = photoGalleryList;

            return View(manage);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult PhotoGallery(ManagePhotoGallery model)
        {
            PhotoGalleryBase baseModel = new PhotoGalleryBase();
            baseModel.EventName = model.photoGallery.EventName;
            baseModel.EventDescription = model.photoGallery.EventDescription;
            baseModel.CreatedOn = Convert.ToDateTime(DateTime.Now, System.Globalization.CultureInfo.InvariantCulture);
            HttpPostedFileBase pfb = Request.Files["photoGallery.EventImage"];
            if (pfb != null && pfb.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfb.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/EventImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/EventImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/EventImage/"),
                                   uploadedfilename);
                pfb.SaveAs(filePath);
                baseModel.EventImage = "/Content/EventImage/" + uploadedfilename;

            }
            else if (model.photoGallery.EventImage != "")
            {
                baseModel.EventImage = model.photoGallery.EventImage;
            }
            else
            {
                baseModel.EventImage = "/Content/NoImage.gif";
            }
            baseModel.CreatedBy = 0;

            bool check = adminAction.addEvent(baseModel);
            if (check)
            { TempData["Success"] = "Event Added Successfully."; }
            else
            { TempData["Error"] = "Failed to add Event."; }
            return RedirectToAction("PhotoGallery");

        }

        [HttpGet]
        public ActionResult DeletePhotoGallery(int id)
        {

            string json = string.Empty;
            try
            {
                PhotoGalleryBase photogalleryBase = new PhotoGalleryBase();
                photogalleryBase.ID = Convert.ToInt32(id);
                actionResult = adminAction.DeletePhotoGallery(photogalleryBase);
                if (actionResult.IsSuccess)
                {
                    if (Convert.ToInt32(actionResult.dtResult.Rows[0][0]) > 0)
                    {
                        TempData["SuccessMessage"] = "Event Deleted Successfully";
                    }
                }
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Failed to delete Event";
            }
            return RedirectToAction("PhotoGallery", "Admin");
        }

        [HttpGet]
        public ActionResult PrestigiousCustomer()
        {
            ManagePrestigiousCustomer manage = new ManagePrestigiousCustomer();
            List<PrestigiousCustomer> prestigiousCusdtomerList = new List<PrestigiousCustomer>();
            actionResult = adminAction.getPrestigiousCustomer();

            if (actionResult.IsSuccess)
            {
                prestigiousCusdtomerList = Helper.ConvertTo<PrestigiousCustomer>(actionResult.dtResult);
            }
            manage.prestigiousCustomerList = prestigiousCusdtomerList;

            return View(manage);

        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult PrestigiousCustomer(ManagePrestigiousCustomer model)
        {
            PrestigiousCustomerBase baseModel = new PrestigiousCustomerBase();
            baseModel.EventName = model.prestigiousCustomer.EventsName;
            baseModel.EventUrl = model.prestigiousCustomer.URL;
            baseModel.CreatedOn = Convert.ToDateTime(DateTime.Now, System.Globalization.CultureInfo.InvariantCulture);
            HttpPostedFileBase pfb = Request.Files["prestigiousCustomer.Image"];
            if (pfb != null && pfb.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfb.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/PresatigiousCustomer/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/PresatigiousCustomer/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/PresatigiousCustomer/"),
                                   uploadedfilename);
                pfb.SaveAs(filePath);
                baseModel.Image = "/Content/PresatigiousCustomer/" + uploadedfilename;

            }
            else if (model.prestigiousCustomer.Image != "")
            {
                baseModel.Image = model.prestigiousCustomer.Image;
            }
            else
            {
                baseModel.Image = "/Content/NoImage.gif";
            }
            baseModel.CreatedBy = 0;

            bool check = adminAction.addPrestigiousCustomer(baseModel);
            if (check)
            { TempData["Success"] = "Media Added Successfully."; }
            else
            { TempData["Error"] = "Failed to add Media."; }
            return RedirectToAction("PrestigiousCustomer");

        }

        [HttpGet]
        public ActionResult OurClient()
        {
            ManageOurClient manage = new ManageOurClient();
            List<OurClient> ourclientList = new List<OurClient>();
            actionResult = adminAction.Get_OurClients();

            if (actionResult.IsSuccess)
            {
                ourclientList = Helper.ConvertTo<OurClient>(actionResult.dtResult);
            }
            manage.ourClientList = ourclientList;

            return View(manage);

        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult OurClient(ManageOurClient model)
        {
            PrestigiousCustomerBase baseModel = new PrestigiousCustomerBase();
            baseModel.EventName = model.ourClient.ClientName;
            baseModel.EventUrl = "OurClient";
            baseModel.CreatedBy = '1';
            HttpPostedFileBase pfb = Request.Files["ourClient.Image"];
            if (pfb != null && pfb.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfb.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/PresatigiousCustomer/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/PresatigiousCustomer/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/PresatigiousCustomer/"),
                                   uploadedfilename);
                pfb.SaveAs(filePath);
                baseModel.Image = "/Content/PresatigiousCustomer/" + uploadedfilename;

            }
            else if (model.ourClient.Image != "")
            {
                baseModel.Image = model.ourClient.Image;
            }
            else
            {
                baseModel.Image = "/Content/NoImage.gif";
            }
            baseModel.CreatedBy = 0;

            bool check = adminAction.addPrestigiousCustomer(baseModel);
            if (check)
            { TempData["Success"] = "Our Client Added Successfully."; }
            else
            { TempData["Error"] = "Failed to add Client."; }
            return RedirectToAction("OurClient");
           
        }


        [HttpGet]
        public ActionResult DeletePrestigiousCustomer(int id)
        {

            string json = string.Empty;
            try
            {
                PrestigiousCustomerBase prestigiousCustomerBase = new PrestigiousCustomerBase();
                prestigiousCustomerBase.ID = Convert.ToInt32(id);
                actionResult = adminAction.DeletePrestigiousCustomer(prestigiousCustomerBase);
                if (Convert.ToInt32(actionResult.dtResult.Rows[0]["Column1"]) == 1)
                {

                    TempData["SuccessMessage"] = "Event Deleted Successfully";

                }
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Failed to delete Event";
            }
            return RedirectToAction("PrestigiousCustomer", "Admin");
        }



        [HttpGet]
        public ActionResult DeleteOurClient(int ID)
        {

            string json = string.Empty;
            try
            {
                actionResult = adminAction.DeleteOurClient(ID);
                if (Convert.ToInt32(actionResult.dtResult.Rows[0]["Column1"]) == 1)
                {

                    TempData["SuccessMessage"] = "Client Deleted Successfully";

                }
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Failed to delete Client";
            }
            return RedirectToAction("OurClient", "Admin");
        }


        [HttpGet]
        public ActionResult ContactUs()
        {
            ContactUsBase model = new ContactUsBase();
            model.ID = 1;//means contact us page
            actionResult = adminAction.getContactUs(model);
            if (actionResult.IsSuccess)
            {
                ContactUs page = new ContactUs();
                page = Helper.ConvertTo<ContactUs>(actionResult.dtResult).ElementAtOrDefault(0);
                return View(page);
            }
            else
                return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ContactUs(ContactUs model)
        {
            ContactUsBase basemodel = new ContactUsBase();
            basemodel.ID = 1;
            basemodel.CustomerCareNumber = model.CustomerCareNumber;
            basemodel.CustomerSalesSupportNumber = model.SalesSupportNumber;
            basemodel.EmailAddress = model.CustomerCareEmailAddress;
            basemodel.Address = model.Address;
            basemodel.AboutUs = model.AboutUs;
            actionResult = adminAction.UpdateContactUs(basemodel);
            if (actionResult.IsSuccess)
            {
                if (actionResult.dtResult.Rows[0][0].ToString() == "1")
                {
                    TempData["SuccessMessage"] = "Contact Us Updated Successfully..!";
                    return RedirectToAction("ContactUs");
                }
                else if (actionResult.dtResult.Rows[0][0].ToString() == "0")
                {
                    TempData["ErrorMessage"] = "Failed to Update Contact Us..!";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            AddProductBase model = new AddProductBase();
            List<SelectListItem> productcategoryList = new List<SelectListItem>();

            actionResult = adminAction.getProductCategory();
            productcategoryList = actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["CategoryName"].ToString(), Value = v["CategoryId"].ToString() }).ToList();
            ViewBag.ProductCategoryList = productcategoryList;


            ManageAddProduct manage = new ManageAddProduct();
            List<AddProduct> productList = new List<AddProduct>();
            actionResult = adminAction.getProduct();

            if (actionResult.IsSuccess)
            {
                productList = Helper.ConvertTo<AddProduct>(actionResult.dtResult);
            }
            manage.ProductList = productList;

            return View(manage);

        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddProduct(ManageAddProduct model)
        {
            AddProductBase baseModel = new AddProductBase();
            baseModel.ProductCode = model.Addproduct.ProductCode;
            baseModel.ProductName = model.Addproduct.ProductName;
            baseModel.ProductCategory = model.Addproduct.ProductCategory;
            baseModel.ProductOrder = model.Addproduct.ProductOrder;
            baseModel.ProductDescription = model.Addproduct.ProductDescription;
            baseModel.ProductReturnPolicy = model.Addproduct.ProductReturnPolicy;
            baseModel.ProductRate = model.Addproduct.ProductRate;
            baseModel.OfferDescription = model.Addproduct.OfferDescription;
            baseModel.SubTotalAmount = model.Addproduct.SubTotalAmount;
            baseModel.CGSTPercentage = model.Addproduct.CGSTPercentage;
            baseModel.CGSTAmount = model.Addproduct.CGSTAmount;
            baseModel.SGSTPercentage = model.Addproduct.SGSTPercentage;
            baseModel.SGSTAmount = model.Addproduct.SGSTAmount;
            baseModel.IGSTPercentage = model.Addproduct.IGSTPercentage;
            baseModel.IGSTAmount = model.Addproduct.IGSTAmount;
            baseModel.TotalAmountIncludeTax = model.Addproduct.TotalAmountIncludeTax;

            baseModel.CreatedBy = 1;


            HttpPostedFileBase pfb = Request.Files["Addproduct.ProductImage"];
            if (pfb != null && pfb.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfb.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
                                   uploadedfilename);
                pfb.SaveAs(filePath);
                baseModel.ProductImage = uploadedfilename;

            }
            else if (model.Addproduct.ProductImage != "")
            {
                baseModel.ProductImage = model.Addproduct.ProductImage;
            }
            else
            {
                baseModel.ProductImage = "/Content/NoImage.gif";
            }


            HttpPostedFileBase pfbSideView = Request.Files["Addproduct.ProductImageSideView"];
            if (pfbSideView != null && pfbSideView.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfbSideView.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
                                   uploadedfilename);
                pfbSideView.SaveAs(filePath);
                baseModel.ProductImageSideView = uploadedfilename;

            }
            else if (model.Addproduct.ProductImageSideView != "")
            {
                baseModel.ProductImageSideView = model.Addproduct.ProductImageSideView;
            }
            else
            {
                baseModel.ProductImageSideView = "/Content/NoImage.gif";
            }


            HttpPostedFileBase pfbTopView = Request.Files["Addproduct.ProductImageTopView"];
            if (pfbTopView != null && pfbTopView.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfbTopView.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
                                   uploadedfilename);
                pfbTopView.SaveAs(filePath);
                baseModel.ProductImageTopView = uploadedfilename;

            }
            else if (model.Addproduct.ProductImageTopView != "")
            {
                baseModel.ProductImageTopView = model.Addproduct.ProductImageTopView;
            }
            else
            {
                baseModel.ProductImageTopView = "/Content/NoImage.gif";
            }


            HttpPostedFileBase pfbBottomView = Request.Files["Addproduct.ProductImageBottomView"];
            if (pfbBottomView != null && pfbBottomView.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfbBottomView.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
                                   uploadedfilename);
                pfbTopView.SaveAs(filePath);
                baseModel.ProductImageBottom = uploadedfilename;

            }
            else if (model.Addproduct.ProductImageBottomView != "")
            {
                baseModel.ProductImageBottom = model.Addproduct.ProductImageBottomView;
            }
            else
            {
                baseModel.ProductImageBottom = "/Content/NoImage.gif";
            }

            HttpPostedFileBase pfbImageDeailView = Request.Files["Addproduct.ProductImageDetail"];
            if (pfbImageDeailView != null && pfbImageDeailView.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfbImageDeailView.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
                                   uploadedfilename);
                pfbImageDeailView.SaveAs(filePath);
                baseModel.ProductImageDetail = uploadedfilename;

            }
            else if (model.Addproduct.ProductImageDetail != "")
            {
                baseModel.ProductImageDetail = model.Addproduct.ProductImageDetail;
            }
            else
            {
                baseModel.ProductImageDetail = "/Content/NoImage.gif";
            }

            baseModel.CreatedBy = 0;

            bool check = adminAction.addProduct(baseModel);
            if (check)
            { TempData["Success"] = "Product Added Successfully."; }
            else
            { TempData["Error"] = "Failed to add Product."; }
            return RedirectToAction("AddProduct");

        }

        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {

            string json = string.Empty;
            try
            {
                AddProductBase addProductBase = new AddProductBase();
                addProductBase.ProductId = Convert.ToInt32(id);
                actionResult = adminAction.DeleteProduct(addProductBase);
                if (actionResult.IsSuccess)
                {
                    if (Convert.ToInt32(actionResult.dtResult.Rows[0][0]) > 0)
                    {
                        TempData["SuccessMessage"] = "Product Deleted Successfully";
                    }
                }
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Failed to delete product";
            }
            return RedirectToAction("AddProduct", "Admin");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id = 0)
        {
            AddProductBase model = new AddProductBase();
            List<SelectListItem> productcategoryList = new List<SelectListItem>();
            model.ProductId = id;
            actionResult = adminAction.getProductCategory();
            productcategoryList = actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["CategoryName"].ToString(), Value = v["CategoryId"].ToString() }).ToList();
            ViewBag.ProductCategoryList = productcategoryList;

            AddProduct manage = new AddProduct();

            actionResult = adminAction.getProductById(model);

            if (actionResult.IsSuccess)
            {
                manage = Helper.ConvertTo<AddProduct>(actionResult.dtResult).ElementAtOrDefault(0);
            }

            return View(manage);

        }


        //public ActionResult UpdateProduct(AddProduct model)
        //{
        //    AddProductBase baseModel = new AddProductBase();
        //    baseModel.ProductId = model.ProductId;
        //    baseModel.ProductCode = model.ProductCode;
        //    baseModel.ProductName = model.ProductName;
        //    baseModel.ProductCategory = model.ProductCategory;
        //    baseModel.ProductDescription = model.ProductDescription;
        //    baseModel.ProductReturnPolicy = model.ProductReturnPolicy;
        //    baseModel.ProductRate = model.ProductRate;
        //    baseModel.OfferDescription = model.OfferDescription;
        //    baseModel.SubTotalAmount = model.SubTotalAmount;
        //    baseModel.CGSTPercentage = model.CGSTPercentage;
        //    baseModel.CGSTAmount = model.CGSTAmount;
        //    baseModel.SGSTPercentage = model.SGSTPercentage;
        //    baseModel.SGSTAmount = model.SGSTAmount;
        //    baseModel.IGSTPercentage = model.IGSTPercentage;
        //    baseModel.IGSTAmount = model.IGSTAmount;
        //    baseModel.TotalAmountIncludeTax = model.TotalAmountIncludeTax;

        //    baseModel.CreatedBy = 1;


        //    HttpPostedFileBase pfb = Request.Files["ProductImage"];
        //    if (pfb != null && pfb.ContentLength > 0)
        //    {
        //        string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfb.FileName;

        //        if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
        //        {
        //            System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
        //        }
        //        string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
        //                           uploadedfilename);
        //        pfb.SaveAs(filePath);
        //        baseModel.ProductImage = uploadedfilename;

        //    }
        //    else if (model.ProductImage != "")
        //    {
        //        baseModel.ProductImage = model.ProductImage;
        //    }
        //    else
        //    {
        //        baseModel.ProductImage = "/Content/NoImage.gif";
        //    }
        //    baseModel.CreatedBy = 0;

        //    bool check = adminAction.addProduct(baseModel);
        //    if (check)
        //    { TempData["Success"] = "Product Updated Successfully."; }
        //    else
        //    { TempData["Error"] = "Failed to Update Product."; }
        //    return RedirectToAction("AddProduct");

        //}

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UpdateProduct(AddProduct model)
        {
            AddProductBase baseModel = new AddProductBase();
            baseModel.ProductId = model.ProductId;
            baseModel.ProductCode = model.ProductCode;
            baseModel.ProductName = model.ProductName;
            baseModel.ProductCategory = model.ProductCategory;
            baseModel.ProductOrder = model.ProductOrder;
            baseModel.ProductDescription = model.ProductDescription;
            baseModel.ProductReturnPolicy = model.ProductReturnPolicy;
            baseModel.ProductRate = model.ProductRate;
            baseModel.OfferDescription = model.OfferDescription;
            baseModel.SubTotalAmount = model.SubTotalAmount;
            baseModel.CGSTPercentage = model.CGSTPercentage;
            baseModel.CGSTAmount = model.CGSTAmount;
            baseModel.SGSTPercentage = model.SGSTPercentage;
            baseModel.SGSTAmount = model.SGSTAmount;
            baseModel.IGSTPercentage = model.IGSTPercentage;
            baseModel.IGSTAmount = model.IGSTAmount;
            baseModel.TotalAmountIncludeTax = model.TotalAmountIncludeTax;

            baseModel.CreatedBy = 1;


            //HttpPostedFileBase pfb = Request.Files["Addproduct.ProductImage"];
            HttpPostedFileBase pfb = Request.Files["ProductImage"];
            if (pfb != null && pfb.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfb.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
                                   uploadedfilename);
                pfb.SaveAs(filePath);
                baseModel.ProductImage = uploadedfilename;

            }
            else if (model.ProductImage != "")
            {
                baseModel.ProductImage = model.ProductImage;
            }
            else
            {
                baseModel.ProductImage = "/Content/NoImage.gif";
            }


            //HttpPostedFileBase pfbSideView = Request.Files["Addproduct.ProductImageSideView"];
            HttpPostedFileBase pfbSideView = Request.Files["ProductImageSideView"];
            if (pfbSideView != null && pfbSideView.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfbSideView.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
                                   uploadedfilename);
                pfbSideView.SaveAs(filePath);
                baseModel.ProductImageSideView = uploadedfilename;

            }
            else if (model.ProductImageSideView != "")
            {
                baseModel.ProductImageSideView = model.ProductImageSideView;
            }
            else
            {
                baseModel.ProductImageSideView = "/Content/NoImage.gif";
            }


            //HttpPostedFileBase pfbTopView = Request.Files["Addproduct.ProductImageTopView"];
            HttpPostedFileBase pfbTopView = Request.Files["ProductImageTopView"];
            if (pfbTopView != null && pfbTopView.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfbTopView.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
                                   uploadedfilename);
                pfbTopView.SaveAs(filePath);
                baseModel.ProductImageTopView = uploadedfilename;

            }
            else if (model.ProductImageTopView != "")
            {
                baseModel.ProductImageTopView = model.ProductImageTopView;
            }
            else
            {
                baseModel.ProductImageTopView = "/Content/NoImage.gif";
            }


            //HttpPostedFileBase pfbBottomView = Request.Files["Addproduct.ProductImageBottomView"];
            HttpPostedFileBase pfbBottomView = Request.Files["ProductImageBottomView"];
            if (pfbBottomView != null && pfbBottomView.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfbBottomView.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
                                   uploadedfilename);
                pfbBottomView.SaveAs(filePath);
                baseModel.ProductImageBottom = uploadedfilename;

            }
            else if (model.ProductImageBottomView != "")
            {
                baseModel.ProductImageBottom = model.ProductImageBottomView;
            }
            else
            {
                baseModel.ProductImageBottom = "/Content/NoImage.gif";
            }

            //HttpPostedFileBase pfbImageDeailView = Request.Files["Addproduct.ProductImageDetail"];
            HttpPostedFileBase pfbImageDeailView = Request.Files["ProductImageDetail"];
            if (pfbImageDeailView != null && pfbImageDeailView.ContentLength > 0)
            {
                string uploadedfilename = Guid.NewGuid().ToString().Substring(0, 5) + "_" + pfbImageDeailView.FileName;

                if (!System.IO.Directory.Exists(Server.MapPath("~/Content/ProductImage/")))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("~/Content/ProductImage/"));
                }
                string filePath = System.IO.Path.Combine(HttpContext.Server.MapPath("~/Content/ProductImage/"),
                                   uploadedfilename);
                pfbImageDeailView.SaveAs(filePath);
                baseModel.ProductImageDetail = uploadedfilename;

            }
            else if (model.ProductImageDetail != "")
            {
                baseModel.ProductImageDetail = model.ProductImageDetail;
            }
            else
            {
                baseModel.ProductImageDetail = "/Content/NoImage.gif";
            }
            baseModel.CreatedBy = 0;

            bool check = adminAction.addProduct(baseModel);
            if (check)
            { TempData["Success"] = "Product Updated Successfully."; }
            else
            { TempData["Error"] = "Failed to Update Product."; }
            return RedirectToAction("AddProduct");

        }




        [HttpGet]
        public ActionResult ShpingDetails()
        {

            List<SelectListItem> couriercategoryList = new List<SelectListItem>();
            actionResult = adminAction.getCourierCategory();
            couriercategoryList = actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["CourierCategory"].ToString(), Value = v["CourierCategory"].ToString() }).ToList();
            ViewBag.couriercategoryList = couriercategoryList;

            List<SelectListItem> productList = new List<SelectListItem>();
            actionResult = adminAction.getProduct();
            productList = actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["ProductName"].ToString(), Value = v["ProductName"].ToString() }).ToList();
            ViewBag.productList = productList;

            List<SelectListItem> stateList = new List<SelectListItem>();
            actionResult = adminAction.getState();
            stateList = actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["StateName"].ToString(), Value = v["StateName"].ToString() }).ToList();
            ViewBag.stateListList = stateList;

            ManageShipingDetail manage = new ManageShipingDetail();
            List<ShipingDetail> shipingDetailList = new List<ShipingDetail>();

            ShippingDetailBase basemodel = new ShippingDetailBase();
            basemodel.ShippingID = 0;
            actionResult = adminAction.getShipingDetails(basemodel);

            if (actionResult.IsSuccess)
            {
                shipingDetailList = Helper.ConvertTo<ShipingDetail>(actionResult.dtResult);
            }
            manage.shipingDetailList = shipingDetailList;

            return View(manage);

        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ShipingDetails(ManageShipingDetail model)
        {
            ShippingDetailBase basemodel = new ShippingDetailBase();
            basemodel.Action = 0;

            basemodel.SourceName = model.shipingDetail.SourceName;
            basemodel.StateName = model.shipingDetail.StateName;
            basemodel.CourierName = model.shipingDetail.CourierName;
            basemodel.ProductName = model.shipingDetail.Product;
            basemodel.CourierCategory = model.shipingDetail.CourierCategory;
            basemodel.CourierCharge = model.shipingDetail.CourierCharge;
            basemodel.ProductDimension = model.shipingDetail.ProductDimensioon;
            basemodel.ProdctWeight = model.shipingDetail.ProdctWeight;
            basemodel.CreatedBy = 1;
            bool check = adminAction.AddUpdateShippingDetail(basemodel);

            if (check)
            {

                TempData["SuccessMessage"] = "Shiping Details Added Successfully..!";
                return RedirectToAction("ShpingDetails");

            }
            else
            {
                TempData["ErrorMessage"] = "Failed to Add Shiping Details..!";
                return View();
            }
            return View();

        }

        [HttpGet]
        public ActionResult UpdateShipingDetail(int id = 0)
        {
            ShippingDetailBase model = new ShippingDetailBase();
            List<SelectListItem> shipingDetailList = new List<SelectListItem>();
            model.ShippingID = id;

            List<SelectListItem> couriercategoryList = new List<SelectListItem>();
            actionResult = adminAction.getCourierCategory();
            couriercategoryList = actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["CourierCategory"].ToString(), Value = v["CourierCategory"].ToString() }).ToList();
            ViewBag.couriercategoryList = couriercategoryList;

            List<SelectListItem> productList = new List<SelectListItem>();
            actionResult = adminAction.getProduct();
            productList = actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["ProductName"].ToString(), Value = v["ProductName"].ToString() }).ToList();
            ViewBag.productList = productList;

            List<SelectListItem> stateList = new List<SelectListItem>();
            actionResult = adminAction.getState();
            stateList = actionResult.dtResult.AsEnumerable().Select(v => new SelectListItem { Text = v["StateName"].ToString(), Value = v["StateName"].ToString() }).ToList();
            ViewBag.stateListList = stateList;


            ShipingDetail manage = new ShipingDetail();

            ShippingDetailBase basemodel = new ShippingDetailBase();
            basemodel.ShippingID = id;
            actionResult = adminAction.getShipingDetails(basemodel);

            if (actionResult.IsSuccess)
            {
                manage = Helper.ConvertTo<ShipingDetail>(actionResult.dtResult).ElementAtOrDefault(0);
            }

            return View(manage);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UpdateShipingDetail(ShipingDetail model)
        {
            ShippingDetailBase basemodel = new ShippingDetailBase();
            basemodel.Action = 1;
            basemodel.ShippingID = model.ShippingId;
            basemodel.SourceName = model.SourceName;
            basemodel.StateName = model.StateName;
            basemodel.CourierName = model.CourierName;
            basemodel.ProductName = model.Product;
            basemodel.CourierCategory = model.CourierCategory;
            basemodel.CourierCharge = model.CourierCharge;
            basemodel.ProductDimension = model.ProductDimensioon;
            basemodel.ProdctWeight = model.ProdctWeight;
            basemodel.CreatedBy = 1;
            bool check = adminAction.AddUpdateShippingDetail(basemodel);

            if (check)
            {

                TempData["SuccessMessage"] = "Shiping Details Updated Successfully..!";
                return RedirectToAction("ShpingDetails");

            }
            else
            {
                TempData["ErrorMessage"] = "Failed to Add Shiping Details..!";
                return View();
            }
            return View();

        }

        public ActionResult getEnquieryDetails()
        {
            EnquieryDetailModel manage = new EnquieryDetailModel();
            List<EnquieryDetail> enquieryList = new List<EnquieryDetail>();
            actionResult = adminAction.getEnquieryDetail();

            if (actionResult.IsSuccess)
            {
                enquieryList = Helper.ConvertTo<EnquieryDetail>(actionResult.dtResult);
            }
            manage.EnquieryDetailList = enquieryList;

            return View(manage);


        }
        public ActionResult getComplaintsDetails()
        {
            ComplaintDetailModel manage = new ComplaintDetailModel();
            ComplaintDetailBase objBase = new ComplaintDetailBase();
            List<ComplaintDetail> complainList = new List<ComplaintDetail>();
            objBase.Id = 0;
            actionResult = adminAction.getComplaintDetail(objBase);

            if (actionResult.IsSuccess)
            {
                complainList = Helper.ConvertTo<ComplaintDetail>(actionResult.dtResult);
            }
            manage.ComplainDetailList = complainList;

            return View(manage);


        }

        [HttpGet]
        public ActionResult updateComplaintDetail(int id = 0)
        {

            List<SelectListItem> shipingDetailList = new List<SelectListItem>();

            List<SelectListItem> complaintList = new List<SelectListItem>();
            complaintList.Add(new SelectListItem() { Text = "Success", Value = "Success" });
            complaintList.Add(new SelectListItem() { Text = "Pending", Value = "Pending" });

            SelectList sl = new SelectList(complaintList, "Value", "Text");
            ViewBag.complaintList = sl;

            ComplaintDetail manage = new ComplaintDetail();

            ComplaintDetailBase basemodel = new ComplaintDetailBase();
            basemodel.Id = id;
            actionResult = adminAction.getComplaintDetail(basemodel);

            if (actionResult.IsSuccess)
            {
                manage = Helper.ConvertTo<ComplaintDetail>(actionResult.dtResult).ElementAtOrDefault(0);
            }

            return View(manage);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult updateComplaintDetail(ComplaintDetail model, FormCollection fc)
        {
            ComplaintDetailBase baseModel = new ComplaintDetailBase();
            baseModel.CustomerName = model.CustomerName;
            baseModel.CustomerContact = model.ContactNo;
            baseModel.CustomerEmail = model.CustomerEmail;
            baseModel.DealerName = model.DealerName;
            baseModel.InvoiceNo = model.InvoiceNo;
            //baseModel.PurchaseDate =DateTime.Now;
            baseModel.PurchaseDate = model.PurchaseDate;
            baseModel.ProductSerial = model.ProductSerialNo;
            baseModel.ModalNo = model.ModalNo;
            baseModel.Complaint = model.Complaint;
            baseModel.UpdateStatus = fc["status"];
            baseModel.Addremark = model.Remark;
            baseModel.ModifyBy = 1;
            baseModel.Action = 1;
            bool check = adminAction.AddUpdateComplaintDetail(baseModel);

            if (check)
            {

                TempData["SuccessMessage"] = "Complaint Details Updated Successfully..!";
                return RedirectToAction("getComplaintsDetails");

            }
            else
            {
                TempData["ErrorMessage"] = "Failed to Update Complaint Details..!";
                return RedirectToAction("updateComplaintDetail");
            }

            return View();
        }

        [HttpGet]
        public ActionResult myOrderDetail()
        {
            MyOrderDetailModel manage = new MyOrderDetailModel();

            List<MyOrderDetail> orderList = new List<MyOrderDetail>();

            actionResult = adminAction.getmyOrderDetail(0);
            System.Globalization.CultureInfo customCulture = new System.Globalization.CultureInfo("en-US", true);
            customCulture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;

            if (actionResult.IsSuccess)
            {
                orderList = Helper.ConvertTo<MyOrderDetail>(actionResult.dtResult);
            }

            manage.myOrderDetailList = orderList;

            return View(manage);
        }


        [HttpGet]
        public ActionResult viewOrderDetail(int id = 0)
        {
            MyOrderDetailModel manage = new MyOrderDetailModel();

            List<MyOrderDetail> orderList = new List<MyOrderDetail>();

            actionResult = adminAction.getmyOrderDetail(id);

            if (actionResult.IsSuccess)
            {
                orderList = Helper.ConvertTo<MyOrderDetail>(actionResult.dtResult);
            }
            manage.myOrderDetailList = orderList;

            return View(manage);


        }

        [HttpGet]
        public ActionResult PckingDetail(int id = 0)
        {
            MyOrderDetailModel manage = new MyOrderDetailModel();

            List<MyOrderDetail> orderList = new List<MyOrderDetail>();

            actionResult = adminAction.getmyOrderDetail(id);

            if (actionResult.IsSuccess)
            {
                orderList = Helper.ConvertTo<MyOrderDetail>(actionResult.dtResult);
            }
            manage.myOrderDetailList = orderList;

            return View(manage);
        }

        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(FormCollection fc)
        //public FileResult Export(string contentHtml)
        {
            string contentHtml = fc["contentHtml"];
            contentHtml = contentHtml.Replace("\\s+", " ");
           
                HtmlNode.ElementsFlags["input"] = HtmlElementFlag.Closed;
                HtmlNode.ElementsFlags["br"] = HtmlElementFlag.Closed;
                HtmlDocument doc = new HtmlDocument();
                doc.OptionFixNestedTags = true;
                doc.LoadHtml(contentHtml);
                contentHtml = doc.DocumentNode.OuterHtml;

                using (MemoryStream stream = new System.IO.MemoryStream())
                {
                    StringReader sr = new StringReader(contentHtml);
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    pdfDoc.Close();
                    return File(stream.ToArray(),"application/pdf","Grid.pdf");
                }
           
        }
        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult DiscountCoupons()
        {
            List<CustomerCoupon> model=new  List<CustomerCoupon>();
            try
            {
                var data = adminAction.getCouponList(null);
                if (data.dtResult != null)
                {
                    foreach (DataRow dr in data.dtResult.Rows)
                    {
                        model.Add(new CustomerCoupon
                        {
                            CustomerCouponID = Convert.ToInt32(dr["CustomerCouponID"]),
                            CustomerName= dr["CustomerName"].ToString(),
                            CouponCode = dr["CouponCode"].ToString(),
                            CustomerId = Convert.ToInt32(dr["CustomerId"].ToString()),
                            ExpiredOn = Convert.ToDateTime(dr["ExpiredOn"].ToString()),
                            
                            DiscountType = dr["DiscountType"].ToString(),
                            Discount = Convert.ToDecimal(dr["Discount"]),
                            Remarks = dr["Remarks"].ToString(),
                            MinPurchaseAmount = dr["MinPurchaseAmount"]==DBNull.Value?0.0: Convert.ToDouble(dr["MinPurchaseAmount"]),
                                isCustom=false,
                            isUsed = dr["isUsed"]== DBNull.Value ? false: Convert.ToBoolean(dr["isUsed"].ToString()),
                            UsedOn = dr["UsedOn"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["UsedOn"])
                             });

                    }
                }
            }
            catch (Exception ex)
            {
            }
          
            //model.CouponCode = GenrateRandonPassword.GetCapitalUniqueKey(6);
            return View(model);
        }
        [HttpGet]
        public ActionResult DiscountCoupon()
        {
            CustomerCoupon model = new CustomerCoupon();
            model.CouponCode = GenrateRandonPassword.GetCapitalUniqueKey(6);
            return View(model);
        }
        [HttpPost]
        public ActionResult DiscountCoupon(CustomerCoupon model)
        {
            var Nmodel = new MGA.ActionLayer.Model.CustomerCoupon
            {
                CustomerCouponID = model.CustomerCouponID,
                CouponCode = model.CouponCode,              
                isCustom = model.isCustom,
                CustomerId = model.CustomerId??0,
                ExpiredOn = model.ExpiredOn,
                DiscountType = model.DiscountType,
                Discount = model.Discount,
                Remarks = model.Remarks,
                MinPurchaseAmount = model.MinPurchaseAmount
            };

            var res= adminAction.SaveCustomerCoupons(Nmodel);
            if (res != null)
            {

                bool result = false;
                try
                {

                    int otpValue = new Random().Next(100000, 999999);
                    //string message = "Your offer is  " + model.Remarks + " ( Sent By : MGACharger-N.K Gupta)";
                    string message = "Your offer is " + model.Remarks + "  ECOUPON :" + model.CouponCode;
                    WebClient Client = new WebClient();
                    string Recipient ="";

                    # region New region
                  try
                  {
                        MGA.DataLayer.Account.AccountDL accountdl = new MGA.DataLayer.Account.AccountDL();
                        actionResult.dtResult = accountdl.AllUserDetail(Convert.ToString(model.CustomerId),0,3);
                        if (actionResult.dtResult.Rows.Count > 0)
                        {
                            Recipient = actionResult.dtResult.Rows[0]["ContactNo"].ToString();
                           
                        }
                    }
                    catch (Exception)
                    {

                    }
                    #endregion 

                    string baseurl = "http://smsfortius.com/api/mt/SendSMS?user=mgaelectronics&password=123123&senderid=MGAELE&channel=Trans&DCS=0&flashsms=0&number=" + Recipient + "&text=" + message + "&route=2";
                    
                    Stream data = Client.OpenRead(baseurl);
                    StreamReader reader = new StreamReader(data);
                    string s = reader.ReadToEnd();
                    data.Close();
                    reader.Close();
                    result = true;
                  
                }
                catch (Exception ex)
                {
                    return Json(result, JsonRequestBehavior.AllowGet);
                }


            }
            ModelState.Clear();
            model.CouponCode = GenrateRandonPassword.GetCapitalUniqueKey(6);
            return RedirectToAction("DiscountCoupon");
        }

        [HttpPost]
        public JsonResult getCustomerList(string Prefix)
        {

            List<CustomerList>customerList = new List<CustomerList>();
            actionResult = adminAction.getCustomerList(Prefix);
            if (actionResult.IsSuccess)
            {
                customerList = Helper.ConvertTo<CustomerList>(actionResult.dtResult);
            }           
            return Json(customerList, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult getCouponDetails(string couponCode,int? custid)
        {
            List<CustomerCoupon> CustomerCouponlist = new List<CustomerCoupon>();
            custid = Convert.ToInt32(Session["userId"]);    
            actionResult = adminAction.getCouponDetails( couponCode,  custid??0);
            if (actionResult.IsSuccess)
            {
                CustomerCouponlist = Helper.ConvertTo<CustomerCoupon>(actionResult.dtResult);
            }
            return Json(CustomerCouponlist, JsonRequestBehavior.AllowGet);
        }
    }
}


