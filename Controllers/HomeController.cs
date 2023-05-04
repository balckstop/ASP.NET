using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HyperMart.Models;
using System.IO;
using Newtonsoft.Json;

namespace HyperMart.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly string _filePath;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}    

//     public IActionResult Login()
//     {
//         return View();
//     }

//     [HttpPost]
//     public IActionResult Create(LoginModel user)
//     {
//         var users = LoadUsersFromFile();
//         users.Add(user);
//         SaveUsersToFile(users);
//         return RedirectToAction("Index", "Home");
//     }

//     private List<LoginModel> LoadUsersFromFile()
//     {
//         if (!System.IO.File.Exists(_filePath))
//         {
//             return new List<LoginModel>();
//         }
//         var json = System.IO.File.ReadAllText(_filePath);
//         return JsonConvert.DeserializeObject<List<LoginModel>>(json);
//     }

//     private void SaveUsersToFile(List<LoginModel> users)
//     {
//         var json = JsonConvert.SerializeObject(users);
//         System.IO.File.WriteAllText(_filePath, json);
//     }
// }

//     [HttpPost]
//     //[ValidateAntiForgeryToken]
//     public IActionResult Login(LoginModel model)
//     {
//         //string CurrentUser;
//         List<UserModel> ListUsers = new List<UserModel>();
        

//         ReadFromTable(ListUsers);
//         //var errors = ModelState.Values.SelectMany(v => v.Errors);
//         if (ModelState.IsValid)
//         {

//             foreach (var item in ListUsers)
//             {
//                 //Console.WriteLine("not avaiblie!");
//                 if (item.Name==model.Name&&item.Password==model.Password)
//                 {

//                     if(item.Name=="librarian")
//                     {
//                         CurrentUser = "librarian";
//                         user = item;
//                         return RedirectToAction("Index", "Admin");
//                     }
//                     else
//                     {
//                         user=item;
//                         CurrentUser = model.Name;
//                         return RedirectToAction("Index", "UserHome");
//                     }
                    
//                 }  
            
//             }
//             TempData["login"] = "Log In failed! No Such Account Existed!";
//             return View(model);
//         }
//         else
//         {
//             TempData["login"] = "Log In failed!";
//             return View(model);
//         }
//     }

//     public IActionResult SignUp()
//     {
//         return View();
//     }

//     [HttpPost]
//     //[ValidateAntiForgeryToken]
//     public IActionResult SignUp(SignUp model)
//     {
//         if (ModelState.IsValid)
//         {

//             try
//         {
//                 string connectionString = "Data Source=XIAOHAN\\SQLEXPRESS;Initial Catalog=FinalLibrary;Integrated Security=True";

//                 using (SqlConnection connection = new SqlConnection(connectionString))
//                 {
//                     connection.Open();
//                     string sql = "INSERT INTO users2" +
//                         "(name,password,borrowedbook,reservedbook,isborrowed,isreserved) VALUES" +
//                         "(@name,@password,'','',0,0)";
//                     using (SqlCommand command = new SqlCommand(sql, connection))
//                     {
//                         command.Parameters.AddWithValue("@name", model.Name);
//                         //command.Parameters.AddWithValue("@email", model.Email);
//                         command.Parameters.AddWithValue("@password", model.Password);

//                         command.ExecuteNonQuery();
//                         //model.SuccessMessage = "Sign Up Successfully!";

//                         TempData["AlertMessage"] = "Sign Up Successfully!";
//                         return View(model);

//                 }
//                 }
//             }


//             catch (Exception ex)
//             {
//                 //Console.WriteLine("ERROR: " + ex.Message);
//                 //model.ErrorMessage = "Sign Up Failed!";
//                 TempData["AlertMessage"] = "Sign Up Failed!";
//                 return View(model);
//             }
//         }
//         TempData["AlertMessage"] = "Sign Up Failed!";
//         return View(model);
//     }
// }
