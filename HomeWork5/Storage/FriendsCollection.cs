using HomeWork5.Models;

namespace HomeWork5.Storage
{
    public static class FriendsCollection
    {
        public static List<FriendModel> Friends;
        public static void Init()=> Friends = new List<FriendModel>() { new FriendModel() { FriendId = "Test1", FriendName = "Test1-1", Place = "Test1-3" } };
    }
}
