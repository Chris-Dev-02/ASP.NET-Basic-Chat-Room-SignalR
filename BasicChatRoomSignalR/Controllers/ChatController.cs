using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BasicChatRoomSignalR.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, string> Rooms = new Dictionary<int, string>() {
                { 1, "Gaming" },
                { 2, "Programming"},
                { 3, "Series"}
        };

        public IActionResult Index()
        {
            Rooms.GetValueOrDefault(0);
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}
