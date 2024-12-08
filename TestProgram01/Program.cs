// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TestProgram01;
using TestProgram01.classes;

Console.WriteLine("START");
// -----------------------------------------------------------------------------------


Console.WriteLine($"----------------------------------------------");

List<TestData> testDataList = new List<TestData>();
testDataList.Add(new TestData() { Id = 1, Name = "abc", BirthDay = new DateTime(2021, 5, 1) });
testDataList.Add(new TestData() { Id = 2, Name = "def", BirthDay = new DateTime(2022, 5, 1) });
testDataList.Add(new TestData() { Id = 3, Name = "ghi", BirthDay = new DateTime(2023, 5, 1) });
testDataList.Add(new TestData() { Id = 4, Name = "jkl", BirthDay = new DateTime(2021, 5, 1) });
testDataList.Add(new TestData() { Id = 5, Name = "mno", BirthDay = new DateTime(2022, 5, 1) });
testDataList.Add(new TestData() { Id = 6, Name = "pqr", BirthDay = new DateTime(2023, 5, 1) });
testDataList.Add(new TestData() { Id = 7, Name = "stu", BirthDay = new DateTime(2021, 5, 1) });
testDataList.Add(new TestData() { Id = 8, Name = "vwx", BirthDay = new DateTime(2022, 5, 1) });
testDataList.Add(new TestData() { Id = 9, Name = "yz", BirthDay = new DateTime(2023, 5, 1) });

//TestData[] testDataList2 = new TestData[testDataList.Count()];
//testDataList.CopyTo(testDataList2,0);

List<TestData> testDataList2 = new List<TestData>();
testDataList2.AddRange(testDataList);

List<TestStructData> testStructDatas = new List<TestStructData>();

foreach (var item in testDataList)
{
    Console.WriteLine($"{item.Id} - {item.Name}");
    TestStructData testStructData = new TestStructData() { Id = item.Id, Name = item.Name, BirthDay = item.BirthDay };
    testStructDatas.Add(testStructData);
}

Console.WriteLine($"----------------------------------------------");

foreach (var item in testDataList2)
{
    Console.WriteLine($"{item.Id} - {item.Name}");
}

Console.WriteLine($"\n##################################################\n");

foreach (var item in testDataList)
{
    item.Name = "abc";
}
// ++++++++++++++++++++++++++++++++++++++++++

foreach (var item in testDataList)
{
    Console.WriteLine($"{item.Id} - {item.Name}");
}

Console.WriteLine($"----------------------------------------------");

foreach (var item in testDataList2)
{
    Console.WriteLine($"{item.Id} - {item.Name}");
}

Console.WriteLine($"\n##################################################\n");

foreach (var item in testStructDatas)
{
    Console.WriteLine($"{item.Id} - {item.Name}");
}


// -----------------------------------------------------------------------------------

//HashSet<int> testList = testDataList.Select(x => x.BirthDay.Year).ToHashSet();

//foreach (var test in testList)
//{
//    Console.WriteLine(test);
//}



// -----------------------------------------------------------------------------------
//DateTime dt = new DateTime(2024, 11, 1);
//TimeSpan sp = DateTime.Now - dt;
//Console.WriteLine(sp.Days);

// -----------------------------------------------------------------------------------

//string pathToDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";
//Console.WriteLine($"pathToDir: {pathToDir}");
////Directory.CreateDirectory(pathToDir);
////string nameOfJsonFile = "AppConfig.json";
////string pathToJson = pathToDir + nameOfJsonFile;
//string name = "TestProgram01";
//string dirName = "MsSqlServerModel";

////Console.WriteLine(pathToDir);

//// C:\Meine_Projekte\C-Sharp_Repos\TestProgram01\TestProgram01\bin\Resources\

//if (!pathToDir.Contains(dirName))
//{
//    Console.WriteLine($"dirName: {dirName} - ist NICHT drin");
//    string[] stringArray = pathToDir.Split("\\");
//    //string[] newStringArray = new string[stringArray.Length];
//    Console.WriteLine("START - Array");
//    for (int i = stringArray.Length - 1; i >= 0; i--)
//    {
//        if (stringArray[i] == "bin")
//        {
//            Console.WriteLine($"stringArray[{i - 1}]: {stringArray[i - 1]}");
//            stringArray[i - 1] = dirName;

//            //break;
//        }
//    }
//    Console.WriteLine("ENDE - Array");
//    pathToDir = string.Join('\\', stringArray);

//}
//else
//    Console.WriteLine($"dirName: {dirName} - ist drin");


//Console.WriteLine($"Ende: {pathToDir}");

//string[] stringArray1 = pathToDir.Split('\\');

//foreach (string str in stringArray1)
//{
//    Console.WriteLine(str);
//}

