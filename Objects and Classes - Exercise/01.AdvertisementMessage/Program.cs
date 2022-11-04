using System;
using System.Collections.Generic;

namespace _08.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();

            List<string> phrases = new List<string>
            {"Excellent product.", "Such a great product.", "I always use that product.",
             "Best product of its category.", "Exceptional product.",
             "I can’t live without this product."};

            List<string> events = new List<string>
            {"Now I feel good.", "I have succeeded with this product.",
             "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
             "Try it yourself, I am very satisfied.", "I feel great!"};

            List<string> authors = new List<string>
            {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            List<string> cities = new List<string>
            {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int messagesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesCount; i++)
            {
                Random rand = new Random();

                string phrase = phrases[rand.Next(0, phrases.Count - 1)];
                string @event = events[rand.Next(0, events.Count - 1)];
                string author = authors[rand.Next(0, authors.Count - 1)];
                string city = cities[rand.Next(0, cities.Count - 1)];

                messages.Add(new Message(phrase, @event, author, city));
            }

            foreach (var message in messages)
            {
                Console.WriteLine($"{message.Phrase} {message.Event} {message.Author} - {message.City}");
            }

        }
    }
    public class Message
    {
        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }
        public Message(string phrase, string @event, string author, string city)
        {
            Phrase = phrase;
            Event = @event;
            Author = author;
            City = city;
        }
    }
}