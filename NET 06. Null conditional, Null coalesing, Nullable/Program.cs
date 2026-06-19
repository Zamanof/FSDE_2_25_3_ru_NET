#region Null conditional operator - ?.
//string name = "SALAM";
//if (name != null) name = name.ToLower();
//if (name is not null) name = name.ToLower();

//name = name?.ToLower()!;

//Console.WriteLine(name);
#endregion

#region Null coalesing operator - ??
//string name = "Salam";
//if (name == null) name = "Empty";
//if (name is null) name = "Empty";
//name = name is null ? "Empty" : name; 

//name = name ?? "Empty";

//Console.WriteLine(name);
#endregion

#region Null forgiving operator - !
//string name = null!;
//Console.WriteLine(name);
#endregion

#region Nullable
//int? numb = null;
//Console.WriteLine(numb+3);
//Nullable<int> numb1 = null;
#endregion
