using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Customr customer1 = new Customr()
        {
            firstname = "Adhithya",
            lastname = "P",
            phone = " 9995574970"
        };
        Customr customer2 = new Customr()
        {
            firstname = "Lishmi",
            lastname = "P",
            phone = "9895574970"
        };
        Customr customer3 = new Customr()
        {
            firstname = "Parvathi",
            lastname = "K",
            phone = "7895574970"
        };

        List<Customr> Custmers = new List <Customr>(3);

        Custmers.Add(customer1);
        Custmers.Add(customer2);
        Custmers.Add(customer3);
        Customr co = Custmers[0];

        foreach (Customr c in Custmers)
        {
            Console.WriteLine("firstname={0}, lastname= {1}, phone={2}", co.firstname, co.lastname, co.phone);
        }
    }

    public class Customr
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }
    }
}

