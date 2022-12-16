// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using UC3_RemoveWordHashtable.Hashtable;

MyMapNode<string, string> hashtable = new MyMapNode<string, string>(18);

hashtable.Add("f0", "“Paranoids");
hashtable.Add("f1", "are");
hashtable.Add("f2", "not");
hashtable.Add("f3", "paranoid");
hashtable.Add("f4", "because");
hashtable.Add("f5", "they");
hashtable.Add("f6", "are");
hashtable.Add("f7", "paranoid");
hashtable.Add("f8", "but");
hashtable.Add("f9", "because");
hashtable.Add("f10", "they");
hashtable.Add("f11", "keep");
hashtable.Add("f12", "putting");
hashtable.Add("f13", "themselves");
hashtable.Add("f14", "deliberately");
hashtable.Add("f15", "into");
hashtable.Add("f16", "paranoid");
hashtable.Add("f17", "avoidable");
hashtable.Add("f18", "situations”");

hashtable.RemovePerticularElement("f15");
Console.WriteLine("into was deleted from the above paragraph");
