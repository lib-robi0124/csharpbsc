using qinshift.classAndobjects.Models;
#region simple class user


//User user = new User();
//user.UserName = "robertr";
//user.Password = "12345";
//Console.WriteLine(user.UserName);

#endregion


#region Classes and Objects

Person bob = new Person();
bob.FirstName = "Bob";
bob.Lastname = "Bobsky";
bob.Age = 30;
// bob.SSN is private
bob.Talk("hey there! we are learning classes and Objects!");

Person jill = new Person("jill", "Wayne", 35);
jill.Talk("Hi there!!!");
//Console.WriteLine(jill.GetSSN);


#endregion

Console.ReadLine();
