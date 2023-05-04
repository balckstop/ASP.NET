// using System.IO;
// using HyperMart.Models;
// using Microsoft.AspNetCore.Mvc;
// using Newtonsoft.Json;

// namespace HyperMart.Controllers
// {
//     public class LoginController : Controller
//     {
//         private readonly string _filePath;

//         public LoginController()
//         {
//             _filePath = Path.Combine(Directory.GetCurrentDirectory(), "LoginUsers.json");
//         }

//         [HttpPost]
//         public IActionResult Create(LoginModel user)
//         {
//             var users = LoadUsersFromFile();
//             users.Add(user);
//             SaveUsersToFile(users);
//             return RedirectToAction("Index", "Home");
//         }

//         private List<LoginModel> LoadUsersFromFile()
//         {
//             if (!System.IO.File.Exists(_filePath))
//             {
//                 return new List<LoginModel>();
//             }
//             var json = System.IO.File.ReadAllText(_filePath);
//             return JsonConvert.DeserializeObject<List<LoginModel>>(json);
//         }

//         private void SaveUsersToFile(List<LoginModel> users)
//         {
//             var json = JsonConvert.SerializeObject(users);
//             System.IO.File.WriteAllText(_filePath, json);
//         }
//     }
// }