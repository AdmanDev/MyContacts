using System;
using System.Collections.Generic;

namespace MyContacts
{
    public static class Global
    {
        //Variables
        public static List<Group> contactsGroup = new List<Group>()
        {
            new Group("Amis"),
            new Group("Travail"),
            new Group("Famille")
        };
    }
}
