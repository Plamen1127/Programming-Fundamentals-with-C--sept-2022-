using System;
using System.Collections.Generic;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtySongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 1; i <= qtySongs; i++)
            {
                string[] data = Console.ReadLine()
                    .Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];
                Song song = new Song(data[0], data[1], data[2]);
                songs.Add(song);

            }

            string command = Console.ReadLine();

            if( command == "all")
            {
                foreach(Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach(Song song in songs)
                {
                    if ( command == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                    
                }
            }
        }
    }
    class Song
    {
        public Song( string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
