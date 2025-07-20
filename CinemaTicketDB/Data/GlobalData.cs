using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaTicketApp.Models;

namespace CinemaTicketApp.Data
{
    public static class GlobalData
    {
        /// <summary>
        /// المستخدم الحالي المسجل دخوله في النظام
        /// </summary>
        public static User CurrentUser { get; set; }

        // يمكن إضافة بيانات أخرى مشتركة مثل الفيلم المحدد أو العرض المحدد لاحقًا.
    }
}
