using System;
using sendingMail_mailkit.Model;
using System.Collections.Generic;
namespace sendingMail_mailkit.Services
{

public interface IEmailService
{
	void Send(EmailMessage emailMessage);
	List<EmailMessage> ReceiveEmail(int maxCount = 10);
}
}