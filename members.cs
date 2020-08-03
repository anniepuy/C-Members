using System;

namespace memberProgram
{
    class members
    {
        //members variables - private field
        private string memberName;
        private string jobTitle;
        private int salary ;

        //public fields - member variables. 
        public int age;



    //Properties of the class members - exposes the job titles safely without
    //allowing open changes made by other people. Must have a capital letter
        public string JobTitle 
        { 
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            } 
        }

    //Now lets create a member method. - public member method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if(isFriend) 
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}, and I am not your friend!! MUHAHAHA! My job title is {1}.", memberName, jobTitle);
            }
        }
        //We are going to create a private method to share private info.
        private void SharingPrivateInfo()
        {
            Console.WriteLine("Hello. My salary is {0}", salary);
        }

        //A contstructor is also a member of the class members..here we create one.
        public members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 350000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //deconstructor is only defined within a class. One per class. member - finalizer - destructor
        //this is called when the object runs out of scope, this is called.
        ~members()
        {
            //cleanup statements
            //Do not use if it is empty..only if needed.
            Console.WriteLine("Deconstruction of members object");
        }
    }
}