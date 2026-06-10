// string

#region string initialize and compare
//string str1 = "Hello";
//string str2 = new string("Hello");
//Console.WriteLine(str1 == str2);
//Console.WriteLine(str1.Equals(str2));
//Console.WriteLine(str1.CompareTo(str2));
#endregion

#region string constructors with char parameters
//char[] chars = ['S', 'a', 'l', 'a', 'm'];
//Console.WriteLine(chars);
//string str3 = new string(chars);
//Console.WriteLine(str3);
//string str4 = new string('_', 25);
//Console.WriteLine(str4);
#endregion

#region intern pool
//string name1 = "Nadir";
//string name2 = "Nadir";
//string myName = name1;
//string name3 = new string("Nadir");
//string na = "Na";
//string dir = "dir";
//string name4 = na + dir;


////Console.WriteLine($"name1 == name2 - {name1 == name2}");
////Console.WriteLine($"name1 == myName - {name1 == myName}");
////Console.WriteLine($"name1 == name3 - {name1 == name3}");

//Console.WriteLine($"ReferenceEquals - name1, name2 -> {object.ReferenceEquals(name1, name2)}");
//Console.WriteLine($"ReferenceEquals - name1, myName -> {object.ReferenceEquals(name1, myName)}");
//Console.WriteLine($"ReferenceEquals - name1, name3 -> {object.ReferenceEquals(name1, name3)}");
//Console.WriteLine($"ReferenceEquals - name1, name4 -> {object.ReferenceEquals(name1, name4)}");

#endregion

#region string range, indicies
//string word = "lorem ipsum dolor sit amet";
////Console.WriteLine(word[0..5]);

////Console.WriteLine(word[^1]);
////
//Console.WriteLine(word[0].ToString().ToUpper() + word[1..]);
#endregion