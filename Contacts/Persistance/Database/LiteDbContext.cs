using System;
using LiteDB;
using Microsoft.Extensions.Options;
using Contacts.Persistance.Interfaces;
using Contacts.Persistance.Common;

namespace Contacts.Persistance.Database
{
    public class LiteDbContext 
    {
        private readonly LiteDatabase liteDatabase;
 
        public LiteDbContext() 
        {
            liteDatabase = new LiteDatabase(@"Contact.db");
        }

        public LiteDatabase LiteDatabase => liteDatabase;
       
    }
    
}
