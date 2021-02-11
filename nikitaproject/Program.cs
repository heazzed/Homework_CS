using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nikitaproject
{
    class Program
    {
        const string PathFile = "accounts.info";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("@");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

        }

        public class AccountUser
        {

            public AccountUser(string name, string pass, int key)
            {
                Name = name;
                Password = pass;
                KeyAcsess = key;
            }
            public string Name { get; set; }
            public string Password { get; set; }
            public int KeyAcsess { get; set; }

            public void Create()
            {
                try
                {
                    if(!File.Exists(PathFile))
                    {
                        File.Create(PathFile);

                        if (!File.Exists(PathFile))
                        {
                            throw new Exception("При создании файла возникла ошибка");

                        }
                    }


                    using(var file = new StreamWriter(PathFile))
                    {
                        file.WriteLine(this.ToString());
                    }


                    var accounts = File.ReadAllLines(PathFile).Select(x => x.Split(";"))
                        .Select(x => new AccountUser(x[0], x[1], int.Parse(x[2])));


                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error programm {ex.Message}");
                }
            }

            public  static List<AccountUser> ReadListUser()
            {
                if (!File.Exists(PathFile))
                {
                    return new List<AccountUser>();
                }


                var accounts = File.ReadAllLines(PathFile).Select(x => x.Split(";"))
                    .Select(x => new AccountUser(x[0], x[1], int.Parse(x[2])));

                return accounts.ToList();
            }


            public override string ToString()
            {
                return $"{Name};{Password};{KeyAcsess}";
            }
        }


    }
}
