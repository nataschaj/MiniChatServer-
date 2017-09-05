# MiniChatServer-
AnEchoServerOPG


ZiBaT => Peter Levinsky => Tech => exercise
Introduction 
Simple Server - Echo Server
Updated : 2017-08-26

More Server - An Echo Plus Server (Mini Chat)

Mission:

To design and program two programs one to be an minichat-server and one to be an minichat-client
Again NO APP-application.

Background:

Exercise Simple Server

For programming en iterative server in C# Console Application

(Reference) Task: https://msdn.microsoft.com/en-us/library/system.threading.tasks.task(v=vs.110).aspx
(General) Doc	for Task: https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-based-asynchronous-programming
Assignment A: An Mini Chat Server

  In Visual Studio 2015/2017   Create a new solution 'ConsoleApp (framework)', and name it e.g. 'MiniChatServer'.
(NB! in 2017 do NOT choose 'ConsoleApp .Net Core', which have restricted API's)
Create a class 'Server' and create a method 'Start'.
In the start method
Create a TcpListener with the parameter IP = IPAddress.Loopback and PORT = 7070 .
Start the TcpListener.
in a Server loop - to handle more than one client
Open for incomming socket and for reading and writing -- All these should be in an using-statement (This give you the benefit of indirrect closing all sockets and streams in the using-statement)
On the TcpListener 'AcceptTcpClient()' and name it 'socket'.
From the TcpClient 'GetStream()' and name it 'ns'.
Wrap the stream into reading and writing i.e. 'new StreamReader(ns)' & 'new StreamWriter(ns)'.
In a loop
Read a line from your stream-reader ('ReadLine()') save it in a String and name it 'line' and print it on teh screen (Console).
Read a line from the console (Console.ReadLine()) save it in a string (e.g. 'myLine')
Write back the 'myLine' to your stream-writer ('WriteLine(line)') -- then remember to 'Flush()' the stream-writer.
Until you either 'line' or 'myLine' is "STOP" then stop and close the server
In Main create an object of your Server-class and call the method 'Start()'.
Commit and push your server-solution to a Git-Repository.
Assignment B: Refactor Your Server

Refactor your server so all the code to handle your client is extracted in a method 'DoClient'.
Commit your project.
Assignment C:  An MiniChat Client

In your solution create a new project (AGAIN 'ConsoleApp (framework)' and NOT ConsoleApp .Net Core, and name it 'MiniChatClient'.
Create a class 'Client' and create a method 'Start'.
In the start method
Open for a new socket and for reading and writing -- All these should be in an using-statement
Create a TcpClient with the parameter IP = IPAddress.Loopback and PORT = 7070 and name it 'socket'.
From the TcpClient 'GetStream()' and name it 'ns'.
Wrap the stream into reading and writing i.e. 'new StreamReader(ns)' & 'new StreamWriter(ns)'.
in a Loop
Read a line from the console
Write the line to your stream-writer -- then remember to 'Flush()' the stream-writer.
Read a line from your stream-reader ('ReadLine()') save it in a String and name it 'line'.
Print out the line in the console window ('Console.WriteLine(line)).
Until either
you own line or the incomming list is "STOP"
In Main create an object of your Client-class and call the method 'Start()'.
Commit and push your Client-solution to a Git-Repository.
Assignment D:  Run The Server And The Client

In your solution
Start your server
start your client
Try to start another client - what happen ?
Can you have a comminication with one client - and at the same time with another?
Assignment E:  Refactor The Server

Refactor the server to make use of the DoClient in a seperate thrad / Task i.e. Task.Run(DoClient(socket)).
Try the assignment D again - how is it now - can you handle two(many) client at the same time?
Commit and push your Client-solution to a Git-Repository.
 

Assignment Extra A: Refactor Your Server And Client To Work Asynchronous

The server and the client should be able to sent or receive several messages before receive og sent a message e.g. sent two messages then receive three

Hint You need to use a Task for sending and another for receiving - so you will get a lot of tasks.

Assignment Extra B: Refactor Your Server To Work Like A Simple HTTP-Server

The server (port 8989) should read the first line in a http request (see the book) split the requestline in three (method, uri, version)

If the method is get - then open the file specified in the uri and send it back - compling the http Response (see the book)

send a response line (version(you case always 1.0), statuscode, status msg), blank line, then the body i.e. the file to be sent back

You can try your server from any browser. e.g. localhost:8989/testfile.txt
