using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; //使用 messagebox
using System.Threading.Tasks;

namespace Constructor_test
{
    class Student
    {
        //Property==> The property of class is that Property uses variables to record the content.
        public int StudentID;
        public string Name;
        public int Grade;
   
        public Student() // does not output any type, same name as the class
        {
            MessageBox.Show("This is a test!!");
        }

        public string Say()
        {
            return "My name is " + Name + " , I am a " + Grade + " grade student";
        }

        public string Talk(Student s) //
        {

            return Grade + " grade of " + Name + " say hello to " + s.Grade + " grade of " + s.Name;
        }


        public void Upgrade()  ///void does not return value and does not need to input data
        {
            Grade++;
        }



    }

}
