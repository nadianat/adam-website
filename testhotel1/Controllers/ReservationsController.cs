using Microsoft.AspNetCore.Mvc;
using VendingMachine.Services.ViewModel;
using VendingMachine.Services;
using Tesseract;
using System.Drawing;
using System.Text.RegularExpressions;

namespace testhotel.Web.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ReservationsController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        public readonly VendingMachineServices VMServices = new VendingMachineServices();

        // GET: Reservations/Create
        [HttpGet]
        public ActionResult RoomType()
        {
            HotelInfoViewModel hotelInfo = VMServices.GetHotelInfo();
            return View(hotelInfo);
        }

        public ActionResult GuestInfo()
        {
            return View();
        }

        public ActionResult ICCapture()
        {
            ViewBag.Result = false;
            ViewBag.Title = "Capture IC Pic";
            return View();
        }

        //convert from image to byte array
        public static byte[] ImageToByteArray(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        //what happens lepas submit gambar -> tesseract baca image (read dataurl)
        [HttpPost]
        public ActionResult Submit(String file)
        {
            
            if (file == null) //|| file.Length == 0)
            {
                ViewBag.Result = true;
                ViewBag.res = "File not Found";
                return View("ICCapture");
            }

            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string path = "";
            path = Path.Combine(contentRootPath, "tessdata");

            using (var engine = new TesseractEngine(path, "eng", EngineMode.Default))
            {
                var base64Data = Regex.Match(file, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
                var binData = Convert.FromBase64String(base64Data);
                using (var ms = new MemoryStream(binData))
                {
                    Bitmap image = new Bitmap(ms);
                    using (var pix = Pix.LoadFromMemory(ImageToByteArray(image)))
                    {
                        using (var page = engine.Process(pix))
                        {
                            ViewBag.Result = true;
                            ViewBag.res = page.GetText();
                            ViewBag.mean = String.Format("{0:p}", page.GetMeanConfidence());
                            return View("ICCapture");
                        }
                    }
                }
                return View("ICCapture");
            }
        }



    }
}

