using System;


namespace People
{
    class Program
    {


        static void Main(string[] args)
        {
            Customer [] Buyers = new Customer[2];
            Employee [] Hired = new Employee[2];
            Employee E1 = new Employee();
            Employee E2 = new Employee();
            Customer C1 = new Customer();
            Customer C2 = new Customer();



            E1.ID = "684";
            E1.FirstName = "Austin";
            E1.LastName = "OBrien";
            E1.Department = "Tech";
            E1.DOB = "8/24/90";
            E1.EmployeeID = "657";
            E1.DateOfJoin = "2402";
            E2.ID = "627";
            E2.FirstName = "Matha";
            E2.LastName = "Carol";
            E2.DOB = "4/20/80";
            E2.Department = "Helpdesk";
            E2.EmployeeID = "674";
            E1.DateOfJoin = "3104";

            C1.ID = "720";
            C1.FirstName = "Henry";
            C1.LastName = "Bark";
            C1.DOB = "02/12/94";
            C1.Address = "4252 Hillbilly rd";
            C1.City = "Sherri";
            C1.State = "Texas";
            C2.ID = "843";
            C2.FirstName = "Beccy";
            C2.LastName = "Smough";
            C2.DOB = "09/15/85";
            C2.Address = "8592 Hope rd";
            C2.City = "Caroline";
            C2.State = "Maine";

            Hired[0] = E1;
            Hired[1] = E2;
            Buyers[0] = C1;
            Buyers[1] = C2;

            Console.WriteLine($"{Hired[0].ID}, {Hired[0].FirstName} {Hired[0].LastName} ,{Hired[0].DOB} ,{Hired[0].EmployeeID} , {Hired[0].Department}, {Hired[0].DateOfJoin}");
            Console.WriteLine($"{Hired[1].ID}, {Hired[1].FirstName} {Hired[1].LastName} ,{Hired[1].DOB} ,{Hired[1].EmployeeID}, {Hired[1].Department} ,{Hired[1].DateOfJoin}");
            Console.WriteLine($"{Buyers[0].ID} , {Buyers[0].FirstName} {Buyers[0].LastName}, {Buyers[0].Address}, {Buyers[0].City}, {Buyers[0].State}");
            Console.WriteLine($"{Buyers[1].ID} , {Buyers[1].FirstName} {Buyers[1].LastName}, {Buyers[1].Address}, {Buyers[1].City}, {Buyers[1].State}");

        }
    }
}
