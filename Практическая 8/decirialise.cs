using Newtonsoft.Json;

namespace Практическая_8
{
    internal class decirialise
    {
        private static List<users> users_info = new List<users>();

        public static void add_user(users user)
        {
            out_json();
            users_info.Add(user);
            in_json();
        }

        private static void in_json()
        {
            string json = JsonConvert.SerializeObject(users_info);
            File.WriteAllText("Table.json", json);
        }

        public static void out_json()
        {
            string to_json = File.ReadAllText("Table.json");
            users_info = JsonConvert.DeserializeObject<List<users>>(to_json);
        }
        
        public static void vuvod()
        {
            Console.Clear();
            foreach (var user in users_info.OrderBy(x => x.minute))
            {
                Console.WriteLine("Имя:" + user.Name + "Результат работы в минутах: " + user.minute +  "Результат работы в секундах: " + user.sec);
            }
        }
    }
}
