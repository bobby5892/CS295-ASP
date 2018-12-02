using System;
using System.Collections.Generic;
using Xunit;
using community.Repositories;
using community.Models;
using community.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Linq;
using System.Threading.Tasks;


namespace communityTests
{
    public class CommunityTests
    {
        [Fact]
        public void Test1()
        {
            //Test Testing
            Assert.True(true);
        }
        [Fact]
        public void AddContactTest()
        {
            ContactRepository contactRepo = new ContactRepository();
            contactRepo.Contacts.Add(new User() { EmailAddress = "bob@example.com", Name = "Bob B." });

            Assert.True(contactRepo.Contacts[0].EmailAddress == "bob@example.com");
        }
        [Fact(Skip ="Weird Reference Required")]
        public void AddMessageViaConrollerTest()
        {
            ContactRepository contactRepo = new ContactRepository();
            contactRepo.Contacts.Add(new User() { EmailAddress = "bob@example.com", Name = "Bob B." });
            contactRepo.Contacts.Add(new User() { EmailAddress = "ted@example.com", Name = "ted" });

            FakeMessageRepository fakeMessages = new FakeMessageRepository();
            fakeMessages.AddTestData(contactRepo.Contacts);

            HomeController homeController = new HomeController(contactRepo,fakeMessages);
         
           // homeController.Messages( "Ted",  "teddy@example.com", "messager", "Testing",  false);
            Assert.True(homeController.messagesRepo.Messages[3].From.EmailAddress == "teddy@example.com");
        }
        [Fact]
        public void AddMessageViaRepo()
        {
            ContactRepository contactRepo = new ContactRepository();
            contactRepo.Contacts.Add(new User() { EmailAddress = "bob@example.com", Name = "Bob B." });
            contactRepo.Contacts.Add(new User() { EmailAddress = "ted@example.com", Name = "ted" });

            FakeMessageRepository fakeMessages = new FakeMessageRepository();
            fakeMessages.AddTestData(contactRepo.Contacts);
            
            Assert.True(fakeMessages.Messages[2].From.EmailAddress == "tom@example.com");
        }
    }
}
