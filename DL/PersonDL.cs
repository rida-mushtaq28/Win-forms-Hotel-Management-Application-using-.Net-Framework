using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplicationGUI.BL;
using System.IO;

namespace BusinessApplicationGUI.DL
{
    public class PersonDL
    {
        public static List<Person> PersonList = new List<Person>();
        public static void AddSignedUpPerson(Person PersonObject)
        {
            PersonList.Add(PersonObject);
        }
        public static Person SignIn(Person PersonObject)
        {
            foreach (var p in PersonList)
            {
                if (p.GetUserName() == PersonObject.GetUserName() && p.GetUserPassword() == PersonObject.GetUserPassword())
                {
                    if (p is Owner)
                    {
                        return (Owner)p;
                    }
                    else if (p is Customer)
                    {
                        return (Customer)p;
                    }
                    else if (p is HouseHelp)
                    {
                        return (HouseHelp)p;
                    }
                    else
                    {
                        return PersonObject;
                    }
                }

            }

            return null;
        }
        public static bool IsValidUserName(Person PersonObj)
        {
            bool flag = true;

            foreach (Person p in PersonList)
            {
                if (p.GetUserName() == PersonObj.GetUserName())
                {
                    return false;
                }
            }
            return flag;
        }
        public static bool IsValidPassword(Person PersonObj)
        {
            bool flag = false;
            int passwordLength = PersonObj.GetUserPassword().Length;
            if (passwordLength >= 4 && passwordLength <= 8)
            {
                return true;
            }
            return flag;
        }
        public static void WriteAllUserData()
        {
            string path = "Credential.txt.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Person PersonObject in PersonDL.PersonList)
            {
                file.WriteLine(PersonObject.ToString());
            }
            file.Flush();
            file.Close();
        }
        public static void StoreUserData(Person PersonObj)
        {
            string path = "Credential.txt.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(PersonObj.ToString());
            file.Flush();
            file.Close();
        }
        public static bool LoadUserDataFromList()
        {
            string path = "Credential.txt.txt";
            StreamReader P = new StreamReader(path);
            string word;
            if (File.Exists(path))
            {
                while ((word = P.ReadLine()) != null)
                {
                    string[] splittedRecords = word.Split(',');
                    string username = splittedRecords[0];
                    string password = splittedRecords[1];
                    string Role = splittedRecords[2];
                    Person PersonObject = null;
                    //string name = splittedRecords[3];
                    if (Role == "owner")
                    {
                        PersonObject = new Owner(username, password, Role);
                        OwenerDL.AddOwnerInfoInList((Owner)PersonObject);
                    }
                    else if (Role == "customer")
                    {
                        string PhoneNoOrID = splittedRecords[4];
                        PersonObject = new Customer(username, password, Role, PhoneNoOrID);
                        CustomerDL.AddCustomerInfoInList((Customer)PersonObject);
                    }
                    else if (Role == "househelp")
                    {
                        string PhoneNoOrID = splittedRecords[4];
                        PersonObject = new HouseHelp(username, password, Role, PhoneNoOrID);
                        HouseHelpDL.AddHouseHelpInfoInList((HouseHelp)PersonObject);
                    }
                    PersonDL.AddSignedUpPerson(PersonObject);
                }
                P.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Person GetSpecificUserName(string name)
        {
            foreach (Person p in PersonList)
            {
                if (name.ToLower() == p.GetUserName())
                {
                    return p;
                }
            }
            return null;
        }
        public static void DeleteHousehelpAccount(Person personObject)
        {
            PersonList.Remove(personObject);
        }
    }
}
