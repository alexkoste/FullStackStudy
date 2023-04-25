using HomeWork5.Models;
using HomeWork5.Storage;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork5.Controllers
{
    public class FriendController : Controller
    {

        public IActionResult Index()
        {
            return View(FriendsCollection.Friends);
        }

        public IActionResult AddFriend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFriend(FriendModel friend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            FriendsCollection.Friends.Add(friend);
            return View("Index", FriendsCollection.Friends);
        }

        public IActionResult UpdateFriend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateFriend(FriendModel friend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var friendToUpdate = FriendsCollection.Friends.First(e => e.FriendId.Equals(friend.FriendId));
            FriendsCollection.Friends.Remove(friendToUpdate);
            FriendsCollection.Friends.Add(friend);
            return View("Index", FriendsCollection.Friends);
        }

        public IActionResult DeleteFriend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteFriend(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var friendToUpdate = FriendsCollection.Friends.First(e => e.FriendId.Equals(id));
            FriendsCollection.Friends.Remove(friendToUpdate);
            return View("Index", FriendsCollection.Friends);
        }

    }
}
