using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP_original_
{
    public class Contact
    {
        // We Difinds Parameters For In project
    public string FirstName;
    public string LastName;
    public string Ncode;
    public string EMail;

    //We Difind Local Adress
    public static string path = @"F:\EhsanSadegh\CNP(original)1Rec\CNP(original)\RECord.txt";
        
    
        //This Parameter is For Handling Not Founding File 
    public   static bool IsThereFile = true;
    

// This List Array For Save Data And Use All
      public static List<Contact> ContactList = new List<Contact>();

        


        public static void Save()
        {
             string textForSave = string.Empty;
            string clear = " ";
            System.IO.File.WriteAllText(path, clear);


            for (int i = 0; i < ContactList.Count; i++)
            {
                Contact c1 = ContactList[i];

                textForSave += c1.FirstName;
                textForSave += Environment.NewLine;
                textForSave += c1.LastName;
                textForSave += Environment.NewLine;
                textForSave += c1.Ncode;
                textForSave += Environment.NewLine;
                textForSave += c1.EMail;
                textForSave += Environment.NewLine; 
            }
            
            System.IO.File.WriteAllText(path, clear);
            System.IO.File.WriteAllText(path,textForSave);
            
        }

        public static void Load()
        {
            string[] splited;
            string AllText;

            try
            {
                AllText = System.IO.File.ReadAllText(path);
                splited = AllText.Split(Convert.ToChar("\n"));


                for (int i = 0; i < AllText.Length; i += 4)
                {
                    Contact c1 = new Contact();

                    c1.FirstName = splited[i];
                    c1.LastName = splited[i + 1];
                    c1.Ncode = splited[i + 2];
                    c1.EMail = splited[i + 3];

                    ContactList.Add(c1);
                }
            }

            catch
            {
                //IsThereFile = false;
            }
        }
    }
}