//File.AppendAllText(pathToJson, "{}");
//Console.ReadKey();
// DICTIJONARY:
// ************
// SOURCE: https://learn.microsoft.com/de-de/dotnet/api/system.collections.generic.dictionary-2?view=net-8.0 
// Create a new dictionary of strings, with string keys.
//
//Dictionary<string, string> openWith =
//    new Dictionary<string, string>();

//// Add some elements to the dictionary. There are no
//// duplicate keys, but some of the values are duplicates.
//openWith.Add("txt", "notepad.exe");
//openWith.Add("bmp", "paint.exe");
//openWith.Add("dib", "paint.exe");
//openWith.Add("rtf", "wordpad.exe");

//// The Add method throws an exception if the new key is
//// already in the dictionary.
//try
//{
//    openWith.Add("txt", "winword.exe");
//}
//catch (ArgumentException)
//{
//    Console.WriteLine("An element with Key = \"txt\" already exists.");
//}

//// The Item property is another name for the indexer, so you
//// can omit its name when accessing elements.
//Console.WriteLine("For key = \"rtf\", value = {0}.",
//    openWith["rtf"]);

//// The indexer can be used to change the value associated
//// with a key.
//openWith["rtf"] = "winword.exe";
//Console.WriteLine("For key = \"rtf\", value = {0}.",
//    openWith["rtf"]);

//// If a key does not exist, setting the indexer for that key
//// adds a new key/value pair.
//openWith["doc"] = "winword.exe";

//// The indexer throws an exception if the requested key is
//// not in the dictionary.
//try
//{
//    Console.WriteLine("For key = \"tif\", value = {0}.",
//        openWith["tif"]);
//}
//catch (KeyNotFoundException)
//{
//    Console.WriteLine("Key = \"tif\" is not found.");
//}

//// When a program often has to try keys that turn out not to
//// be in the dictionary, TryGetValue can be a more efficient
//// way to retrieve values.
//string value = "";
//#region TEST myCode
//openWith.Add("tif", "something.exe");
//#endregion TEST myCode
//if (openWith.TryGetValue("tif", out value))
//{
//    Console.WriteLine("For key = \"tif\", value = {0}.", value);
//}
//else
//{
//    Console.WriteLine("Key = \"tif\" is not found.");
//}

//// ContainsKey can be used to test keys before inserting
//// them.
//if (!openWith.ContainsKey("ht"))
//{
//    openWith.Add("ht", "hypertrm.exe");
//    Console.WriteLine("Value added for key = \"ht\": {0}",
//        openWith["ht"]);
//}

//// When you use foreach to enumerate dictionary elements,
//// the elements are retrieved as KeyValuePair objects.
//Console.WriteLine();
//foreach (KeyValuePair<string, string> kvp in openWith)
//{
//    Console.WriteLine("Key = {0}, Value = {1}",
//        kvp.Key, kvp.Value);
//}

//// To get the values alone, use the Values property.
//Dictionary<string, string>.ValueCollection valueColl =
//    openWith.Values;

//// The elements of the ValueCollection are strongly typed
//// with the type that was specified for dictionary values.
//Console.WriteLine();
//foreach (string s in valueColl)
//{
//    Console.WriteLine("Value = {0}", s);
//}

//// To get the keys alone, use the Keys property.
//Dictionary<string, string>.KeyCollection keyColl =
//    openWith.Keys;

//// The elements of the KeyCollection are strongly typed
//// with the type that was specified for dictionary keys.
//Console.WriteLine();
//foreach (string s in keyColl)
//{
//    Console.WriteLine("Key = {0}", s);
//}

//// Use the Remove method to remove a key/value pair.
//Console.WriteLine("\nRemove(\"doc\")");
//openWith.Remove("doc");

//if (!openWith.ContainsKey("doc"))
//{
//    Console.WriteLine("Key \"doc\" is not found.");
//}

/* This code example produces the following output:

An element with Key = "txt" already exists.
For key = "rtf", value = wordpad.exe.
For key = "rtf", value = winword.exe.
Key = "tif" is not found.
Key = "tif" is not found.
Value added for key = "ht": hypertrm.exe

Key = txt, Value = notepad.exe
Key = bmp, Value = paint.exe
Key = dib, Value = paint.exe
Key = rtf, Value = winword.exe
Key = doc, Value = winword.exe
Key = ht, Value = hypertrm.exe

Value = notepad.exe
Value = paint.exe
Value = paint.exe
Value = winword.exe
Value = winword.exe
Value = hypertrm.exe

Key = txt
Key = bmp
Key = dib
Key = rtf
Key = doc
Key = ht

Remove("doc")
Key "doc" is not found.
*/

Console.WriteLine("ENDE");
