using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace REST.Controllers
{
    public class ContactController : ApiController
    {
        [HttpGet]
        public Person[] Get()
        {
            return new Person[]
            {
                
                new Person
                {
                    Id= 1,
                    Name="Kevin",
                    LastName="Rivas",
                    NickName="Kevin200500",
                    Email="201.english.rivas@gmail.com",
                    password="12345678"
                },
                new Person
                {
                    Id= 2,
                    Name="Roberto",
                    LastName="Aguilar",
                    NickName="Roberto20-05-00",
                    Email="bmwgtr3.200500@hotmail.com",
                    password="12345678"
                }
            };
        }
    }
}
