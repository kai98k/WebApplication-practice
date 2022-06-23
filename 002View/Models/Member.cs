using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace _02View.Models
{
    //03-5-2 在Member class中輸入下列欄位以建立Model
    public class Member
    {
        [DisplayName("使用者名稱")]
        public string UserId { get; set; }
        [DisplayName("使用者密碼")]
        public string Pwd { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}