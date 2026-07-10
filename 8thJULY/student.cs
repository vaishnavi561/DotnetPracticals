//class- logical entity ,it defines properties and functions 
//store values of similar data 
// {}-- to grouping of data
// ()-- passing parameters ,arguments,
//[]--arrays

using System;
using System.Reflection;
public class student
{
   String name; 
   int rollno;
   long dob;
   String branch;
   char gender;
   float height;
   String institute;


   public student (int r,String n,long d,String b,char g,float h, String institute)
    {
        this.rollno=r;
        this.name=n;
        this.height=h;
        this.gender=g;
        this.institute=institute;
        long dob=d;
        String branch=b;


        
    }
   

   public void display()
    {
        Console.WriteLine(rollno+" " +name+" "+dob+" "+gender+" ");
        Console.WriteLine();
    }
}