using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using E_Recarga.Models;
using E_Recarga.ViewModels;

namespace E_Recarga.Controllers
{
    [Authorize(Roles = RoleName.CanManagePostos)]
    public class UtilizadoresController : Controller
    {
        public ViewResult Index()
        {

            using (var context = new ApplicationDbContext())
            {
                var sql_nome = @"
            SELECT AspNetUsers.UserName, AspNetRoles.Name As Role 
            FROM AspNetUsers 
            LEFT JOIN AspNetUserRoles ON  AspNetUserRoles.UserId = AspNetUsers.Id 
            LEFT JOIN AspNetRoles ON AspNetRoles.Id = AspNetUserRoles.RoleId";


                var result = context.Database.SqlQuery<UsersWithRoles>(sql_nome).ToList();

                return View(result);
            }
        }

        public ViewResult Details()
        {
            using (var context = new ApplicationDbContext())
            {
                var sql_saldo = @"
            SELECT AspNetUsers.Saldo, AspNetRoles.Name As Role 
            FROM AspNetUsers 
            LEFT JOIN AspNetUserRoles ON  AspNetUserRoles.UserId = AspNetUsers.Id 
            LEFT JOIN AspNetRoles ON AspNetRoles.Id = AspNetUserRoles.RoleId";


                var result = context.Database.SqlQuery<UsersWithRoles>(sql_saldo).ToList();

                return View(result);
            }
        }
    }
}