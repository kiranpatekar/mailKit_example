# mailKit_example
simple .net core project to demostrate use of mailkit using .net core 2.1 dependancy injection


postman call 

https://localhost:5001/api/Values/ContactUs

{
	"ToAddresses" :
	[
		{
		"Name" : "enter  name here",
		"Address" :"enter  email address here"
		},
		{
		"Name" : "second email",
		"Address" :"email address here"
		}
		
		
	],
	"FromAddresses" :
	[	{
		"Name" : "your email user name",
		"Address" :"your email address"
		},
		{
		"Name" : "secondary email user name",
		"Address" :"secondary email address"
		}
		],
	"Subject" : "subject title..."	,
	"Content" : "mail content"
	
	
}
