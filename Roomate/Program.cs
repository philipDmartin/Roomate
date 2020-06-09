using System;
using System.Collections.Generic;
using System.Linq;
using Roommates.Models;
using Roommates.Repositories;

namespace Roommates
{
    class Program
    {
        /// <summary>
        ///  This is the address of the database.
        ///  We define it here as a constant since it will never change.
        /// </summary>
        private const string CONNECTION_STRING = @"server=localhost\SQLExpress;database=Roommates;integrated security=true";

        static void Main(string[] args)
        {
            //Get All roommates

            //RoommateRepository roommateRepo = new RoommateRepository(CONNECTION_STRING);

            //Console.WriteLine("Getting All Roommates:");
            //Console.WriteLine();

            //List<Roommate> allRoommates = roommateRepo.GetAll();

            //foreach (Roommate roommate in allRoommates)
            //{
            //    Console.WriteLine($"{roommate.Id} {roommate.FirstName} {roommate.LastName} {roommate.RentPortion} {roommate.MoveInDate}");
            //}

            //Get roommates By Id

            //RoommateRepository roommateRepo = new RoommateRepository(CONNECTION_STRING);

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Getting Roommate with Id 1");

            //Roommate singleRoommate = roommateRepo.GetById(1);

            //Console.WriteLine($"{singleRoommate.Id} {singleRoommate.FirstName} {singleRoommate.LastName} {singleRoommate.RentPortion} {singleRoommate.MoveInDate}");

            //Get roommate With All rooms

            //RoommateRepository roommateRepo = new RoommateRepository(CONNECTION_STRING);

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Getting Roommate with Rooms");

            //List<Roommate> withRooms = roommateRepo.GetAllWithRoom();

            //foreach (Roommate roommate in withRooms)
            //{
            //    Console.WriteLine($"{roommate.Id} {roommate.FirstName} {roommate.LastName} {roommate.RentPortion} {roommate.MoveInDate} {roommate.Room.Name} {roommate.Room.MaxOccupancy}");
            //}

            //Create New roommate

            RoomRepository roomRepo = new RoomRepository(CONNECTION_STRING);

            RoommateRepository roommateRepo = new RoommateRepository(CONNECTION_STRING);

            List<Room> someRooms = roomRepo.GetAll();

            Room aRoom = someRooms.First();

            Roommate joe = new Roommate()
            {
                FirstName = "joe",
                LastName = "perry",
                RentPortion = 100,
                MoveInDate = DateTime.Now,
                Room = aRoom
            };

            roommateRepo.Insert(joe);

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Added the new Roommate with id {joe.Id} and name {joe.FirstName}: {joe.RentPortion} {joe.MoveInDate} {joe.Room.Name}");

            //Get All rooms

            //RoomRepository roomRepo = new RoomRepository(CONNECTION_STRING);

            //Console.WriteLine("Getting All Rooms:");
            //Console.WriteLine();

            //List<Room> allRooms = roomRepo.GetAll();

            //foreach (Room room in allRooms)
            //{
            //    Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            //}

            //Get room By Id

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Getting Room with Id 1");

            //Room singleRoom = roomRepo.GetById(1);

            //Console.WriteLine($"{singleRoom.Id} {singleRoom.Name} {singleRoom.MaxOccupancy}");

            //Create New room

            //Room bathroom = new Room
            //{
            //    Name = "Bathroom",
            //    MaxOccupancy = 1
            //};

            //roomRepo.Insert(bathroom);

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine($"Added the new Room with id {bathroom.Id} and name {bathroom.Name}: {bathroom.MaxOccupancy}");

            //Update room

            //bathroom.Name = "Pooproom";
            //bathroom.MaxOccupancy = 3;
            //roomRepo.Update(bathroom);

            //allRooms = roomRepo.GetAll();

            //foreach (Room room in allRooms)
            //{
            //    Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            //}

            //Delete room

            ////roomRepo.Delete(17);
            ////roomRepo.Delete(18);
            ////roomRepo.Delete(19);
            ////roomRepo.Delete(20);
        }
    }
}
