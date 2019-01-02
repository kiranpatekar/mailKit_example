using System;
using System.Collections.Generic;
namespace sendingMail_mailkit.Model
{

// you can define a difference type of tonne of properties on an email, for example attachments, CC, BCC, headers etc but we will break it down to the basics for now. Containing all of this within a class means that we can add extra properties as we need them later on.
public class EmailMessage
{
	public EmailMessage()
	{
		ToAddresses = new List<EmailAddress>();
		FromAddresses = new List<EmailAddress>();
	}
 
	public List<EmailAddress> ToAddresses { get; set; }
	public List<EmailAddress> FromAddresses { get; set; }
	public string Subject { get; set; }
	public string Content { get; set; }
}
}