using BigOn.WebUI.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigOn.WebUI.Models.Entities
{
    public class ContactPost : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
       
        //clientin mesaji
        public string Message { get; set; }
        
        //Adminin cavabi
        public string Answer { get; set; }

        //Hansi admin terefinden cavablandirilib
        public int? AnswerByUserId { get; set; }


        //Adminin cavabi null ola biler
        public DateTime? AnswerDate { get; set; }



    }
}
