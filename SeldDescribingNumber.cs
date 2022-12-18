using System;

namespace SelfDescribingNumber
{
    class SelfDescribing
    {
        // member variable
        string[] files = new string[100]; 



        // Checking if external files is empty
        public void CheckFile(){
            files = File.ReadAllLines("Self.in");

            // check if file is empty
            if(files.Length == 0){
                Console.WriteLine("Error in Opening File.");
            }
        }


        // getting avalable data from file
        public void ReadFromFile(){
            CheckFile();

            // getting number of testcase which is first line
            int testCase = Convert.ToInt32(files[0]);
            

            for(int i=1; i<=testCase; i++){
               string input = files[i];
               bool isSelfDescribing = true;
               int lenInput = input.Length;

                
                // check through the number if it a self describing number
                for(int j=0; j<lenInput; j++){
                    int countInput = input.Count(n => n == Convert.ToChar(Convert.ToString(j)));
                    
                    int inputSeparation = Convert.ToInt32(Convert.ToString(input[j]));
                    

                    if(countInput != inputSeparation){
                        isSelfDescribing = false;
                        break;
                    }
                }

                if(isSelfDescribing){
                    Console.WriteLine("This is a Self Describing Number");
                }else{
                    Console.WriteLine("This is not a Self Describing Number");
                }


            }
        }
    }









    class Program
    {
        static void Main(string[] args){
            SelfDescribing s = new SelfDescribing();
            s.ReadFromFile();
        }
    }
}