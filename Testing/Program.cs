// See https://aka.ms/new-console-template for more information
using GrokNet;

var grok = new Grok("%{MONTHDA:month}-%{MONTHDAY:day}-%{MONTHDAY:year} %{TIME:timestamp};%{WORD:id};%{LOGLEVEL:loglevel};%{WORD:func};%{GREEDYDATA:msg}");

string logs = @"06-21-19 21:00:13:589241;15;INFO;main;DECODED: 775233900043 DECODED BY: 18500738 DISTANCE: 1.5165
                06-22-19 22:00:13:589265;156;WARN;main;DECODED: 775233900043 EMPTY DISTANCE: --------";

var grokResult = grok.Parse(logs);
foreach (var item in grokResult)
{
    Console.WriteLine($"{item.Key} : {item.Value}");
}
