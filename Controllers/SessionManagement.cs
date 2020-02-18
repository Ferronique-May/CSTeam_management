using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class SessionManagement : Controller
    {
        public bool sessionState { get; private set;}
        
        //put into login {
            HttpContext.Session.SetInt32(currentUser.Email, currentUser.Id); //possibly hash the email
            sessionState = true;
        // }
        // put into logout {
            sessionState = false;
        // }
    }
}