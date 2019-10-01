using FriendSys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FriendSys
{
    class Program
    {
        static void Main(string[] args)
        {
            var friendList = new List<Amigos>
            {
                new Amigos()
                {
                    Name = "Anna",
                    Friendship = 5 },
                new Amigos()
                {
                    Name = "Bruno",
                    Friendship = 11 },
                new Amigos()
                {
                    Name = "Carol",
                    Friendship = 19 },

            };
            friendList.ForEach(i => Console.WriteLine($"Nome: {i.Name} -- Tempo de Amizade: {i.Friendship} meses"));
            Console.ReadKey();
        }
    }
}
