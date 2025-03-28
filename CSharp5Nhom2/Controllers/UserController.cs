﻿using CSharp5Nhom2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace CSharp5Nhom2.Controllers
{
    public class UserController : Controller
    {
        DBSach context;
        public UserController()
        {
            context = new DBSach();
        }
        public ActionResult Index()
        {
            var index = context.users.ToList();
            return View(index);
        }

        // GET: DongVatController/Details/5
        public ActionResult Details(Guid id)
        {
            var details = context.users.Find(id);
            return View(details);
        }

        // GET: DongVatController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DongVatController/Create
        [HttpPost]
        public ActionResult Create(User users)
        {
            try
            {
                users.IDUser = Guid.NewGuid();
                context.users.Add(users);
                context.SaveChanges();
                TempData["Status"] = "Tạo tài khoản thành công";
                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // GET: DongVatController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var edit = context.users.Find(id);
            return View(edit);
        }

        // POST: DongVatController/Edit/5
        [HttpPost]
        public ActionResult Edit(User users)
        {
            var item = context.users.Find(users.IDUser);
            item.Username = users.Username;
            item.MatKhau = users.MatKhau;
            item.SDT = users.SDT;
            item.NgaySinh = users.NgaySinh;
            item.Address = users.Address;

            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            var delete = context.users.Find(id);
            context.Remove(delete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

      
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(User user)
        {
            try
            {
                var tontai = context.users.FirstOrDefault(p => p.Username == user.Username);
                if (tontai != null)
                {
                    TempData["acctontai"] = $"Username {user.Username} đã được sử dụng, vui lòng chọn username khác";
                    return RedirectToAction("Create");
                }
                else
                {
                    if (user.IDUser == Guid.Empty)
                    {
                        user.IDUser = Guid.NewGuid();
                    }
                    context.users.Add(user);
                    GioHang giohang = new GioHang()
                    {
                        IDGH = Guid.NewGuid(),
                        IDUser = user.IDUser,
                        Status = 1
                    };
                    context.gioHangs.Add(giohang);
                    context.SaveChanges();
                    TempData["Status"] = "Tạo tài khoản thành công";
                    return RedirectToAction("Login", "Home");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }

        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index", "Home");
        }

    }
}
