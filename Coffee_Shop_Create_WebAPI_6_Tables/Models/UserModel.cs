﻿using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_Create_WebAPI_6_Tables.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }
}